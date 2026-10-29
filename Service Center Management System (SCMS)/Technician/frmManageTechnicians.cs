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
    public partial class frmManageTechnicians : Form
    {
        private int TotalPages = 1;
        private int CurrentPage = 1;
        private int NumberOfTechniciansEachPage = Convert.ToInt32(ConfigurationManager.AppSettings["NumberOfRowsEachPage"]);


        clsTechnician _CurrentTechnician;
        public frmManageTechnicians()
        {
            InitializeComponent();
        }
        private async Task _LoadTechnicianssDataAsync()
        {
            DataTable Data = await clsTechnician.GetTechniciansAsync(NumberOfTechniciansEachPage, CurrentPage);
            dgvData.DataSource = Data;
            lblPageNumber.Text = CurrentPage.ToString();

            if (dgvData.Rows.Count > 0)
            {
                dgvData.Columns[2].Width = 200;
                dgvData.Columns[5].Width = 170;
                dgvData.Columns[6].Width = 170;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearchForATechnician frm = new frmSearchForATechnician();

            frm.ShowDialog();
        }

        private async void frmManageTechnicians_Load(object sender, EventArgs e)
        {
            btnPrevious.Enabled = false;
            CurrentPage = 1;

            TotalPages = await clsTechnician.GetTechniciansNumberOfPagesAsync(NumberOfTechniciansEachPage);
            lblTotalPages.Text = TotalPages.ToString();


            if (TotalPages == 0 || TotalPages == 1)
            {
                lblTotalPages.Text = "1";
                lblPageNumber.Text = "1";
                btnNext.Enabled = false;
            }
            else
                btnNext.Enabled = true;
           await _LoadTechnicianssDataAsync();
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            if (++CurrentPage <= TotalPages)
            {
                btnPrevious.Enabled = true;

                await _LoadTechnicianssDataAsync();

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

                await _LoadTechnicianssDataAsync();


                if (CurrentPage == 1)
                    btnPrevious.Enabled = false;
            }
        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgvData.CurrentRow == null)
            {
                guna2ContextMenuStrip1.Enabled =false;
                return;
            }

            guna2ContextMenuStrip1.Enabled = true ;

            _CurrentTechnician =
                clsTechnician.FindTechnician((int)dgvData.CurrentRow.Cells[0].Value);

            deactivateToolStripMenuItem.Text =_CurrentTechnician.EmployeeInfo.IsActive ? "Deactivate" :
                "Activate";
        }

        private void deleteInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TechnicianID = (int)dgvData.CurrentRow.Cells[0].Value;

            if (MessageBox.Show($"Are you sure you want to delete technician info with id= " +
                $"{TechnicianID} ?", "About to be deleted", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.Cancel) return;

            if (clsTechnician.DeleteTechnician(TechnicianID))
            {
                MessageBox.Show("Technician deleted successfully", "Done", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                frmManageTechnicians_Load(null, null);
            }
            else
            {
                MessageBox.Show("This technician has related records and cannot be deleted.",
                    "", MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditTechnician frm = new frmAddEditTechnician();
            frm.ShowDialog();

            frmManageTechnicians_Load(null, null);
        }

        private void updateInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditTechnician frm = new frmAddEditTechnician((int)dgvData.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            frmManageTechnicians_Load(null, null);
        }

        private void showTechnicianInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowTechnicianInfo frm = new frmShowTechnicianInfo((int)dgvData.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void showAllAssignedRepairsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_CurrentTechnician == null) return;

            if(!_CurrentTechnician.HasAssignedRepairs)
            {
                MessageBox.Show("This technician has no assigned repair orders.",
                   "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            frmShowAssignedRepairsForTechnician frm =
                new frmShowAssignedRepairsForTechnician((int)dgvData.CurrentRow.Cells[0].Value);

            frm.ShowDialog();
        }

        private void showCompletedRepairsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_CurrentTechnician == null) return;

            if (!_CurrentTechnician.HasCompletedRepairs)
            {
                MessageBox.Show("This technician has no completed repair orders.",
                   "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            frmShowCompletedRepairsForTechnician frm =
                new frmShowCompletedRepairsForTechnician((int)dgvData.CurrentRow.Cells[0].Value);

            frm.ShowDialog();
        }

        private void showCurrentWorkloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_CurrentTechnician == null) return;

            if (!_CurrentTechnician.HasCurrentWorkloadRepairs)
            {
                MessageBox.Show("This technician has no current workload repair orders.",
                   "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            frmShowCurrentWorkloadForTechnician frm =
                new frmShowCurrentWorkloadForTechnician((int)dgvData.CurrentRow.Cells[0].Value);

            frm.ShowDialog();
        }

        private void deactivateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_CurrentTechnician == null) return;

            if (MessageBox.Show($"Are you sure you want to {deactivateToolStripMenuItem.Text}" +
                $" Technician with id = {_CurrentTechnician.TechnicianID} ?", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return;



            if (_CurrentTechnician.EmployeeInfo.IsActive)
            {

                if (_CurrentTechnician.Deactivate())
                {
                    MessageBox.Show("Technician deactivated successfully", "", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    frmManageTechnicians_Load(null, null);
                    return;
                }


            }
            else
            {
                if (_CurrentTechnician.Activate())
                {
                    MessageBox.Show("Technician activated successfully", "", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    frmManageTechnicians_Load(null, null);
                    return;
                }
            }

            MessageBox.Show("An Error occured", "", MessageBoxButtons.OK,
                      MessageBoxIcon.Error);

        }

    }
}
