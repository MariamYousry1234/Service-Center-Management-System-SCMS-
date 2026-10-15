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
    public partial class ucShowRepairCostDetails : UserControl
    {

      
        clsRepairCost _RepairCost;
        int? _RepairCostID;

        public ucShowRepairCostDetails()
        {
            InitializeComponent();
        }

        public int? RepairCostID
        {
            get
            {
                return _RepairCostID;
            }
        }
        public void SetIntialData()
        {
            _RepairCostID = null;
            gbDetails.Text = "Repair Cost Details For Repair Order ID = [???]";
            lblPartsCost.Text = "[???]";
            lblLaborCost.Text = "[???]";
            lblAdditionalServices.Text = "[???]";
            lblTaxAmount.Text = "[???]";
            lblDiscount.Text = "[???]";
            lblTotalRepairCost.Text = "[???]";
            lblCreatedDate.Text  = "[???]";
            lblCreatedUser.Text = "[???]";

        }
        private void _LoadRepairCostData()
        {
            _RepairCostID = _RepairCost.RepairCostID;
            gbDetails.Text = 
                $"Repair Cost Details For Repair Order ID ={_RepairCost.RepairOrderID}";
            lblPartsCost.Text =_RepairCost.PartsCost.ToString();
            lblLaborCost.Text = _RepairCost.LaborCost.ToString();
            lblAdditionalServices.Text =_RepairCost.AdditionalServices.ToString();
            lblTaxAmount.Text = _RepairCost.TaxAmount.ToString();
            lblDiscount.Text = _RepairCost.DiscountAmount.ToString();
            lblTotalRepairCost.Text = _RepairCost.TotalRepairCost.ToString();
            lblCreatedDate.Text =_RepairCost.CreatedDate.ToString("dd/MM/yyyy");
            lblCreatedUser.Text = _RepairCost.CreatedUserInfo.Username;
        }
        public void LoadRepairCostDetails(int RepairCostID)
        {
            _RepairCost = clsRepairCost.FindRepairCost(RepairCostID);

            if(_RepairCost==null)
            {

                MessageBox.Show(
                "Repair Cost not found.",
                 "Error",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);

              
                SetIntialData();
                return;
            }
        
            _LoadRepairCostData();

        }

        public void LoadRepairCostDetailsByInvoiceID(int InvoiceID)
        {
            clsInvoice Invoice = clsInvoice.Find(InvoiceID);

            if (Invoice == null)
            {

                MessageBox.Show(
                "Invoice not found.",
                 "Error",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);


                SetIntialData();
                return;
            }

            _RepairCost = Invoice.RepairCostInfo;
            _LoadRepairCostData();

        }
    }
}
