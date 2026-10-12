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
    public partial class ucInvoicesAwaitingPayment : UserControl
    {
      
        public class SCMSArgs : EventArgs
        {
           public int RepairOrderID { get; }

            public SCMSArgs(int RepairOrderID)
            {
                this.RepairOrderID = RepairOrderID;
            }
        }

        public event EventHandler <SCMSArgs> OnRecordPaymentClick;
        public event EventHandler<SCMSArgs> OnShowPaymentHistoryClick;

        public ucInvoicesAwaitingPayment()
        {
            InitializeComponent();
        }

        public async Task LoadInvoiceAwaitingPayment()
        {
            DataTable _AllInvoices =
                await clsInvoice.GetAllInvoicesAwaitingPaymentAsync();

            dgvAllRepairOrders.DataSource = _AllInvoices;
            lblNumberOfRepairOrders.Text = _AllInvoices.Rows.Count.ToString();
        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            guna2ContextMenuStrip1.Enabled =
                dgvAllRepairOrders.CurrentRow != null;
        }

        private async void showPaymentsHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnShowPaymentHistoryClick?.Invoke(this,
                new SCMSArgs((int)dgvAllRepairOrders.CurrentRow.Cells[1].Value));

            await LoadInvoiceAwaitingPayment();
        }

        private async void recordPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnRecordPaymentClick?.Invoke(this,
                new SCMSArgs((int)dgvAllRepairOrders.CurrentRow.Cells[1].Value));

            await LoadInvoiceAwaitingPayment();
        }
    }
}
