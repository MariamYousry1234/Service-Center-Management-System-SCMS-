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
    public partial class ucShowAllPreviousOperationsForPart : UserControl
    {
        public Action <int>ShowPurchaseDetails;
        clsSparePart _SparePart;
        public ucShowAllPreviousOperationsForPart()
        {
            InitializeComponent();
        }

        private async Task _LoadData()
        {
            dgvAllOperations.DataSource = await _SparePart.GetAllPurchaseOperationsAsync();

            lblTotalOperations.Text = dgvAllOperations.Rows.Count.ToString();

            if (dgvAllOperations.Rows.Count > 0)
            {
                dgvAllOperations.Columns[1].Width = 250;
                dgvAllOperations.Columns[2].Width = 180;
                dgvAllOperations.Columns[5].Width = 250;
                dgvAllOperations.Columns[7].Width = 250;
            
            }
        }
        public async Task LoadAllPrevoiusPurchaseOperations(int PartID)
        {
            _SparePart = clsSparePart.FindSparePart(PartID);

            if (_SparePart == null)
            {
                MessageBox.Show($"Spare part with id = {PartID} Not found!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                gbAllOperations.Text = "All Pervious Purchase Operations For Part ID = [???]";
                return;
            }

         
            await _LoadData();

            gbAllOperations.Text = $"All Pervious Purchase Operations For Part ID = {_SparePart.PartID}";
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            ShowPurchaseDetails?.Invoke((int)dgvAllOperations.CurrentRow.Cells[0].Value);
        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            guna2ContextMenuStrip1.Enabled = dgvAllOperations.CurrentRow != null;
        }
    }
}
