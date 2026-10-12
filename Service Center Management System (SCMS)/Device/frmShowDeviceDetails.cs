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
    public partial class frmShowDeviceDetails : Form
    {
        int _DeviceID;
        public frmShowDeviceDetails(int DeviceID)
        {
            InitializeComponent();

            _DeviceID = DeviceID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowDeviceDetails_Load(object sender, EventArgs e)
        {
            ucShowDeviceInfo1.LoadDeviceInfo(_DeviceID);
        }
    }
}
