using SCMS_Business_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Service_Center_Management_System__SCMS_
{
    public partial class frmManageBands : Form
    {
        private int TotalPages = 1;
        private int CurrentPage = 1;
        private int NumberOfRowsEachPage = Convert.ToInt32(ConfigurationManager.AppSettings["NumberOfRowsEachPage"]);

        public frmManageBands()
        {
            InitializeComponent();
        }

        private async Task _LoadBrandsDataAsync()
        {
            DataTable Data = await clsBrand.GetBrandsAsync(NumberOfRowsEachPage, CurrentPage);
            dgvData.DataSource = Data;
            lblPageNumber.Text = CurrentPage.ToString();

            if (dgvData.Rows.Count > 0)
            {
                dgvData.Columns[0].Width = 150;
                dgvData.Columns[1].Width = 250;

            }
        }

        private async void frmManageBands_Load(object sender, EventArgs e)
        {

            btnPrevious.Enabled = false;
            CurrentPage = 1;

            TotalPages = await clsBrand.GetBrandsNumberOfPagesAsync(NumberOfRowsEachPage);
            lblTotalPages.Text = TotalPages.ToString();


            if (TotalPages == 0 || TotalPages == 1)
            {
                lblTotalPages.Text = "1";
                lblPageNumber.Text = "1";
                btnNext.Enabled = false;
            }
            else
                btnNext.Enabled = true;
            await _LoadBrandsDataAsync();
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            if (++CurrentPage <= TotalPages)
            {
                btnPrevious.Enabled = true;

                await _LoadBrandsDataAsync();

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

                await _LoadBrandsDataAsync();


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
            int BrandID = (int)dgvData.CurrentRow.Cells[0].Value;

            if (MessageBox.Show($"Are you sure you want to delete Brand info with id= " +
                $"{BrandID} ?", "About to be deleted", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.Cancel) return;

            if (clsBrand.DeleteBrand(BrandID))
            {
                MessageBox.Show("Brand deleted successfully", "Done", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                frmManageBands_Load(null, null);
            }
            else
            {
                MessageBox.Show("This Brand has related records and cannot be deleted.",
                    "", MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditBrand frm = new frmAddEditBrand();
            frm.ShowDialog();
            frmManageBands_Load(null, null);
        }

        private void updateInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditBrand frm = new frmAddEditBrand((int)dgvData.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmManageBands_Load(null, null);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearchForaBrand frm = new frmSearchForaBrand();

            frm.ShowDialog();
        }

        private void showBrandsModelsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int BrandID = (int)dgvData.CurrentRow.Cells[0].Value;

            clsBrand BrandInfo = clsBrand.FindBrand(BrandID);
         

            if(!BrandInfo.HasModels)
            {
                MessageBox.Show("This brand has no models.", "No Models Found",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            frmShowAllModelsForBrand frm = 
                new frmShowAllModelsForBrand(BrandID);

            frm.ShowDialog();
        }
    }
}
