using SCMS_Business_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCMSControlsLib
{
    public partial class ucShowDeviceInfo : UserControl
    {
        clsDevice _Device;
        int? _DeviceID = null;
        public ucShowDeviceInfo()
        {
            InitializeComponent();
        }

        public int? DeviceID
        {
            get
            {
                return _DeviceID;
            }
        }

        public clsDevice DeviceInfo
        { 
            get
            {
                return _Device;
            }
        }
        private void _SetIntialData()
        { 
            gbDeviceInfo.Text = "Device ID = [???]";
            lblCustomerID.Text = "[???]";
            lblCustomerName.Text = "[???]";
            lblDeviceTypeID.Text = "[???]";
            lblDeviceTypeName.Text = "[???]";
            lblBrandID.Text = "[???]";
            lblBrandName.Text = "[???]";
            lblModelID.Text = "[???]";
            lblModelName.Text = "[???]";
            lblSerialNumber.Text = "[???]";
            lblColor.Text = "[???]";
          
            lblCreatedByUser.Text = "[???]";
            lblCreatedDate.Text = "[???]";
            lblLastUpdatedUser.Text = "[???]";
            lblLastUpdatedDate.Text = "[???]";
        }

        private void _LoadData()
        {
            _DeviceID = _Device.DeviceID;
            gbDeviceInfo.Text = $"Device ID = {_Device.DeviceID}";
            lblCustomerID.Text =_Device.CustomerID.ToString();
            lblCustomerName.Text = _Device.CustomerInfo.FullName;
            lblDeviceTypeID.Text = _Device.DeviceTypeID.ToString();
            lblDeviceTypeName.Text =_Device.DeviceTypeInfo.DeviceTypeName;
            lblBrandID.Text = _Device.BrandID.ToString();
            lblBrandName.Text = _Device.BrandInfo.BrandName;
            lblModelID.Text = _Device.ModelID.ToString();
            lblModelName.Text =_Device.ModelInfo.ModelName;
            lblSerialNumber.Text =_Device.SerialNumber;
            lblColor.Text = _Device.txtColor;
 
            lblCreatedByUser.Text =_Device.CreatedUserInfo.Username;
            lblCreatedDate.Text = _Device.CreatedDate.ToString("dd/MM/yyyy");
            lblLastUpdatedUser.Text = _Device.LastUpdatedUserInfo?.Username??"Not found";
            lblLastUpdatedDate.Text =_Device.LastUpdatedDate?.ToString("dd/MM/yyyy")?? "Not found";
        }
        public void LoadDeviceInfo(int DeviceID)
        {
            _Device = clsDevice.FindDevice(DeviceID);

            if(_Device ==null)
            {
                _DeviceID = null;
                _SetIntialData();
                MessageBox.Show($"Device with id = {DeviceID} Not found!",
                    "Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            _LoadData();
        }

        public void LoadDeviceInfoBySerialNumber(string SerialNumber)
        {
            _Device = clsDevice.FindDevice(SerialNumber);

            if (_Device == null)
            {
                _DeviceID = null;
                _SetIntialData();
                MessageBox.Show($"Device with serial number = {SerialNumber} Not found!",
                    "Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            _LoadData();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
