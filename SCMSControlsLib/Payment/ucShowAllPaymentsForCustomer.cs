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
    public partial class ucShowAllPaymentsForCustomer : UserControl
    {

        public Action<int> ShowRepairOrderDetials;
        public Action<int> ShowInvoiceDetials;
        public Action<int> ShowCreatedUserInfo;


        clsCustomer _Customer;
        DataTable _AllPayments;
        public ucShowAllPaymentsForCustomer()
        {
            InitializeComponent();
        }

        public async Task LoadPaymentForCustomer(int CustomerID)
        {
            _Customer = clsCustomer.FindCustomer(CustomerID);

            if(_Customer == null)
            {

                MessageBox.Show(
                    "Customer not found.",
                     "Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                gbAllPayments.Text = "All Payments For Customer ID = [???]";
                cbFiltering.Enabled = false;
                txtFiltering.Enabled = false;
                return;
            }
          
            gbAllPayments.Text = $"All Payments For Customer ID = {_Customer.CustomerID}";

            _AllPayments= await _Customer.GetAllPayments();
            dgvAllPayments.DataSource = _AllPayments;

            lblNumberOfRepairOrders.Text = dgvAllPayments.Rows.Count.ToString();
            cbFiltering.Enabled = true;
            cbFiltering.SelectedIndex = 0;
            txtFiltering.Enabled = false;
        }

        private void showRepairOrderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRepairOrderDetials?.Invoke((int)dgvAllPayments.CurrentRow.Cells[2].Value);
        }

        private void showInvoiceDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
            ShowInvoiceDetials?.Invoke((int)dgvAllPayments.CurrentRow.Cells[1].Value);
        }

        private void showCreatedUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
            ShowCreatedUserInfo?.Invoke((int)dgvAllPayments.CurrentRow.Cells[6].Value);

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            contextMenuStrip1.Enabled = dgvAllPayments.CurrentRow != null ;
        }

        private void cbFiltering_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltering.Clear();

            if(cbFiltering.SelectedIndex == 0)
            {
                txtFiltering.Enabled = false;
            }
            else
            {
                txtFiltering.Enabled = true;
                txtFiltering.Focus();
            }

        }

        private void txtFiltering_TextChanged(object sender, EventArgs e)
        {
            if(cbFiltering.Text == "None" || string.IsNullOrEmpty(txtFiltering.Text))
                _AllPayments.DefaultView.RowFilter = "";
            else
                _AllPayments.DefaultView.RowFilter = $"{cbFiltering.Text} = {txtFiltering.Text}";

            lblNumberOfRepairOrders.Text = dgvAllPayments.Rows.Count.ToString();
        }
    }
}
