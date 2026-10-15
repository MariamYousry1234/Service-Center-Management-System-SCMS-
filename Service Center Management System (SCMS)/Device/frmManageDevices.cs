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
    public partial class frmManageDevices : Form
    {
        private int TotalPages = 1;
        private int CurrentPage = 1;
        private int NumberOfRowsEachPage = Convert.ToInt32(ConfigurationManager.AppSettings["NumberOfRowsEachPage"]);

        public frmManageDevices()
        {
            InitializeComponent();
        }
        private async Task _LoadDevicesDataAsync()
        {
            DataTable Data = await clsDevice.GetDevicesAsync(NumberOfRowsEachPage, CurrentPage);
            dgvData.DataSource = Data;
            lblPageNumber.Text = CurrentPage.ToString();

            if (dgvData.Rows.Count > 0)
            {
                dgvData.Columns[2].Width = 200;
                dgvData.Columns[3].Width = 150;
                dgvData.Columns[4].Width = 150;
                dgvData.Columns[5].Width = 150;
                dgvData.Columns[6].Width = 150;
            }
        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            guna2ContextMenuStrip1.Enabled = dgvData.CurrentRow != null;
        }

        private async void frmManageDevices_Load(object sender, EventArgs e)
        {
            btnPrevious.Enabled = false;
            CurrentPage = 1;

            TotalPages = await clsDevice.GetDevicesNumberOfPagesAsync(NumberOfRowsEachPage);
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
            await _LoadDevicesDataAsync();
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            if (++CurrentPage <= TotalPages)
            {
                btnPrevious.Enabled = true;

                await _LoadDevicesDataAsync();

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

                await _LoadDevicesDataAsync();


                if (CurrentPage == 1)
                    btnPrevious.Enabled = false;
            }
        }

        private void deleteInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int DeviceID = (int)dgvData.CurrentRow.Cells[0].Value;

            if (MessageBox.Show($"Are you sure you want to delete device info with id= " +
                $"{DeviceID} ?", "About to be deleted", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.Cancel) return;

            if (clsDevice.DeleteDevice(DeviceID))
            {
                MessageBox.Show("Device deleted successfully", "Done", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                frmManageDevices_Load(null, null);
            }
            else
            {
                MessageBox.Show("This device has related records and cannot be deleted.",
                    "", MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
            }


        }

        private void showDeviceDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowDeviceDetails frm = new frmShowDeviceDetails((int)dgvData.CurrentRow.Cells[0].Value);

            frm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearchForADevice frm = new frmSearchForADevice();

            frm.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditDevice frm = new frmAddEditDevice();

            frm.ShowDialog();

            frmManageDevices_Load(null, null);
        }

        private void updateInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditDevice frm = new frmAddEditDevice((int)dgvData.CurrentRow.Cells[0].Value);

            frm.ShowDialog();

            frmManageDevices_Load(null, null);
        }

        private void showRepairOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewRepairOrdersForDevice frm =
                new frmViewRepairOrdersForDevice((int)dgvData.CurrentRow.Cells[0].Value);

            frm.ShowDialog();
        }
    }
}
