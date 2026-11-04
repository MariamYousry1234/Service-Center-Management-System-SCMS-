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
    public partial class ucShowUsedParts : UserControl
    {
        public Action<int> ShowPartInfo;
        public Action<int> AddUsedPart;
        public Func<Task> RefreshIntialData;

        clsRepairOrder _RepairOrder;
        int? _RepairOrderID;
        public ucShowUsedParts()
        {
            InitializeComponent();
        }
        
        public int? RepairOrderID
        {
            get
            {
                return _RepairOrderID;
            }
        }
        public async Task LoadUsedPartsForRepairOrder(int RepairOrderID)
        {

            _RepairOrder = clsRepairOrder.Find(RepairOrderID);

            if (_RepairOrder==null)
            {
                MessageBox.Show("Repair Order not found.",
                       "Error",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                lblTitle.Text = "Repair Order ID = [???]";
                lblTotalParts.Text = "[???]";
                contextMenuStrip1.Enabled = false;
                _RepairOrderID = null;
                return;
            }

            contextMenuStrip1.Enabled = true;
            _RepairOrderID = RepairOrderID;
            lblTitle.Text = $"Repair Order ID = {RepairOrderID}";
            dgvData.DataSource = await _RepairOrder.GetAllUsedParts();
            
            if(dgvData.Rows.Count>0)
            {
                dgvData.Columns[7].Width = 120;
            }
            lblTotalParts.Text = dgvData.Rows.Count.ToString();

        }

        private void deleteSparePartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this used part?", "Confirm",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.Cancel) return;

            int UsedPartID = (int)dgvData.CurrentRow.Cells[0].Value;
            if (clsRepairUsedPart.DeleteRepairUsedPart(UsedPartID))
            {

                MessageBox.Show("Part deleted successfully.",
               "Success",
               MessageBoxButtons.OK,
                 MessageBoxIcon.Information);

                RefreshIntialData?.Invoke();
            }
            else
            {
                MessageBox.Show("Failed to delete the part.",
                     "Error",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);

            }

        }

        private void showSparePartDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPartInfo?.Invoke((int)dgvData.CurrentRow.Cells[2].Value);
        }

     
        private void addUsedSparePartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_RepairOrderID == null) return;


            AddUsedPart?.Invoke(_RepairOrderID.Value);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

            showSparePartDetailsToolStripMenuItem.Enabled = dgvData.CurrentRow != null;

            deleteSparePartToolStripMenuItem.Enabled = dgvData.CurrentRow != null;
        }
    }
}
