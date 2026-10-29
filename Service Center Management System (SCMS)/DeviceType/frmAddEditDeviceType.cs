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

namespace Service_Center_Management_System__SCMS_
{
    public partial class frmAddEditDeviceType : Form
    {
        enum enMode { AddNew =0,Update=1}
        enMode _Mode = enMode.AddNew;

        clsDeviceType _DeviceType;
        int _DeviceTypeID;
        public frmAddEditDeviceType()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
            _DeviceType = new clsDeviceType();
        }
        public frmAddEditDeviceType(int DeviceTypeID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _DeviceTypeID = DeviceTypeID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _SetIntialData()
        {
            if (_Mode == enMode.AddNew)
            {
                this.Text = "Add New Device Type";
                lblTitle.Text = "Add New Device Type";
                lblDeviceTypeID.Text = "[???]";
                txtDeviceName.Clear();
 
            }
            else
            {
                this.Text = "Update Device Type Info";
                lblTitle.Text = "Update Device Type Info";
            }
            txtDeviceName.Focus();
        }

        private void _LoadDataToUpdate()
        {
            _DeviceType = clsDeviceType.FindDeviceType(_DeviceTypeID);

            if(_DeviceType == null)
            {
                MessageBox.Show($"Can not find device type with id={_DeviceTypeID}", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblDeviceTypeID.Text = _DeviceType.DeviceTypeID.ToString();
            txtDeviceName.Text = _DeviceType.DeviceTypeName;
            txtDeviceName.SelectionStart = txtDeviceName.Text.Length;
        }
        private void frmAddEditDeviceType_Load(object sender, EventArgs e)
        {
            _SetIntialData();

            if (_Mode == enMode.Update)
                _LoadDataToUpdate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!txtDeviceName.IsValid()) return;

            int? DeviceTypeID = clsDeviceType.GetDeviceTypeIDByName(txtDeviceName.Text.Trim());
            if (DeviceTypeID != null)
            {
                MessageBox.Show($"This device type name already exists with id = {DeviceTypeID}", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            _DeviceType.DeviceTypeName = txtDeviceName.Text;

            if(_DeviceType.Save())
            {
                MessageBox.Show($"Data Saved Successfully", "Saved", MessageBoxButtons.OK,
                  MessageBoxIcon.Information);

                _Mode = enMode.Update;
                lblDeviceTypeID.Text = _DeviceType.DeviceTypeID.ToString();
                _SetIntialData();
            }
            else
            {
                MessageBox.Show("Failed to save customer data.", "An error occurred", MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
        }

        private void frmAddEditDeviceType_Activated(object sender, EventArgs e)
        {
            txtDeviceName.Focus();
        }
    }
}
