using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCMS_Business_Logic;
using System.Configuration;

namespace Service_Center_Management_System__SCMS_
{
    public partial class frmManageDeviceTypes : Form
    {
        private int TotalPages = 1;
        private int CurrentPage = 1;
        private int NumberOfRowsEachPage = Convert.ToInt32(ConfigurationManager.AppSettings["NumberOfRowsEachPage"]);
        public frmManageDeviceTypes()
        {
            InitializeComponent();
        }

        private async Task _LoadDeviceTypesDataAsync()
        {
            DataTable Data = await clsDeviceType.GetDeviceTypesAsync(NumberOfRowsEachPage, CurrentPage);
            dgvData.DataSource = Data;
            lblPageNumber.Text = CurrentPage.ToString();

            if (dgvData.Rows.Count > 0)
            {
                dgvData.Columns[0].Width = 150;
                dgvData.Columns[1].Width = 250;
             
            }
        }

        private async void frmManageDeviceTypes_Load(object sender, EventArgs e)
        {

            btnPrevious.Enabled = false;
            CurrentPage = 1;

            TotalPages = await clsDeviceType.GetDeviceTypesNumberOfPagesAsync(NumberOfRowsEachPage);
            lblTotalPages.Text = TotalPages.ToString();


            if (TotalPages == 0 || TotalPages == 1)
            {
                lblTotalPages.Text = "1";
                lblPageNumber.Text = "1";
                btnNext.Enabled = false;
            }
            else
                btnNext.Enabled = true;
           await _LoadDeviceTypesDataAsync();
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            if (++CurrentPage <= TotalPages)
            {
                btnPrevious.Enabled = true;

                await _LoadDeviceTypesDataAsync();

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

                await _LoadDeviceTypesDataAsync();


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
            int DeviceTypeID = (int)dgvData.CurrentRow.Cells[0].Value;

            if (MessageBox.Show($"Are you sure you want to delete device type info with id= " +
                $"{DeviceTypeID} ?", "About to be deleted", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.Cancel) return;

            if (clsDeviceType.DeleteDeviceType(DeviceTypeID))
            {
                MessageBox.Show("Device type deleted successfully", "Done", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                frmManageDeviceTypes_Load(null, null);
            }
            else
            {
                MessageBox.Show("This device type has related records and cannot be deleted.",
                    "", MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditDeviceType frm = new frmAddEditDeviceType();

            frm.ShowDialog();

            frmManageDeviceTypes_Load(null, null);
        }

        private void updateInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditDeviceType frm = new frmAddEditDeviceType((int)dgvData.CurrentRow.Cells[0].Value);

            frm.ShowDialog();

            frmManageDeviceTypes_Load(null, null);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearchForADeviceType frm = new frmSearchForADeviceType();
            frm.ShowDialog();
        }
    }
}
