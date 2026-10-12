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
    public partial class ucSearchForDeviceWithAddEdit : UserControl
    {
        public Func<int?, int?> DeviceSaved;
        public ucSearchForDeviceWithAddEdit()
        {
            InitializeComponent();
        }

        public int? DeviceID
        {
            get
            {
                return ucSearchForADevice1.DeviceID;
            }
        }

        public clsDevice DeviceInfo
        {
            get
            {
                return ucSearchForADevice1.DeviceInfo;
            }
        }

        public void LoadDeviceInfo(int? DeviceID = null)
        {
            if (DeviceID == null)
            {
                ucSearchForADevice1.txtFocus();
                btnAddEditDevice.Text = "Add New Device";
            }
            else
            {

                btnAddEditDevice.Text = "Edit Device Info";

                ucSearchForADevice1.LoadDeviceInfo(DeviceID.Value);
                ucSearchForADevice1.gbEnabled = false;
            }
        }

        private void btnAddEditDevice_Click(object sender, EventArgs e)
        {
           int? DeviceID= DeviceSaved?.Invoke(ucSearchForADevice1.DeviceID);

            if (DeviceID != null)
                ucSearchForADevice1.LoadDeviceInfo(DeviceID.Value);
        }
    }
}
