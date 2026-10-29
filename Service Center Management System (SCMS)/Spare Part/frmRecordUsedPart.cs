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
    public partial class frmRecordUsedPart : Form
    {
        clsRepairUsedPart _RepairUsedPart;
        int _RepairOrderID;
        public frmRecordUsedPart(int RepairOrderID)
        {
            InitializeComponent();

            clsRepairOrder RepairOrder = clsRepairOrder.Find(RepairOrderID);

            if(RepairOrder == null)
            {
                MessageBox.Show(
                   "Repair order not found.",
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }
            
            if(RepairOrder.Status != clsRepairOrder.enStatus.UnderRepair &&
               RepairOrder.Status != clsRepairOrder.enStatus.RepairCostDetermined &&
              RepairOrder.Status != clsRepairOrder.enStatus.ReadyForDelivery)
            {
                MessageBox.Show(
                   "Used parts can only be added when the repair order is under repair, has a determined repair cost, or is ready for delivery.",
                   "Invalid Repair Order Status",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);

                btnSave.Enabled = false;
                return;
            }

            _RepairOrderID = RepairOrderID;
            _RepairUsedPart = new clsRepairUsedPart();

            lblRepairOrderID.Text = _RepairOrderID.ToString();
            lblUsedDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void frmRecordUsedPart_Load(object sender, EventArgs e)
        {
          
        }

        private void _DetectMinimumStockLevel(clsSparePart SparePart)
        {
            notifyIcon1.BalloonTipTitle = "Stock Alert";

            if (SparePart.Quantity == 0)
            {
                notifyIcon1.BalloonTipText = "This part is out of stock.";

            }
            else if(SparePart.Quantity <= SparePart.MinimumStockLevel)
            {
                notifyIcon1.BalloonTipText = "This part has reached the minimum stock level.";
            }
            else
                return;

            notifyIcon1.Icon = SystemIcons.Warning;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
            notifyIcon1.ShowBalloonTip(9000);

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(ucSearchForSparePart1.SparePart ==null)
            {

                MessageBox.Show(
                    "Please select a spare part.",
                    "Missing Data",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if(!ucSearchForSparePart1.SparePart.IsActive)
            {
                MessageBox.Show(
                    "The selected spare part is inactive.",
                    "Invalid Spare Part",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if(nudQuantity.Value > ucSearchForSparePart1.SparePart.Quantity)
            {
                MessageBox.Show(
                   "The requested quantity exceeds the available stock.",
                   "Insufficient Stock",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);

                return;
            }

            if (MessageBox.Show("Are you sure you want to save used part data?", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.Cancel) return;


            _RepairUsedPart.RepairOrderID = _RepairOrderID;
            _RepairUsedPart.UsedPartID = ucSearchForSparePart1.SparePartID.Value;
            _RepairUsedPart.Quantity = (int)nudQuantity.Value;
            _RepairUsedPart.PartPrice = ucSearchForSparePart1.SparePart.SellingPrice;


            if(_RepairUsedPart.Save())
            {
                MessageBox.Show(
                  "Used part recorded successfully.",
                  "Success",
                   MessageBoxButtons.OK,
                  MessageBoxIcon.Information);

                lblTotalPartPrice.Text = _RepairUsedPart.TotalPrice.ToString();
                ucSearchForSparePart1.LoadPartData(_RepairUsedPart.UsedPartID);
                ucSearchForSparePart1.gbEnabled = false;
                nudQuantity.Enabled = false;
                btnSave.Enabled = false;

                _DetectMinimumStockLevel(ucSearchForSparePart1.SparePart);
            }
            else
            {
                MessageBox.Show(
                    "Failed to record the used part.",
                    "Error",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }


            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRecordUsedPart_Activated(object sender, EventArgs e)
        {
            ucSearchForSparePart1.txtFocus();
        }
    }
}
