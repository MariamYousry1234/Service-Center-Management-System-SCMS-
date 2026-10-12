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
    public partial class frmManagePartCategories : Form
    {
        DataTable _AllData;
        public frmManagePartCategories()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmManagePartCategories_Load(object sender, EventArgs e)
        {
            _AllData= await clsPartCategory.GetPartCategoriesAsync(); 
            dgvData.DataSource = _AllData;

            lblNumberOfCategories.Text = dgvData.Rows.Count.ToString();


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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditPartCategories frm = new frmAddEditPartCategories();

            frm.ShowDialog();

            frmManagePartCategories_Load(null, null);
        }

        private void updateInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditPartCategories frm = 
                new frmAddEditPartCategories((int)dgvData.CurrentRow.Cells[0].Value);

            frm.ShowDialog();

            frmManagePartCategories_Load(null, null);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _AllData.DefaultView.RowFilter = $"PartCategoryName like '%{txtSearch.Text}%'";

            lblNumberOfCategories.Text = dgvData.Rows.Count.ToString();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int CategoryID = (int)dgvData.CurrentRow.Cells[0].Value;

            if (MessageBox.Show($"Are you sure you want to delete part Category with id = {CategoryID} ?",
                  "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                == DialogResult.Cancel)
                return;

            if (clsPartCategory.DeletePartCategory(CategoryID))
            {
                MessageBox.Show(
                   $"Part Category with ID = {CategoryID} was deleted successfully.",
                   "Success",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);

                frmManagePartCategories_Load(null, null);
            }
            else
            {
                MessageBox.Show(
            "Unable to delete this Part Category. It may be used by existing Spare Parts.",
              "Delete Failed",
              MessageBoxButtons.OK,
              MessageBoxIcon.Error);
            }
        }
    }
}
