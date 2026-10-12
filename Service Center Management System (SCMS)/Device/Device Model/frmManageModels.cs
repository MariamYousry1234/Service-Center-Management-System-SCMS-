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
    public partial class frmManageModels : Form
    {
        private int TotalPages = 1;
        private int CurrentPage = 1;
        private int NumberOfRowsEachPage = Convert.ToInt32(ConfigurationManager.AppSettings["NumberOfRowsEachPage"]);

        public frmManageModels()
        {
            InitializeComponent();
        }

        private async Task _LoadModelsDataAsync()
        {
            DataTable Data = await clsModel.GetModelsAsync(NumberOfRowsEachPage, CurrentPage);
            dgvData.DataSource = Data;
            lblPageNumber.Text = CurrentPage.ToString();

            if (dgvData.Rows.Count > 0)
            {
                dgvData.Columns[2].Width = 150;
                dgvData.Columns[3].Width = 150;
            }
        }

        private async void frmManageModels_Load(object sender, EventArgs e)
        {
            btnPrevious.Enabled = false;
            CurrentPage = 1;

            TotalPages = await clsModel.GetModelsNumberOfPagesAsync(NumberOfRowsEachPage);
            lblTotalPages.Text = TotalPages.ToString();


            if (TotalPages == 0 || TotalPages == 1)
            {
                lblTotalPages.Text = "1";
                lblPageNumber.Text = "1";
                btnNext.Enabled = false;
            }
            else
                btnNext.Enabled = true;
            await _LoadModelsDataAsync();
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            if (++CurrentPage <= TotalPages)
            {
                btnPrevious.Enabled = true;

                await _LoadModelsDataAsync();

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

                await _LoadModelsDataAsync();


                if (CurrentPage == 1)
                    btnPrevious.Enabled = false;
            }
        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            guna2ContextMenuStrip1.Enabled = dgvData.CurrentRow != null;
        }

        private void deleteInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ModelID = (int)dgvData.CurrentRow.Cells[0].Value;

            if (MessageBox.Show($"Are you sure you want to delete Model info with id= " +
                $"{ModelID} ?", "About to be deleted", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.Cancel) return;

            if (clsModel.DeleteModel(ModelID))
            {
                MessageBox.Show("Model deleted successfully", "Done", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                frmManageModels_Load(null, null);
            }
            else
            {
                MessageBox.Show("This Model has related records and cannot be deleted.",
                    "", MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditModel frm = new frmAddEditModel();
            frm.ShowDialog();

            frmManageModels_Load(null, null);
        }

        private void updateInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditModel frm = new frmAddEditModel((int)dgvData.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            frmManageModels_Load(null, null);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearchForAModel frm = new frmSearchForAModel();
            frm.ShowDialog();
        }
    }
}
