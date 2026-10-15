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
    public partial class frmShowAllPaymentsForCustomer : Form
    {
        int _CustomerID;
        public frmShowAllPaymentsForCustomer(int CustomerID)
        {
            InitializeComponent();

            _CustomerID = CustomerID;
        }

        private async void frmShowAllPaymentsForCustomer_Load(object sender, EventArgs e)
        {
            ucShowAllPaymentsForCustomer1.ShowRepairOrderDetials = _ShowRepairOrderDetails;
            ucShowAllPaymentsForCustomer1.ShowInvoiceDetials = _ShowInvoiceDetials;
            ucShowAllPaymentsForCustomer1.ShowCreatedUserInfo = _ShowCreatedUserInfo;

          await  ucShowAllPaymentsForCustomer1.LoadPaymentForCustomer(_CustomerID);
        }

        private void _ShowRepairOrderDetails(int RepairOrderID)
        {
            frmShowRepairOrderDetails frm = new frmShowRepairOrderDetails(RepairOrderID);

            frm.ShowDialog();
        }

        private void _ShowInvoiceDetials(int InvoiceID)
        {
            frmShowInvoiceDetails frm = new frmShowInvoiceDetails(InvoiceID);

            frm.ShowDialog();
        }

        private void _ShowCreatedUserInfo(int CreatedUserID)
        {
            frmShowUserInfo frm = new frmShowUserInfo(CreatedUserID);

            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
