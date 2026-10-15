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

namespace SCMSControlsLib
{
    public partial class ucViewRepairOrdersForDevice : UserControl
    {
        public Action<int> ShowRepairOrderDetails;

        clsDevice _Device;
        int? _DeviceID;
        public ucViewRepairOrdersForDevice()
        {
            InitializeComponent();
        }

        private async Task _LoadRepairOrdersForDevice()
        {
            dgvAllRepairs.DataSource = await _Device.GetAllRepairOrdersForDeviceAsync();

            lblTotalRepairOrders.Text = dgvAllRepairs.Rows.Count.ToString();

            if (dgvAllRepairs.Rows.Count > 0)
            {
                dgvAllRepairs.Columns[1].Width = 200;
                dgvAllRepairs.Columns[2].Width = 200;
                dgvAllRepairs.Columns[3].Width = 150;
                dgvAllRepairs.Columns[4].Width = 100;
                dgvAllRepairs.Columns[5].Width = 150;
            }
        }
        public async Task LoadRepairOrdersForDevice(int DeviceID)
        {
            _Device = clsDevice.FindDevice(DeviceID);

            if (_Device == null)
            {
                MessageBox.Show($"Device with id = {DeviceID} Not found!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                _DeviceID = null;
                return;
            }

            _DeviceID = _Device.DeviceID;
            await _LoadRepairOrdersForDevice();

            gbAllRepairOrders.Text = $"All Repair Orders For Device ID = {_DeviceID}";
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            contextMenuStrip1.Enabled = dgvAllRepairs.CurrentRow != null;
        }

        private void showRepairOrderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRepairOrderDetails?.Invoke((int)dgvAllRepairs.CurrentRow.Cells[0].Value);
        }
    }
}
