using SCMS_Business_Logic;
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
    public partial class frmManageEmployees : Form
    {
        private int TotalPages = 1;
        private int CurrentPage = 1;
        private int NumberOfEmployeesEachPage = Convert.ToInt32(ConfigurationManager.AppSettings["NumberOfRowsEachPage"]);

        clsEmployee _CurrentEmployee;
        public frmManageEmployees()
        {
            InitializeComponent();
        }

        private async Task _LoadEmployeesDataAsync()
        {
            DataTable Data = await clsEmployee.GetEmployeesAsync(NumberOfEmployeesEachPage, CurrentPage);
            dgvData.DataSource = Data;
            lblPageNumber.Text = CurrentPage.ToString();

            if (dgvData.Rows.Count > 0)
            {
                dgvData.Columns[1].Width = 200;
                dgvData.Columns[4].Width = 170;
                dgvData.Columns[6].Width = 140;
            }
        }

        private async void frmManageEmployees_Load(object sender, EventArgs e)
        {
            btnPrevious.Enabled = false;
            CurrentPage = 1;

            TotalPages = await clsEmployee.GetEmployeesNumberOfPagesAsync(NumberOfEmployeesEachPage);
            lblTotalPages.Text = TotalPages.ToString();

            //this means that no employees exists 
            if (TotalPages == 0 || TotalPages == 1)
            {
                lblTotalPages.Text = "1";
                lblPageNumber.Text = "1";
                btnNext.Enabled = false;
            }
            else
                btnNext.Enabled = true;
            await _LoadEmployeesDataAsync();
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            if (++CurrentPage <= TotalPages)
            {
                btnPrevious.Enabled = true;

                await _LoadEmployeesDataAsync();

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

                await _LoadEmployeesDataAsync();


                if (CurrentPage == 1)
                    btnPrevious.Enabled = false;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditEmployee frm = new frmAddEditEmployee();
            frm.ShowDialog();

            frmManageEmployees_Load(null, null);
        }

        private void updateInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_CurrentEmployee == null) return;
            frmAddEditEmployee frm = new frmAddEditEmployee(_CurrentEmployee.EmployeeID);
            frm.ShowDialog();

            frmManageEmployees_Load(null, null);
        }

    

        private void showEmployeeInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_CurrentEmployee == null) return;

            frmShowEmployeeInfo frm = new frmShowEmployeeInfo(_CurrentEmployee.EmployeeID);

            frm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearchForAnEmployee frm = new frmSearchForAnEmployee();
           
            frm.ShowDialog();
        }

        private void userAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_CurrentEmployee == null) return;

            frmShowEmployeeUserAcounts frm =
                new frmShowEmployeeUserAcounts(_CurrentEmployee.EmployeeID);

            frm.ShowDialog();
        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgvData.CurrentRow == null)
            {
                guna2ContextMenuStrip1.Enabled = false;
                return;
            }

            guna2ContextMenuStrip1.Enabled = true;



            deactivateToolStripMenuItem.Text =
                (bool)dgvData.CurrentRow.Cells["IsActive"].Value ?
                "Deactivate" : "Activate";

            int EmployeeID = (int)dgvData.CurrentRow.Cells[0].Value;

            userAccountsToolStripMenuItem.Enabled = clsUser.IsEmployeeAlreadyAUser(EmployeeID);


            _CurrentEmployee = clsEmployee.FindEmployee(EmployeeID);

            addAsCustomerToolStripMenuItem.Enabled = !_CurrentEmployee.IsAlreadyCustomer();


          
        }

        private void deactivateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_CurrentEmployee == null) return;

           

            if (MessageBox.Show($"Are you sure you want to {deactivateToolStripMenuItem.Text}" +
                $" employee with id = {_CurrentEmployee.EmployeeID} ?", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return;



            if (_CurrentEmployee.IsActive)
            {

                if (_CurrentEmployee.Deactivate())
                {
                    MessageBox.Show("Employee deactivated successfully", "", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    frmManageEmployees_Load(null, null);
                    return;
                }


            }
            else
            {
                if (_CurrentEmployee.Activate())
                {
                    MessageBox.Show("Employee activated successfully", "", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    frmManageEmployees_Load(null, null);
                    return;
                }
            }

            MessageBox.Show("An Error occured", "", MessageBoxButtons.OK,
                      MessageBoxIcon.Error);

        }

        private void addAsCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_CurrentEmployee == null) return;


            frmAddEditCustomer frm = new frmAddEditCustomer(_CurrentEmployee.EmployeeID, true);

            frm.ShowDialog();
        }
    }
}
