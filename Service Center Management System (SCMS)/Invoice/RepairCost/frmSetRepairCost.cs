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
    public partial class frmSetRepairCost : Form
    {
        public Action<int?> DataSaved;
        enum enMode { AddNew=0,Update=1}
        enMode _Mode = enMode.AddNew;

        clsRepairOrder _RepairOrder;
        clsRepairCost _RepairCost;
        int? _RepairCostID;
        public frmSetRepairCost(int RepairOrderID,bool AddNew)
        {
            InitializeComponent();

            _RepairOrder = clsRepairOrder.Find(RepairOrderID);

            if(_RepairOrder==null)
            {
                MessageBox.Show("Repair Order not found.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);


                this.Close();
                return;
            }

            if (_RepairOrder.Status != clsRepairOrder.enStatus.UnderRepair)
            {
                MessageBox.Show("The Repair Order must be under repair.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                this.Close();
                return;
            }

            if (_RepairOrder.HasRepairCost)
            {
                MessageBox.Show("A repair cost has already been set for this Repair Order.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();
                return;
            }

            _Mode = enMode.AddNew;
            _RepairCost = new clsRepairCost();
            txtAdditionalServices.Focus();
        }

        public frmSetRepairCost(int RepairCostID)
        {
            InitializeComponent();
  
            _Mode = enMode.Update;
            _RepairCostID = RepairCostID;

        }

        private void _SetIntialData()
        {
            if (_Mode == enMode.AddNew)
            {
                this.Text = "Add Repair Cost";
                lblTitle.Text = "Add Repair Cost";

                lblTotalPartsCost.Text = _RepairOrder.TotalUsedPartsPrice.ToString();
                lblLaborCost.Text = _RepairOrder.DiagnosisInfo.LaborCost.ToString();
                lblCreatedDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                lblCreatedUser.Text = clsGlobal.CurrentUser.Username;
            }
            else
            {

                this.Text = "Update Repair Cost";
                lblTitle.Text = "Update Repair Cost";

            }
        }
        private async Task _LoadData()
        {
            _SetIntialData();
            if (_Mode==enMode.AddNew)
            {
                await ucShowUsedParts1.LoadUsedPartsForRepairOrder(_RepairOrder.RepairOrderID);
            }
            else
            {
                _RepairCost = clsRepairCost.FindRepairCost(_RepairCostID.Value);

                if (_RepairCost == null)
                {
                    MessageBox.Show("Repair Cost not found.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    this.Close();
                    return;
                }

                if(_RepairCost.RepairOrderInfo.Status == clsRepairOrder.enStatus.Delivered
                    || _RepairCost.RepairOrderInfo.Status == clsRepairOrder.enStatus.Cancelled)
                {

                    MessageBox.Show(
                              "This repair cost cannot be modified because the Repair Order is either delivered or cancelled.",
                              "Not Allowed",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);

                    this.Close();
                    return;
                }

                await ucShowUsedParts1.LoadUsedPartsForRepairOrder(_RepairCost.RepairOrderID);
                lblTotalPartsCost.Text = _RepairCost.PartsCost.ToString();
                lblLaborCost.Text = _RepairCost.LaborCost.ToString();
                txtAdditionalServices.Text = _RepairCost.AdditionalServices?.ToString()?? "";
                txtDiscount.Text = _RepairCost.DiscountAmount?.ToString() ?? "";
                txtTaxAmount.Text = _RepairCost.TaxAmount?.ToString() ?? "";
                lblTotalRepairCost.Text = _RepairCost.TotalRepairCost.ToString();
                lblCreatedDate.Text = _RepairCost.CreatedDate.ToString("dd/MM/yyyy");
                lblCreatedUser.Text = _RepairCost.CreatedUserInfo.Username;

            }

        }


        private async void frmSetRepairCost_Load(object sender, EventArgs e)
        {
            ucShowUsedParts1.ShowPartInfo = _ShowPartDetails;
            ucShowUsedParts1.AddUsedPart = _AddUsedPart;
            ucShowUsedParts1.RefreshIntialData = _LoadData;

            await _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private float _GetTotalRepairCostWithoutDiscount()
        {
            return Convert.ToSingle(lblTotalPartsCost.Text) + Convert.ToSingle(lblLaborCost.Text.Trim())
              + (!string.IsNullOrEmpty(txtAdditionalServices.Text.Trim()) ?
              Convert.ToSingle(txtAdditionalServices.Text.Trim()) : 0) +
              (!string.IsNullOrEmpty(txtTaxAmount.Text.Trim()) ?
              Convert.ToSingle(txtTaxAmount.Text.Trim()) : 0);           
               
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!txtAdditionalServices.IsValid() || !txtDiscount.IsValid()
                || !txtTaxAmount.IsValid()) return;



            float TotalRepairCostWithoutDiscount = _GetTotalRepairCostWithoutDiscount();

            if(!string.IsNullOrEmpty(txtDiscount.Text.Trim()) &&
                TotalRepairCostWithoutDiscount < Convert.ToSingle(txtDiscount.Text.Trim()))
            {

                MessageBox.Show("Discount amount cannot exceed the total repair cost.",
                   "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (MessageBox.Show("Are you sure you want to save repair cost data?", "Confirm",
              MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
               == DialogResult.Cancel) return;


            _RepairCost.RepairOrderID = ucShowUsedParts1.RepairOrderID.Value;
            _RepairCost.AdditionalServices = string.IsNullOrEmpty(txtAdditionalServices.Text.Trim())?
                null:
                (float?)Convert.ToSingle(txtAdditionalServices.Text);

            _RepairCost.TaxAmount = string.IsNullOrEmpty(txtTaxAmount.Text.Trim()) ?
                null :
                (float?)Convert.ToSingle(txtTaxAmount.Text.Trim());

            _RepairCost.DiscountAmount = string.IsNullOrEmpty(txtDiscount.Text.Trim()) ?
                null :
                (float?)Convert.ToSingle(txtDiscount.Text.Trim()); 


            if(_Mode==enMode.AddNew)
                 _RepairCost.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            

            if(_RepairCost.Save())
            {
                if (_Mode == enMode.AddNew)
                {
                    MessageBox.Show("Repair cost saved successfully. The repair order is now available in the Ready for Invoicing screen. Please go to that screen to generate the invoice.",
                     "Success",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Repair cost saved successfully.",
                                       "Success",
                                      MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                }


                _Mode = enMode.Update;
                _RepairCostID = _RepairCost.RepairCostID;
                lblTotalRepairCost.Text = _RepairCost.TotalRepairCost.ToString();
                   
                this.Text = "Update Repair Cost";
                lblTitle.Text= "Update Repair Cost";

                DataSaved?.Invoke(_RepairCost.RepairCostID);
            }
            else
            {
                MessageBox.Show("Failed to save repair cost.",
                          "Error",
                        MessageBoxButtons.OK,
                          MessageBoxIcon.Error);
            }
        }

        private void _ShowPartDetails(int PartID)
        {
            frmShowSparePartDetails frm = new frmShowSparePartDetails(PartID);

            frm.ShowDialog();
        }

        private async void _AddUsedPart(int RepairOrderID)
        {
            frmRecordUsedPart frm = new frmRecordUsedPart(RepairOrderID);

            frm.ShowDialog();
            await _LoadData();
        }

        
    }
}
