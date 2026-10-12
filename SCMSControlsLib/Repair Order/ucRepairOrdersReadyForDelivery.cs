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
        public ucRepairOrdersReadyForDelivery()
        {
            InitializeComponent();
        }

        public async Task LoadRepairOrdersReadyforDelivery()
        {
            DataTable _AllRepairOrders =
                await clsRepairOrder.GetAllRepairOrdersReadyForDeliveryAsync();

            dgvAllRepairOrders.DataSource = _AllRepairOrders;
            lblNumberOfRepairOrders.Text = _AllRepairOrders.Rows.Count.ToString();
        }

        private async void recordDeliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecordDelivery?.Invoke((int)dgvAllRepairOrders.CurrentRow.Cells[0].Value);

           await LoadRepairOrdersReadyforDelivery();
        }

    }
}
