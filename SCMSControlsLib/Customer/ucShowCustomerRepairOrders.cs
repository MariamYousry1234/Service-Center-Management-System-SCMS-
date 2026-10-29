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
    public partial class ucShowCustomerRepairOrders : UserControl
    {
        public Action<int> ShowRepairOrderDetails; 

        clsCustomer _Customer;
        int? _CustomerID = null;
        public ucShowCustomerRepairOrders()
        {
            InitializeComponent();
        }


        private async  Task _LoadCustomerRepairOrders()
        {
            dgvAllRepairOrders.DataSource = await _Customer.GetAllRepairOrdersAsync();

            lblTotalRepairOrders.Text = dgvAllRepairOrders.Rows.Count.ToString();

            if (dgvAllRepairOrders.Rows.Count > 0)
            {
                dgvAllRepairOrders.Columns[1].Width = 250;
                dgvAllRepairOrders.Columns[2].Width = 250;
                dgvAllRepairOrders.Columns[3].Width = 150;
                dgvAllRepairOrders.Columns[4].Width = 100;
                dgvAllRepairOrders.Columns[5].Width = 180;
                dgvAllRepairOrders.Columns[6].Width = 200;
            }
        }
        public async Task LoadCustomerRepairOrders(int CustomerID)
        {
            _Customer = clsCustomer.FindCustomer(CustomerID);

            if(_Customer==null)
            {
                MessageBox.Show($"Customer with id = {CustomerID} Not found!","",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                _CustomerID = null;
                return;
            }

            _CustomerID = _Customer.CustomerID;
            await _LoadCustomerRepairOrders();

            gbAllRepairOrders.Text = $"All Repair Orders For Customer ID = {_CustomerID}";
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRepairOrderDetails?.Invoke((int)dgvAllRepairOrders.CurrentRow.Cells[0].Value);
        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            guna2ContextMenuStrip1.Enabled = dgvAllRepairOrders.CurrentRow != null;
        }
    }
}
