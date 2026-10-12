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
    public partial class frmRepairOrdersReadyForDelivery : Form
    {
        public frmRepairOrdersReadyForDelivery()
        {
            InitializeComponent();
        }

        private async void frmRepairOrdersReadyForDelivery_Load(object sender, EventArgs e)
        {
            ucRepairOrdersReadyForDelivery1.RecordDelivery = _RecordDelivery;

            await ucRepairOrdersReadyForDelivery1.LoadRepairOrdersReadyforDelivery();
        }


        private void _RecordDelivery(int RepairOrderID)
        {
            frmAddEditDelivery frm = new frmAddEditDelivery(RepairOrderID, true);

            frm.ShowDialog();   
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
