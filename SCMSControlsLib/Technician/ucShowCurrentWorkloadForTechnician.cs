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
    public partial class ucShowCurrentWorkloadForTechnician : UserControl
    {
        public Action<int> ShowRepairDetails;

        clsTechnician _Technician;
        int? _TechnicianID;
        public ucShowCurrentWorkloadForTechnician()
        {
            InitializeComponent();
        }

        private async Task _LoadTechnicianCurrentWorkload()
        {
            dgvAllRepairs.DataSource = await _Technician.GetAllCurrentWorkloadOrdersAsync();

            lblTotalRepairs.Text = dgvAllRepairs.Rows.Count.ToString();

            if (dgvAllRepairs.Rows.Count > 0)
            {
                dgvAllRepairs.Columns[1].Width = 250;
                dgvAllRepairs.Columns[2].Width = 250;
                dgvAllRepairs.Columns[3].Width = 200;
                dgvAllRepairs.Columns[4].Width = 150;
                dgvAllRepairs.Columns[5].Width = 150;
                dgvAllRepairs.Columns[6].Width = 170;
            }
        }
        public async Task LoadTechnicianCurrentWorkload(int TechnicianID)
        {
            _Technician = clsTechnician.FindTechnician(TechnicianID);

            if (_Technician == null)
            {
                MessageBox.Show($"Technician with id = {TechnicianID} Not found!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                gbAllRepairOrders.Text = "All Current Workload Repairs For Technician ID = [???]";
                _TechnicianID = null;
                return;
            }

            _TechnicianID = _Technician.TechnicianID;
            await _LoadTechnicianCurrentWorkload();

            gbAllRepairOrders.Text = $"All Current Workload Repairs For Technician ID = {_TechnicianID}";
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRepairDetails?.Invoke((int)dgvAllRepairs.CurrentRow.Cells[0].Value);
        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            guna2ContextMenuStrip1.Enabled = dgvAllRepairs.CurrentRow != null;
        }
    }
}
