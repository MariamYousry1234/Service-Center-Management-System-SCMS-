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
    public partial class frmManageUsers : Form
    {
        private int TotalPages = 1;
        private int CurrentPage = 1;
        private int NumberOfUsersEachPage = Convert.ToInt32(ConfigurationManager.AppSettings["NumberOfRowsEachPage"]);

        public frmManageUsers()
        {
            InitializeComponent();
        }

        private async Task _LoadUsersDataAsync()
        {
            DataTable Data = await clsUser.GetUsersAsync(NumberOfUsersEachPage, CurrentPage);
            dgvData.DataSource = Data;
            lblPageNumber.Text = CurrentPage.ToString();

            if (dgvData.Rows.Count > 0)
            {
                dgvData.Columns[2].Width = 200;
                dgvData.Columns[4].Width = 170;
            }
               
                    
        }

        private async void frmManageUsers_Load(object sender, EventArgs e)
        {
            btnPrevious.Enabled = false;
            CurrentPage = 1;

            TotalPages = await clsUser.GetUsersNumberOfPagesAsync(NumberOfUsersEachPage);
            lblTotalPages.Text = TotalPages.ToString();

            if (TotalPages == 0) return;

            //this means that no employees exists 
            if (TotalPages > 1)
            {
                btnNext.Enabled = true;
            }
            else
                btnNext.Enabled = false;

           await _LoadUsersDataAsync();
    
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            if (++CurrentPage <= TotalPages)
            {
                btnPrevious.Enabled = true;

                await _LoadUsersDataAsync();

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

                await _LoadUsersDataAsync();


                if (CurrentPage == 1)
                    btnPrevious.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser();
            frm.ShowDialog();


            frmManageUsers_Load(null, null);

        }

        private void updateInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
         

            frmAddEditUser frm = new frmAddEditUser((int)dgvData.CurrentRow.Cells[0].Value);

            frm.ShowDialog();

            frmManageUsers_Load(null, null);
        }

        private void showEmployeeInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
      

            frmShowUserInfo frm = new frmShowUserInfo((int)dgvData.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

  

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearchForAUser frm = new frmSearchForAUser();
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

            deactivateToolStripMenuItem.Enabled =
               (int)dgvData.CurrentRow.Cells[0].Value != 3;
        }

        private void deactivateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvData.CurrentRow.Cells[0].Value;

            if (UserID==3)
            {
                MessageBox.Show("Can not change activation for Adiminstrator", "Not allow",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (MessageBox.Show($"Are you sure you want to {deactivateToolStripMenuItem.Text}" +
                $" user with id = {UserID} ?", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return;


            clsUser CurrentUser = clsUser.FindUser(UserID);


            if (CurrentUser.IsActive)
            {

                if (CurrentUser.Deactivate())
                {
                    MessageBox.Show("User deactivated successfully", "", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    frmManageUsers_Load(null, null);
                    return;
                }


            }
            else
            {
                if (CurrentUser.Activate())
                {
                    MessageBox.Show("User activated successfully", "", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    frmManageUsers_Load(null, null);
                    return;
                }
            }

            MessageBox.Show("An Error occured", "", MessageBoxButtons.OK,
                      MessageBoxIcon.Error);

        }
    }
}

