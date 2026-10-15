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
    public partial class frmViewRepairOrdersForDevice : Form
    {
        int _DeviceID;
        public frmViewRepairOrdersForDevice(int DeviceID)
        {
            InitializeComponent();

            _DeviceID = DeviceID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmViewRepairOrdersForDevice_Load(object sender, EventArgs e)
        {
            ucViewRepairOrdersForDevice1.ShowRepairOrderDetails = _ShowRepairOrderDetails;
            await ucViewRepairOrdersForDevice1.LoadRepairOrdersForDevice(_DeviceID);

        }

        private void _ShowRepairOrderDetails(int RepairOrderID)
        {
            frmShowRepairOrderDetails frm = new frmShowRepairOrderDetails(RepairOrderID);

            frm.ShowDialog();
        }
    }
}
