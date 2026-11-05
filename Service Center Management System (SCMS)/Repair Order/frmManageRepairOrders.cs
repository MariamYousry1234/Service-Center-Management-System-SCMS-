using SCMS_Business_Logic;
using SharedLib;
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
    public partial class frmManageRepairOrders : Form
    {
        private int TotalPages = 1;
        private int CurrentPage = 1;
        private int NumberOfRepairOrdersEachPage = Convert.ToInt32(ConfigurationManager.AppSettings["NumberOfRowsEachPage"]);

        private string ApplicationName = ConfigurationManager.AppSettings["ApplicationName"];

        DataTable _CurrentData;
        clsRepairOrder _CurrentRepairOrder;
        public frmManageRepairOrders()
        {
            InitializeComponent();
        }

        private async Task _LoadRepairOrdersDataAsync()
        {
            _CurrentData = await clsRepairOrder.GetRepairOrdersAsync(NumberOfRepairOrdersEachPage, CurrentPage);
            dgvData.DataSource = _CurrentData;
            lblPageNumber.Text = CurrentPage.ToString();

            if (dgvData.Rows.Count > 0)
            {
                dgvData.Columns[1].Width = 200;
                dgvData.Columns[2].Width = 200;
                dgvData.Columns[3].Width = 150;
                dgvData.Columns[4].Width = 70;
                dgvData.Columns[5].Width = 200;
                dgvData.Columns[6].Width = 120;
            }
            cbFiltering.SelectedIndex = 0;
        }

        private async void frmManageRepairOrders_Load(object sender, EventArgs e)
        {
          
            btnPrevious.Enabled = false;
            CurrentPage = 1;

            TotalPages = await clsRepairOrder.GetRepairOrdersNumberPages(NumberOfRepairOrdersEachPage);
            lblTotalPages.Text = TotalPages.ToString();


            if (TotalPages == 0 || TotalPages == 1)
            {
                lblTotalPages.Text = "1";
                lblPageNumber.Text = "1";
                btnNext.Enabled = false;
            }
            else
                btnNext.Enabled = true;
            await _LoadRepairOrdersDataAsync();
        }

        private async  void btnNext_Click(object sender, EventArgs e)
        {
            if (++CurrentPage <= TotalPages)
            {
                btnPrevious.Enabled = true;

                await _LoadRepairOrdersDataAsync();

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

                await _LoadRepairOrdersDataAsync();


                if (CurrentPage == 1)
                    btnPrevious.Enabled = false;
            }
        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {   
            if (dgvData.CurrentRow == null)
            {
                guna2ContextMenuStrip1.Enabled =false;
                _CurrentRepairOrder = null;
                return;
            }
            else
                guna2ContextMenuStrip1.Enabled = true;



             _CurrentRepairOrder = clsRepairOrder.Find((int)dgvData.CurrentRow.Cells[0].Value);

            
            updateInfoToolStripMenuItem.Enabled= 
                (_CurrentRepairOrder.Status != clsRepairOrder.enStatus.Cancelled)
              && (_CurrentRepairOrder.Status != clsRepairOrder.enStatus.Delivered);

            cancelRepairOrderToolStripMenuItem.Enabled = 
                (_CurrentRepairOrder.Status != clsRepairOrder.enStatus.Cancelled)
              && (_CurrentRepairOrder.Status != clsRepairOrder.enStatus.Delivered) 
              && (_CurrentRepairOrder.Status != clsRepairOrder.enStatus.Rejected);


            diagnosisToolStripMenuItem.Enabled =
                _CurrentRepairOrder.Status == clsRepairOrder.enStatus.WaitingForDiagnosis ||
                _CurrentRepairOrder.Status == clsRepairOrder.enStatus.WaitingForCustomerApproval;


            performDiagnosisToolStripMenuItem.Enabled = 
                _CurrentRepairOrder.Status == clsRepairOrder.enStatus.WaitingForDiagnosis
                 && _CurrentRepairOrder.DiagnosisInfo == null;


            customerApprovalToolStripMenuItem.Enabled =
                  _CurrentRepairOrder.Status == clsRepairOrder.enStatus.WaitingForCustomerApproval
                   &&
                   _CurrentRepairOrder.DiagnosisInfo != null &&
                   _CurrentRepairOrder.DiagnosisInfo.Status == null;


            recordUsedPartToolStripMenuItem.Enabled = 
                _CurrentRepairOrder.Status == clsRepairOrder.enStatus.UnderRepair;

            setRepairCostToolStripMenuItem.Enabled =
                _CurrentRepairOrder.Status == clsRepairOrder.enStatus.UnderRepair
                && !_CurrentRepairOrder.HasRepairCost;

        }

  
        private void updateInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_CurrentRepairOrder == null) return;

            frmAddEditRepairOrder frm = new frmAddEditRepairOrder(_CurrentRepairOrder.RepairOrderID);

            frm.ShowDialog();

            frmManageRepairOrders_Load(null, null);
        }

        private void showRepairOrderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowRepairOrderDetails frm = new frmShowRepairOrderDetails(_CurrentRepairOrder.RepairOrderID);
          
            frm.ShowDialog();
        }

        private void cancelRepairOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_CurrentRepairOrder == null) return;


            if(_CurrentRepairOrder.Status ==clsRepairOrder.enStatus.Delivered ||
                _CurrentRepairOrder.Status == clsRepairOrder.enStatus.Cancelled)
            {
                MessageBox.Show("Can not cancel this repair order", "Not allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Are you sure you want to cancel repair order with id {_CurrentRepairOrder.RepairOrderID}?", 
                "confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return;


            if(_CurrentRepairOrder.Cancel(clsGlobal.CurrentUser.UserID))
            {
                MessageBox.Show($"Repair order with id = {_CurrentRepairOrder.RepairOrderID} cancelled successfully",
                    "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);


                clsEventLogger.WriteEntryToEventLog(
                    ApplicationName,
                    $"User with username = {clsGlobal.CurrentUser.Username} cancelled Repair Order with ID = {_CurrentRepairOrder.RepairOrderID} successfully",
                    System.Diagnostics.EventLogEntryType.Information);

                frmManageRepairOrders_Load(null, null);

            }
            else
            {
                MessageBox.Show($"Failed to cancel repair order with id = {_CurrentRepairOrder.RepairOrderID}.",
                 "Cancellation Failed",
                  MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
        }

        private void _FillComboBoxWithPriority()
        {
            cbfiltering2.Items.Clear();
            cbfiltering2.Items.AddRange(new object[]
            {
                  "None","Low","Medium","Urgent"
            });

            cbfiltering2.SelectedIndex = 0;
        }

        private void _FillComboBoxWithStatus()
        {
            cbfiltering2.Items.Clear();
            cbfiltering2.Items.AddRange(new object[]
            {
                   "None",
                   "Waiting For Diagnosis",
                   "Waiting For Customer Approval",
                   "Approval",
                   "Under Repair",
                   "Ready For Delivery",
                   "Delivered",
                   "Cancelled"
            });

            cbfiltering2.SelectedIndex = 0;
        }
        private void cbFiltering_SelectedIndexChanged(object sender, EventArgs e)
        {
            _CurrentData.DefaultView.RowFilter = "";

            if (cbFiltering.Text == "None")
            {
                cbfiltering2.Visible = false;
                txtName.Visible = false;

                return;
            }

            cbfiltering2.Visible =
                cbFiltering.Text == "Status" || cbFiltering.Text == "Priority";

           txtName.Visible =
                cbFiltering.Text == "Customer Name" || cbFiltering.Text == "Technician Name";

            
            switch (cbFiltering.SelectedItem.ToString())
            {
                case "Status":
                    _FillComboBoxWithStatus();
                    break;

                case "Priority":
                    _FillComboBoxWithPriority();
                    break;

                default:
                    txtName.Clear();
                    txtName.Focus();
                    break;
            }


        }

        private void cbfiltering2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbfiltering2.Text != "None" &&
                !string.IsNullOrEmpty(cbfiltering2.Text))
            {
                _CurrentData.DefaultView.RowFilter = $"{cbFiltering.Text} ='{cbfiltering2.Text}'";
            }
            else
                _CurrentData.DefaultView.RowFilter = "";
         
            dgvData.DataSource = _CurrentData;

        }

        private void showRepairOrderHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_CurrentRepairOrder == null) return;

            frmShowRepairOrderHistory frm =
                new frmShowRepairOrderHistory(_CurrentRepairOrder.RepairOrderID);

            frm.ShowDialog();
        }

        private void performDiagnosisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_CurrentRepairOrder == null) return;

            frmAddEditDiagnosis frm =
                new frmAddEditDiagnosis(_CurrentRepairOrder.RepairOrderID, true);

            frm.ShowDialog();


            frmManageRepairOrders_Load(null, null);
        }

        private void customerApprovalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_CurrentRepairOrder.DiagnosisInfo.Status != null) return;


            frmCustomerApproval frm = new frmCustomerApproval(_CurrentRepairOrder.DiagnosisInfo.DiagnosisID);

            frm.ShowDialog();

            frmManageRepairOrders_Load(null, null);
        }

        private void recordUsedPartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_CurrentRepairOrder.Status != clsRepairOrder.enStatus.UnderRepair) return;

            frmRecordUsedPart frm = new frmRecordUsedPart(_CurrentRepairOrder.RepairOrderID);

            frm.ShowDialog();

        }

        private void setRepairCostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_CurrentRepairOrder.Status != clsRepairOrder.enStatus.UnderRepair
                || _CurrentRepairOrder.HasRepairCost) return;


            frmSetRepairCost frm = new frmSetRepairCost(_CurrentRepairOrder.RepairOrderID,true);

            frm.ShowDialog();

            frmManageRepairOrders_Load(null, null);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
                _CurrentData.DefaultView.RowFilter = "";
            else
                _CurrentData.DefaultView.RowFilter = $"[{cbFiltering.Text}] like '{txtName.Text}%'";
        }
    }
}
