using SCMS_Business_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service_Center_Management_System__SCMS_
{
    public partial class frmAddEditDevice : Form
    {
        public Action<int> DelegateDeviceID;
        enum enMode { AddNew=0,Update=1}
        enMode _Mode = enMode.AddNew;

        clsDevice _Device;
        int _DeviceID;

        bool _IsLoadingData=false;
        public frmAddEditDevice()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        public frmAddEditDevice(int DeviceID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _DeviceID = DeviceID;
        }

        private async Task  _SetDeviceTypesComboBox()
        {
            DataTable dt = await clsDeviceType.GetAllDeviceTypeNamesAsync();

            foreach(DataRow Row in dt.Rows)
            {
                cbDeviceType.Items.Add(Row["DeviceTypeName"].ToString());
            }
    
        }

        private async Task _SetBrandsComboBox()
        {
            DataTable dt = await clsBrand.GetAllBrandNamesAsync();

            foreach (DataRow Row in dt.Rows)
            {
                cbBrandName.Items.Add(Row["BrandName"].ToString());
            }
        }

        private async Task _SetModelsComboBox(int BrandID)
        {
            cbModelName.Items.Clear();
            DataTable dt = await clsModel.GetModelsForBrandAsync(BrandID);

            foreach (DataRow Row in dt.Rows)
            {
                cbModelName.Items.Add(Row["Model Name"].ToString());
            }

            cbModelName.SelectedIndex = 0;
        }
        private async Task _SetIntialData()
        {
            Task task1= _SetDeviceTypesComboBox();
            Task task2 =  _SetBrandsComboBox();

            await Task.WhenAll(task1,task2);
      
            if (_Mode==enMode.AddNew)
            {
                this.Text = "Add New Device";
                lblTitle.Text= "Add New Device";
                lblDeviceID.Text = "???";
                lblUserCreated.Text = clsGlobal.CurrentUser.Username;
                lblCreatedDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                cbDeviceType.SelectedIndex = 0;
                cbBrandName.SelectedIndex = 0;
                cbColor.SelectedIndex = 0;
            }
            else
            {
                this.Text = "Update Device Info";
                lblTitle.Text = "Update Device Info";
            }
        }

        private async Task _LoadDate()
        {
            await _SetIntialData();

            if (_Mode == enMode.AddNew)
            {
                _Device = new clsDevice();
                ucSearchForCustomerWithAddEdit1.LoadCustomerInfo();
            }
            else
            {
                _Device = clsDevice.FindDevice(_DeviceID);

                if (_Device == null)
                {
                    MessageBox.Show($"Device with id={_DeviceID} Not found !");
                    return;
                }

                ucSearchForCustomerWithAddEdit1.LoadCustomerInfo(_Device.CustomerID);

                lblDeviceID.Text = _DeviceID.ToString();
                cbDeviceType.SelectedItem = _Device.DeviceTypeInfo.DeviceTypeName;

                //
                _IsLoadingData = true;

                cbBrandName.SelectedItem = _Device.BrandInfo.BrandName;
                await _LoadModelsForBrand();
                cbModelName.SelectedItem = _Device.ModelInfo.ModelName;
                txtSerialNumber.Text = _Device.SerialNumber;
                cbColor.SelectedItem = _Device.txtColor;
                lblUserCreated.Text = _Device.CreatedUserInfo.Username;
                lblCreatedDate.Text = _Device.CreatedDate.ToString("dd/MM/yyyy");

                _IsLoadingData = false;
                //
            }

        }
        private async Task _LoadModelsForBrand()
        {
            int CurrentBrandID = clsBrand.FindBrand(cbBrandName.Text).BrandID;

            await _SetModelsComboBox(CurrentBrandID);


        }
        private async void cbBrandName_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (_IsLoadingData) return;

            await _LoadModelsForBrand();
        }

        private async void frmAddEditDevice_Load(object sender, EventArgs e)
        {
            await _LoadDate();
            ucSearchForCustomerWithAddEdit1.SavedCustomer = _GetCustomerID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!txtSerialNumber.IsValid()) return;

            if(ucSearchForCustomerWithAddEdit1.CustomerID == null)
            {
                MessageBox.Show("No customer has been selected!", "Invalid", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            int? DeviceID = clsDevice.GetDeviceIDBySerialNnumber(txtSerialNumber.Text.Trim());

            //is serial number exists
            if ((_Mode == enMode.AddNew && DeviceID != null )
                || (_Mode == enMode.Update  && DeviceID != null
                && DeviceID != _Device.DeviceID))
            {
              
                MessageBox.Show($"This device with serial number = {txtSerialNumber.Text.Trim()} already exists with id= {DeviceID}",
                    "",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }


            if (MessageBox.Show("Are you sure you want to save device date?", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.Cancel) return;


            _Device.CustomerID = ucSearchForCustomerWithAddEdit1.CustomerID.Value;
            _Device.DeviceTypeID = clsDeviceType.FindDeviceType(cbDeviceType.Text).DeviceTypeID;
            int BrandID = clsBrand.FindBrand(cbBrandName.Text).BrandID;
            _Device.BrandID = BrandID;
            _Device.ModelID = clsModel.FindModel(BrandID, cbModelName.Text).ModelID;
            _Device.SerialNumber = txtSerialNumber.Text;
            _Device.Color = (clsDevice.enColor)(cbColor.SelectedIndex + 1);

            if(_Mode==enMode.AddNew)
                _Device.CreatedByUserID = clsGlobal.CurrentUser.UserID;
           
            else
                _Device.LastUpdatedUserID= clsGlobal.CurrentUser.UserID;
            

            if(_Device.Save())
            {
                MessageBox.Show("Data saved successfully", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                _Mode = enMode.Update;
                _DeviceID = _Device.DeviceID;
                lblDeviceID.Text = _DeviceID.ToString();
                this.Text = "Update Device Info";
                lblTitle.Text = "Update Device Info";

                ucSearchForCustomerWithAddEdit1.LoadCustomerInfo(_Device.CustomerID);

                DelegateDeviceID?.Invoke(_Device.DeviceID);
            }
            else
            {
                MessageBox.Show(
                    "Data was not saved.",
                    "Error",
                    MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }
        }

        private int? _GetCustomerID(int? CustomerID)
        {
            int? NewCustomerID = null;

            frmAddEditCustomer frm;
            if (_Mode==enMode.AddNew)
            {
                 frm = new frmAddEditCustomer();  
            }
            else
            {
                frm = new frmAddEditCustomer(CustomerID.Value);
            }

            frm.CustomerID += (int CustomerId) =>
            {
                NewCustomerID = CustomerId;
            };
            frm.ShowDialog();

            return NewCustomerID;
        }

   
        private void frmAddEditDevice_Activated(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddNew)
                ucSearchForCustomerWithAddEdit1.txtFocus();
        }
    }
}
