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
    public partial class frmManageSuppliers : Form
    {
        public frmManageSuppliers()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmManageSuppliers_Load(object sender, EventArgs e)
        {
            dgvData.DataSource = await clsSupplier.GetSuppliersAsync();

            lblNumberOfSuppliers.Text = dgvData.Rows.Count.ToString();


            if (dgvData.Rows.Count>0)
            {
                dgvData.Columns[1].Width = 200;
                dgvData.Columns[2].Width = 150;
                dgvData.Columns[3].Width =250;
           
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditSupplier frm = new frmAddEditSupplier();

            frm.ShowDialog();

            frmManageSuppliers_Load(null, null);
        }

        private void updateInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditSupplier frm = new frmAddEditSupplier((int)dgvData.CurrentRow.Cells[0].Value);

            frm.ShowDialog();

            frmManageSuppliers_Load(null, null);
        }

        private void decativateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to {decativateToolStripMenuItem.Text} this supplier",
                 "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.Cancel) return;

            clsSupplier CurrentSupplier =
                clsSupplier.FindSupplier((int)dgvData.CurrentRow.Cells[0].Value);

            if (CurrentSupplier.IsActive)
            {
                if (CurrentSupplier.Deactivate())
                {
                    MessageBox.Show("Supplier deactivated successfully", "", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    frmManageSuppliers_Load(null, null);
                    return;
                }

            }
            else
            {
                if (CurrentSupplier.Activate())
                {
                    MessageBox.Show("Supplier activated successfully", "", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    frmManageSuppliers_Load(null, null);
                    return;
                }
            }

            MessageBox.Show("An Error occured", "", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgvData.CurrentRow == null)
            {
                guna2ContextMenuStrip1.Enabled = false;
                return;
            }

            guna2ContextMenuStrip1.Enabled =true;

            decativateToolStripMenuItem.Text =
                (bool)dgvData.CurrentRow.Cells["IsActive"].Value ? "Deactivate" : "Activate";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearchForSupplier frm = new frmSearchForSupplier();

            frm.ShowDialog();
        }
    }
}
