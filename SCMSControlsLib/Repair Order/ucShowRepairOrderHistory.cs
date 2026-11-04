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
    public partial class ucShowRepairOrderHistory : UserControl
    {
        clsRepairOrder _RepairOrder;
        int? _RepairOrderID;
        public ucShowRepairOrderHistory()
        {
            InitializeComponent();
        }

        private async Task _LoadHistory()
        {
            dgvAllChanges.DataSource =await _RepairOrder.GetHistoryAsync();

            if(dgvAllChanges.Rows.Count>0)
            {
                dgvAllChanges.Columns[0].Width = 150;
                dgvAllChanges.Columns[1].Width = 250;
                dgvAllChanges.Columns[2].Width = 250;
                dgvAllChanges.Columns[3].Width = 200;
                dgvAllChanges.Columns[4].Width = 190;
            }
        }
        public async void LoadRepairOrderHistory(int RepairOrderID)
        {
            _RepairOrder = clsRepairOrder.Find(RepairOrderID);

            if(_RepairOrder==null)
            {
                MessageBox.Show($"Repair order with id ={RepairOrderID} Not found!", "Not found",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                _RepairOrderID = null;
                return;
            }

            _RepairOrderID = _RepairOrder.RepairOrderID;

            await _LoadHistory();
            gbAllHistory.Text = $"History For RepairOrderID = {_RepairOrderID}";

        }
    }
}
