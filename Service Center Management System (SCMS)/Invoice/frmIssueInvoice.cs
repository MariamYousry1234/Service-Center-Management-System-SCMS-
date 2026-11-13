using SCMS_Business_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service_Center_Management_System__SCMS_
{
    public partial class frmIssueInvoice : Form
    {
        enum enMode { AddNew = 0,Update =1}
        enMode _Mode = enMode.AddNew;


        int _RepairCostID;
        clsInvoice _Invoice;
        bool _IsValid = true;
        public frmIssueInvoice(int RepairOrderID,bool AddInvoice)
        {
            InitializeComponent();

            clsRepairOrder RepairOrder = clsRepairOrder.Find(RepairOrderID);

            if(RepairOrder == null)
            {
                MessageBox.Show(
               "Repair Order not found.",
                "Error",
                MessageBoxButtons.OK,
                 MessageBoxIcon.Error);

                _IsValid = false;
                return;
            }

            if(!RepairOrder.HasRepairCost)
            {
                MessageBox.Show(
                   "This Repair Order does not have a Repair Cost.",
                   "Error",
                   MessageBoxButtons.OK,
                 MessageBoxIcon.Error);


                _IsValid = false;
                return;
            }

            if(RepairOrder.Status != clsRepairOrder.enStatus.RepairCostDetermined)
            {
                MessageBox.Show(
                    "This Repair Order is not ready to issue an invoice.",
                     "Not Allowed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);


                _IsValid = false;

                return;
            }

            _RepairCostID = 
                clsRepairCost.FindRepairCostByRepairOrderID(RepairOrder.RepairOrderID).RepairCostID;
            _Mode = enMode.AddNew;
            _Invoice = new clsInvoice();
        }

        public frmIssueInvoice(int InvoiceID)
        {
            InitializeComponent();

            _Invoice = clsInvoice.Find(InvoiceID);

            if (_Invoice == null)
            {

                MessageBox.Show(
                  "Invoice not found.",
                  "Error",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);


                _IsValid = false;
                return;
            }

            if(_Invoice.RepairCostInfo.RepairOrderInfo.Status
                != clsRepairOrder.enStatus.InvoiceIssuing)
            {

                 MessageBox.Show(
                 "This Repair Order is not ready for invoicing.",
                 "Invalid Operation",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);


                _IsValid = false;
                return;
            }
         
            _Mode = enMode.Update;

        }
     
        private void _LoadData()
        {
           

            if (_Mode==enMode.AddNew)
            {              

                this.Text = "Issue Invoice";

                lblCreatedUser.Text = clsGlobal.CurrentUser.Username;
                lblIssueDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

                ucShowRepairCostDetailsWithEditing1.LoadRepairOrderInfo(_RepairCostID);
            }
            else
            {
                this.Text = "Update Invoice";

                ucShowRepairCostDetailsWithEditing1.LoadRepairOrderInfo(_Invoice.RepairCostID);

                lblInvoiceID.Text = _Invoice.InvoiceID.ToString();
                lblIssueDate.Text = _Invoice.IssueDate.ToString("dd/MM/yyyy");
                lblCreatedUser.Text = _Invoice.CreatedUserInfo.Username;

            }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmIssueInvoice_Load(object sender, EventArgs e)
        {
            if(!_IsValid)
            {
                btnSave.Enabled = false;
                
                return;
            }
            ucShowRepairCostDetailsWithEditing1.IsRepairCostUpdated = _EditRepairCost;

            _LoadData();
        }


        private bool _EditRepairCost(int RepairCostID)
        {
            bool IsUpdated = false;

            frmSetRepairCost frm = new frmSetRepairCost(RepairCostID);

            frm.DataSaved += (int? RepaircostID) =>
            {
                IsUpdated = RepaircostID != null;


            };

            frm.ShowDialog();

            return IsUpdated;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save invoice data?", "Confirm",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
               == DialogResult.Cancel) return;



            _Invoice.RepairCostID = ucShowRepairCostDetailsWithEditing1.RepairCostID.Value;

            if(_Mode==enMode.AddNew)
                _Invoice.CreatedByUserID = clsGlobal.CurrentUser.UserID;


            if (_Invoice.Save())
            {
                if (_Mode == enMode.AddNew)
                {
                    MessageBox.Show(
                    "Invoice saved successfully. The invoice is now available in the Invoices Awaiting Payments screen.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show(
                           "Invoice saved successfully.",
                           "Success",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
                }

                _Mode = enMode.Update;
                lblInvoiceID.Text = _Invoice.InvoiceID.ToString();
                this.Text = "Update Invoice";

            }
            else
            {

                MessageBox.Show(
                     "Failed to save the invoice.",
                      "Error",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
            }
        }
    }
}
