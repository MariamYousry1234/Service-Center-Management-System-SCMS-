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

namespace Service_Center_Management_System__SCMS_
{
    public partial class frmManagePartBrands : Form
    {
        DataTable _AllData;
        public frmManagePartBrands()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmManagePartBrands_Load(object sender, EventArgs e)
        {
            _AllData = await clsPartBrand.GetPartBrandsAsync();
            dgvData.DataSource = _AllData;

            lblNumberOfBrands.Text = dgvData.Rows.Count.ToString();


            if (dgvData.Rows.Count > 0)
            {
                dgvData.Columns[1].Width = 250;             
            }

            txtSearch.Clear();
            txtSearch.Focus();
        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            guna2ContextMenuStrip1.Enabled = dgvData.CurrentRow != null;

        }

        private void updateInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditPartBrand frm =
                new frmAddEditPartBrand((int)dgvData.CurrentRow.Cells[0].Value);

            frm.ShowDialog();

            frmManagePartBrands_Load(null, null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditPartBrand frm =
                new frmAddEditPartBrand();

            frm.ShowDialog();

            frmManagePartBrands_Load(null, null);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _AllData.DefaultView.RowFilter = $"PartBrandName like '%{txtSearch.Text}%'";

            lblNumberOfBrands.Text = dgvData.Rows.Count.ToString();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int BrandID = (int)dgvData.CurrentRow.Cells[0].Value;

            if (MessageBox.Show($"Are you sure you want to delete part brand with id = {BrandID} ?",
                  "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) 
                == DialogResult.Cancel)
                return;

            if(clsPartBrand.DeletePartBrand(BrandID))
            {
                MessageBox.Show(
                   $"Part Brand with ID = {BrandID} was deleted successfully.",
                   "Success",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);

                frmManagePartBrands_Load(null, null);
            }
            else
            {
                MessageBox.Show(
            "Unable to delete this Part Brand. It may be used by existing Spare Parts.",
              "Delete Failed",
              MessageBoxButtons.OK,
           MessageBoxIcon.Error);
            }
        }
    }
}
