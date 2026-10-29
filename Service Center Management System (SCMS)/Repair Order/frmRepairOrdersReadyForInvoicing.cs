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
    public partial class frmRepairOrdersReadyForInvoicing : Form
    {
        public frmRepairOrdersReadyForInvoicing()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmRepairOrdersReadyForInvoicing_Load(object sender, EventArgs e)
        {
            ucRepairOrdersReadyForInvoicing1.IssueInvoice = _IssueInvoice;
            ucRepairOrdersReadyForInvoicing1.ShowRepairOrderDetails = _ShowRepairOrderDetails;

            await ucRepairOrdersReadyForInvoicing1.LoadRepairOrdersReadyforInvoicing();
        }


        private void _IssueInvoice(int RepairOrderID)
        {
            frmIssueInvoice frm = new frmIssueInvoice(RepairOrderID, true);

            frm.ShowDialog();
        }

        private void _ShowRepairOrderDetails(int RepairOrderID)
        {
            frmShowRepairOrderDetails frm = new frmShowRepairOrderDetails(RepairOrderID);

            frm.ShowDialog();
        }
    }
}
