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
    public partial class ucRepairOrdersReadyForInvoicing : UserControl
    {
        public Action<int> IssueInvoice;
        public Action<int> ShowRepairOrderDetails;
        public ucRepairOrdersReadyForInvoicing()
        {
            InitializeComponent();
        }

        public async Task LoadRepairOrdersReadyforInvoicing()
        {
            DataTable _AllRepairOrders =
                await clsRepairOrder.GetAllRepairOrdersReadyForInvoicingAsync();

            dgvAllRepairOrders.DataSource = _AllRepairOrders;
            lblNumberOfRepairOrders.Text = _AllRepairOrders.Rows.Count.ToString();
        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            guna2ContextMenuStrip1.Enabled = dgvAllRepairOrders.CurrentRow != null;
        }

        private async void issueInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
           int RepairOrderID = (int)dgvAllRepairOrders.CurrentRow.Cells[0].Value;

           IssueInvoice?.Invoke(RepairOrderID);

           await LoadRepairOrdersReadyforInvoicing();
        }

        private void showRepairOrderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRepairOrderDetails?.Invoke((int)dgvAllRepairOrders.CurrentRow.Cells[0].Value);
        }
    }
}
