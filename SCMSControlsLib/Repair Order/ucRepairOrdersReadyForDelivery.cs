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
    public partial class ucRepairOrdersReadyForDelivery : UserControl
    {
        public Action<int> RecordDelivery;
        public Action<int> ShowRepairOrderDetails;

        public ucRepairOrdersReadyForDelivery()
        {
            InitializeComponent();
        }

        public async Task LoadRepairOrdersReadyforDelivery()
        {
            DataTable _AllRepairOrders =
                await clsRepairOrder.GetAllRepairOrdersReadyForDeliveryAsync();

            dgvAllRepairOrders.DataSource = _AllRepairOrders;

            if (dgvAllRepairOrders.Rows.Count > 0)
            {
                dgvAllRepairOrders.Columns[2].Width = 250;
                dgvAllRepairOrders.Columns[4].Width = 250;
                dgvAllRepairOrders.Columns[6].Width = 200;
                dgvAllRepairOrders.Columns[8].Width = 150;
                dgvAllRepairOrders.Columns[9].Width = 150;
            }

            lblNumberOfRepairOrders.Text = _AllRepairOrders.Rows.Count.ToString();
        }

        private async void recordDeliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecordDelivery?.Invoke((int)dgvAllRepairOrders.CurrentRow.Cells[0].Value);

           await LoadRepairOrdersReadyforDelivery();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            contextMenuStrip1.Enabled = dgvAllRepairOrders.CurrentRow != null;               
        }

        private void showRepairOrderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRepairOrderDetails?.Invoke((int)dgvAllRepairOrders.CurrentRow.Cells[0].Value);
        }
    }
}
