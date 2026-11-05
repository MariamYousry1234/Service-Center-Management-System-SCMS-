using SCMS_Business_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service_Center_Management_System__SCMS_
{
    public partial class frmAddEditPayment : Form
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode = enMode.AddNew;


        int _PaymentID;
        clsPayment _Payment;
        int _RepairOrderID;
        clsRepairOrder _RepairOrder;
        public frmAddEditPayment(int RepairOrderID,bool AddNew)
        {
            InitializeComponent();
             _RepairOrder = clsRepairOrder.Find(RepairOrderID);

            if(_RepairOrder ==null)
            {
                MessageBox.Show(
               "Repair order was not found.",
               "Not Found",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);

                btnSave.Enabled = false;
                return;
            }

            if (!_RepairOrder.HasInvoice)
            {
                MessageBox.Show(
               "This repair order does not have an invoice yet. A payment cannot be added before issuing the invoice.",
               "Invoice Not Found",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

                btnSave.Enabled = false;
                return;
            }

            if (_RepairOrder.Status != clsRepairOrder.enStatus.InvoiceIssuing)
            {
                MessageBox.Show(
                   "Cannot record a payment because the invoice has not been issued yet.",
                   "Payment",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);


                btnSave.Enabled = false;
                return;
            }

         
            _Mode = enMode.AddNew;
            _RepairOrderID = RepairOrderID;
            _Payment = new clsPayment();
        }

        public frmAddEditPayment(int PaymentID)
        {
            InitializeComponent();
           
            _Mode = enMode.Update;
            _PaymentID = PaymentID;
        }

        private void _SetIntialData()
        {
            if(_Mode==enMode.AddNew)
            {
                this.Text = "Add New Payment";
                lblTitle.Text= "Add New Payment";
                lblCreatedUser.Text = clsGlobal.CurrentUser.Username;
                lblPaidDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

                lblRemaining.Text = _RepairOrder.PaymentRemaining.ToString();
            }
            else
            {
                this.Text = "Update Payment Info";
                lblTitle.Text = "Update Payment Info";
            }

        }
       

        private void _LoadData()
        {
            _SetIntialData();
            if (_Mode==enMode.AddNew)
            {
                ucShowInvoiceDetails1.LoadInvoiceInfoByRepairOrderID(_RepairOrderID);

            }
            else
            {
                _Payment = clsPayment.FindPayment(_PaymentID);

                if(_Payment==null)
                {

                    MessageBox.Show(
                        "Payment was not found. Please make sure the payment exists and try again.",
                     "Payment Not Found",
                     MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                    btnSave.Enabled = false;
                    return;
                }

                if (_Payment.InvoiceInfo.RepairCostInfo.RepairOrderInfo.Status !=
                     clsRepairOrder.enStatus.InvoiceIssuing)
                {

                    MessageBox.Show(
                        "Cannot update this payment because the invoice has not been issued yet.",
                        "Payment",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);


                    btnSave.Enabled = false;
                    return;
                }

                _RepairOrder = _Payment.InvoiceInfo.RepairCostInfo.RepairOrderInfo;
                ucShowInvoiceDetails1.LoadInvoiceInfo(_Payment.InvoiceID);

                lblPaymentID.Text = _Payment.PaymentID.ToString();
                lblCreatedUser.Text = _Payment.CreatedUserInfo.Username;
                lblPaidDate.Text = _Payment.DatePaid.ToString("dd/MM/yyyy");
                lblRemaining.Text = _Payment.Remaining.ToString();
                txtTotalPaid.Text = _Payment.TotalPaid.ToString();
                txtTotalPaid.SelectionStart = txtTotalPaid.Text.Length;
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!txtTotalPaid.IsValid()) return;

            if(Convert.ToSingle(txtTotalPaid.Text.Trim()) > 
               _RepairOrder.PaymentRemaining && _Mode==enMode.AddNew)
            {
                MessageBox.Show(
                  "The payment amount cannot be greater than the remaining amount.",
                 "Invalid Payment Amount",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);


                return;
            }


            if(_Mode==enMode.Update && Convert.ToSingle(txtTotalPaid.Text.Trim()) >
               (_Payment.TotalPaid + _RepairOrder.PaymentRemaining))
            {
                MessageBox.Show(
                "The payment amount exceeds the maximum allowed amount. Please enter an amount less than or equal to the current payment amount plus the remaining balance.",
                  "Invalid Payment Amount",
                    MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);


                return;
            }

            if (MessageBox.Show("Are you sure you want to save payment data?", "Confirm",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
               == DialogResult.Cancel) return;


            _Payment.InvoiceID = ucShowInvoiceDetails1.InvoiceInfo.InvoiceID;
            _Payment.TotalPaid = Convert.ToSingle(txtTotalPaid.Text.Trim());

            if (_Mode == enMode.AddNew)
                _Payment.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            else
                _Payment.LastUpdatedUserID = clsGlobal.CurrentUser.UserID;


           if (_Payment.Save())
            {
                MessageBox.Show(
                    "Payment saved successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                //refresh data
                ucShowInvoiceDetails1.LoadInvoiceInfo(_Payment.InvoiceID);

                lblPaymentID.Text = _Payment.PaymentID.ToString();
                lblRemaining.Text = _Payment.Remaining.ToString();
                txtTotalPaid.Enabled = false;
                btnSave.Enabled = false;
            }
            else
            {
                MessageBox.Show(
                        "Failed to save payment.",
                       "Error",
                        MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditPayment_Activated(object sender, EventArgs e)
        {
            txtTotalPaid.Focus();
        }

        private void frmAddEditPayment_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
