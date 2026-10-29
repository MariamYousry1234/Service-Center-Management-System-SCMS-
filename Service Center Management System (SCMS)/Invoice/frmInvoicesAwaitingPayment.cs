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
    public partial class frmInvoicesAwaitingPayment : Form
    {
        public frmInvoicesAwaitingPayment()
        {
            InitializeComponent();
        }

        private void ucInvoicesAwaitingPayment1_OnRecordPaymentClick(object sender, SCMSControlsLib.ucInvoicesAwaitingPayment.SCMSArgs e)
        {   
            frmAddEditPayment frm = new frmAddEditPayment(e.RepairOrderID, true);

            frm.ShowDialog();
        }

        private void ucInvoicesAwaitingPayment1_OnShowPaymentHistoryClick(object sender, SCMSControlsLib.ucInvoicesAwaitingPayment.SCMSArgs e)
        {
            clsRepairOrder _RepairOrder = clsRepairOrder.Find(e.RepairOrderID);

            if (!_RepairOrder.HasPayments)
            {
                MessageBox.Show(
                   "This repair order does not have any payments yet.",
                   "No Payments Found",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);

                return;
            }


            frmShowPaymentHistory frm = new frmShowPaymentHistory(_RepairOrder.RepairOrderID);

            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmInvoicesAwaitingPayment_Load(object sender, EventArgs e)
        {
           await ucInvoicesAwaitingPayment1.LoadInvoicesAwaitingPayment();
        }

        private void ucInvoicesAwaitingPayment1_OnShowInvoiceDetailsClick(object sender, SCMSControlsLib.ucInvoicesAwaitingPayment.SCMSArgs e)
        {
            frmShowInvoiceDetails frm =
                new frmShowInvoiceDetails(e.RepairOrderID,true);

            frm.ShowDialog();
        }

        private void ucInvoicesAwaitingPayment1_OnShowRepairOrderDetailsClick(object sender, SCMSControlsLib.ucInvoicesAwaitingPayment.SCMSArgs e)
        {
            frmShowRepairOrderDetails frm = new frmShowRepairOrderDetails(e.RepairOrderID);

            frm.ShowDialog();
        }
    }
}
