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
    public partial class ucShowPaymentHistoryForRepairOrder : UserControl
    {

        public event Action<int> OnUpdateClick;
        public Predicate<int> DeletePayment;

        clsRepairOrder _RepairOrder;
        int? _RepairOrderID;
        public ucShowPaymentHistoryForRepairOrder()
        {
            InitializeComponent();
        }

        public async Task RefreshPayments()
        {
            if (_RepairOrderID == null) return;

           await LoadAllPayments(_RepairOrderID.Value);
        }

        public async Task LoadAllPayments(int RepairOrderID)
        {
            _RepairOrder = clsRepairOrder.Find(RepairOrderID);

            if (_RepairOrder == null)
            {
                MessageBox.Show("Repair Order Not found!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gbAllPayments.Text = "All Payments For Repair Order ID = [???]";
                _RepairOrderID = null;
                return;
            }

            _RepairOrderID = RepairOrderID;

            if(!_RepairOrder.HasInvoice)
            {
                MessageBox.Show(
                  "This Repair Order does not have an invoice yet.",
                  "No Invoice",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);

                gbAllPayments.Text = "All Payments For Repair Order ID = [???]";
                return;
            }
            gbAllPayments.Text = $"All Payments For Repair Order ID  = {RepairOrderID}";
            dgvAllPayments.DataSource =await _RepairOrder.GetAllPayments();

            if (dgvAllPayments.Rows.Count > 0)
            {
                dgvAllPayments.Columns[5].Width = 170;
            }

            lblNumberOfPayments.Text = dgvAllPayments.Rows.Count.ToString();
        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
           
            if(_RepairOrderID == null || !_RepairOrder.HasInvoice)
            {
                guna2ContextMenuStrip1.Enabled = false;
                return;

            }

            clsInvoice Invoice = clsInvoice.FindByRepairOrderID(_RepairOrderID.Value);

            if(Invoice == null)
            {
                guna2ContextMenuStrip1.Enabled = false;
                return;
            } 
            guna2ContextMenuStrip1.Enabled =
                dgvAllPayments.CurrentRow != null &&
               Invoice.PaymentStatus !=
                clsInvoice.enPaymentStatus.Paid;
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnUpdateClick?.Invoke((int)dgvAllPayments.CurrentRow.Cells[0].Value);
        }

        private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this payment?", "Confirm",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
          == DialogResult.Cancel) return;

            int PaymentID = (int)dgvAllPayments.CurrentRow.Cells[0].Value;


            bool IsDeleted = DeletePayment?.Invoke(PaymentID) ?? false;

            if(IsDeleted)
                await RefreshPayments();

        }

       
    }
}

