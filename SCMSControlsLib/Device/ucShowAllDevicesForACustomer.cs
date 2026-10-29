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
    public partial class ucShowAllDevicesForACustomer : UserControl
    {
        public Action<int> ShowDeviceInfo;

        DataTable _AllDevices;
        public ucShowAllDevicesForACustomer()
        {
            InitializeComponent();
        }

        public async Task LoadAllDevicesByCustomerID(int CustomerID)
        {
            if(!clsCustomer.IsCustomerExists(CustomerID))
            {
                MessageBox.Show("Customer Not found !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            gbAllDevices.Text = $"All Devices For Customer ID = {CustomerID}";

            _AllDevices = await clsDevice.GetDevicesForCustomer(CustomerID);
            dgvAllDevices.DataSource = _AllDevices;
            lblNumberOfDevices.Text = _AllDevices.Rows.Count.ToString();

            if (dgvAllDevices.Rows.Count > 0)
            {
                dgvAllDevices.Columns[2].Width = 250;
                dgvAllDevices.Columns[3].Width = 200;
                dgvAllDevices.Columns[4].Width = 200;
                dgvAllDevices.Columns[5].Width = 200;
               
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            contextMenuStrip1.Enabled = dgvAllDevices.CurrentRow != null;
        }

        private void showDeviceInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDeviceInfo?.Invoke((int)dgvAllDevices.CurrentRow.Cells[0].Value);
        }
    }
}
