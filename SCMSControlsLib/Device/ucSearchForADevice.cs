using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCMS_Business_Logic;

namespace SCMSControlsLib
{
    public partial class ucSearchForADevice : UserControl
    {
        public ucSearchForADevice()
        {
            InitializeComponent();

            cbField.SelectedIndex = 0;
        }
        public clsDevice DeviceInfo
        {
            get
            {
                return ucShowDeviceInfo1.DeviceInfo;
            }
        }
        public bool gbEnabled
        {
            set
            {
                gbSearch.Enabled = value;
            }
            get
            {
                return gbSearch.Enabled;
            }
        }
        public int? DeviceID
        {
            get
            {
                return ucShowDeviceInfo1.DeviceID;
            }
        }
        public void txtFocus()
        {
            txtSearch.Focus();
        }

        public void LoadDeviceInfo(int DeviceID)
        {
            cbField.SelectedIndex = 0;
            txtSearch.Text = DeviceID.ToString();
            ucShowDeviceInfo1.LoadDeviceInfo(DeviceID);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!txtSearch.IsValid()) return;

            switch(cbField.SelectedItem.ToString())
            {
                case "Device ID":
                    {
                        ucShowDeviceInfo1.LoadDeviceInfo(Convert.ToInt32(txtSearch.Text.Trim()));
                    }
                    break;

                case "Serial Number":
                    {
                        ucShowDeviceInfo1.LoadDeviceInfoBySerialNumber(txtSearch.Text.Trim());
                    }
                    break;

            }

            txtSearch.Focus();
        }

        private void cbField_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtSearch.Focus();

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnSearch.PerformClick();
        }
    }
}
