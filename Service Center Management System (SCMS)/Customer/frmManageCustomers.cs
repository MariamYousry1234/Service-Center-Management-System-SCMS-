using SCMS_Business_Logic;
using SharedLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service_Center_Management_System__SCMS_
{
    public partial class frmManageCustomers : Form
    {
        private int TotalPages = 1;
        private int CurrentPage = 1;
        private int NumberOfCustomersEachPage =Convert.ToInt32(ConfigurationManager.AppSettings["NumberOfRowsEachPage"]);

        private string ApplicationName = ConfigurationManager.AppSettings["ApplicationName"];

        clsCustomer _CurrentCustomer;
        
        public frmManageCustomers()
        {
            InitializeComponent();
        }


        private async Task _LoadCustomerssDataAsync()
        {
            DataTable Data = await clsCustomer.GetCustomersAsync(NumberOfCustomersEachPage, CurrentPage);
            dgvData.DataSource = Data;
            lblPageNumber.Text = CurrentPage.ToString();

            if (dgvData.Rows.Count > 0)
            {
                dgvData.Columns[2].Width = 200;
                dgvData.Columns["Email"].Width = 170;

                dgvData.Columns["Created Date"].Width = 170;
            }
        }

        private async void frmManageCustomers_Load(object sender, EventArgs e)
        {
            btnPrevious.Enabled = false;
            CurrentPage = 1;

            TotalPages = await clsCustomer.GetCustomersNumberOfPagesAsync(NumberOfCustomersEachPage);
            lblTotalPages.Text = TotalPages.ToString();


            if (TotalPages == 0 || TotalPages == 1)
            {
                lblTotalPages.Text = "1";
                lblPageNumber.Text = "1";
                btnNext.Enabled = false;
            }
            else
                btnNext.Enabled = true;
            await _LoadCustomerssDataAsync();
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            if (++CurrentPage <= TotalPages)
            {
                btnPrevious.Enabled = true;

                await _LoadCustomerssDataAsync();

                //Is last page?
                if (CurrentPage == TotalPages)
                    btnNext.Enabled = false;
            }
        }

        private async void btnPrevious_Click(object sender, EventArgs e)
        {
            if (--CurrentPage >= 1)
            {
                btnNext.Enabled = true;

                await _LoadCustomerssDataAsync();


                if (CurrentPage == 1)
                    btnPrevious.Enabled = false;
            }

        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(dgvData.CurrentRow == null)
            {
                guna2ContextMenuStrip1.Enabled = false;
                _CurrentCustomer = null;
                return;
            }

            guna2ContextMenuStrip1.Enabled = true ;

      
            _CurrentCustomer = 
                clsCustomer.FindCustomer((int)dgvData.CurrentRow.Cells[0].Value);

            addAsEmployeeToolStripMenuItem.Enabled = !_CurrentCustomer.IsAlreadyEmployee();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditCustomer frm = new frmAddEditCustomer();
            frm.ShowDialog();

            frmManageCustomers_Load(null, null);
        }

        private void showCustomerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_CurrentCustomer == null) return;
            frmShowCustomerInfo frm = new frmShowCustomerInfo(_CurrentCustomer.CustomerID);

            frm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearchForACustomer frm = new frmSearchForACustomer();

            frm.ShowDialog();
        }

        private void updateInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_CurrentCustomer == null) return;
            frmAddEditCustomer frm = new frmAddEditCustomer(_CurrentCustomer.CustomerID);
            frm.ShowDialog();

            frmManageCustomers_Load(null, null);
        }

        private void ViewCustomerDevicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_CurrentCustomer == null) return;

            if (!_CurrentCustomer.HasDevices)
            {
                MessageBox.Show("This customer has no devices.",
                    "Not Allowed",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            frmShowAllDevicesForACustomer frm = new frmShowAllDevicesForACustomer(_CurrentCustomer.CustomerID);

            frm.ShowDialog();
        }

        private void viewCustomersRepairOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_CurrentCustomer == null) return;

            if(!_CurrentCustomer.HasRepairOrders)
            {
                MessageBox.Show("This customer has no repair orders.",
                    "Not Allowed",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            frmShowCustomerRepairOrders frm = new frmShowCustomerRepairOrders(_CurrentCustomer.CustomerID);

            frm.ShowDialog();
        }


        private void addAsEmployeeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (_CurrentCustomer == null) return;

            frmAddEditEmployee frm = new frmAddEditEmployee(_CurrentCustomer.CustomerID, true);

            frm.ShowDialog();
        }

        private void deleteCustomerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int CustomerID = (int)dgvData.CurrentRow.Cells[0].Value;

            if (MessageBox.Show($"Are you sure you want to delete customer info with id= " +
                $"{CustomerID} ?", "About to be deleted", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.Cancel) return;

            if (clsCustomer.DeleteCustomer(CustomerID))
            {
                MessageBox.Show("Customer deleted successfully", "Done", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);


                clsEventLogger.WriteEntryToEventLog(
                ApplicationName,
                  $"User with username = {clsGlobal.CurrentUser.Username} deleted Customer with ID = {CustomerID} successfully",
               System.Diagnostics.EventLogEntryType.Information);


                frmManageCustomers_Load(null, null);
            }
            else
            {
                MessageBox.Show("This customer has related records and cannot be deleted.",
                    "", MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
            }
        }

        private void viewCustomersPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!_CurrentCustomer.HasPayments)
            {
                MessageBox.Show(
                      "This customer has no payments.",
                      "No Payments",
                       MessageBoxButtons.OK,
                          MessageBoxIcon.Warning);

                return;
            }

            frmShowAllPaymentsForCustomer frm = 
                new frmShowAllPaymentsForCustomer(_CurrentCustomer.CustomerID);

            frm.ShowDialog();

        }
    }
}
