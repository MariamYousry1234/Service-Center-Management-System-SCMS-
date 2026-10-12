using SCMS_Business_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;

namespace Service_Center_Management_System__SCMS_
{
    public partial class frmShowPaymentHistory : Form
    {
        int _RepairOrderID;
        public frmShowPaymentHistory(int RepairOrderID)
        {
            InitializeComponent();

            _RepairOrderID = RepairOrderID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmShowPaymentHistory_Load(object sender, EventArgs e)
        {
            ucShowPaymentHistoryForRepairOrder1.DeletePayment = _DeletedPayment;

            await ucShowPaymentHistoryForRepairOrder1.LoadAllPayments(_RepairOrderID);
        }

        private async void ucShowPaymentHistoryForRepairOrder1_OnUpdateClick(int obj)
        {
            frmAddEditPayment frm = new frmAddEditPayment(obj);

            frm.ShowDialog();

           await ucShowPaymentHistoryForRepairOrder1.RefreshPayments();
        }


        private bool _DeletedPayment(int PaymentID)
        {

            if (clsPayment.DeletePayment(PaymentID, clsGlobal.CurrentUser.UserID))
            {

                MessageBox.Show("Payment deleted successfully.",
                 "Success",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);

                 return true;
            }
            else
            {
                MessageBox.Show("Failed to delete payment.",
                     "Error",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                 return false;
            }

        
        }
    }
}
