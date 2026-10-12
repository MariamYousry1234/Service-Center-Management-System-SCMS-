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
    public partial class ucShowInvoiceDetails : UserControl
    {

        clsInvoice _Invoice;
        int? InvoiceID;

        public ucShowInvoiceDetails()
        {
            InitializeComponent();
        }

        public clsInvoice InvoiceInfo
        {
            get
            {
                return _Invoice;
            }
        }
        private void _SetIntialInfo()
        {
            InvoiceID = null;
            ucShowRepairCostDetails1.SetIntialData();

            lblInvoiceID.Text = "[???]";
            lblPaymentStatus.Text = "[???]";
            lblIssueDate.Text = "[???]";
            lblDeviceTypeName.Text = "[???]";
            lblDeviceID.Text = "[???]";
            lblCustomerID.Text = "[???]";
            lblCretedUser.Text = "[???]";

        }

        private void _LoadInvoiceDetails()
        {
            InvoiceID = _Invoice.InvoiceID;

            ucShowRepairCostDetails1.LoadRepairCostDetailsByInvoiceID(InvoiceID.Value);


            lblInvoiceID.Text = InvoiceID.ToString();
            lblPaymentStatus.Text = _Invoice.txtPaymentSatus;
            lblIssueDate.Text = _Invoice.IssueDate.ToString("dd/MM/yyyy");
            lblDeviceTypeName.Text = _Invoice.RepairCostInfo.RepairOrderInfo.DeviceInfo.DeviceTypeInfo.DeviceTypeName;
            lblDeviceID.Text =_Invoice.RepairCostInfo.RepairOrderInfo.DeviceID.ToString();
            lblCustomerID.Text = _Invoice.RepairCostInfo.RepairOrderInfo.DeviceInfo.CustomerID.ToString();
            lblCretedUser.Text = _Invoice.CreatedUserInfo.Username;

        }
        public void LoadInvoiceInfo(int InvoiceID)
        {
            _Invoice = clsInvoice.Find(InvoiceID);

            if(_Invoice == null)
            {
                MessageBox.Show(
              "Invoice not found.",
               "Error",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);

                _SetIntialInfo();
                return;
            }

            _LoadInvoiceDetails();

        }


        public void LoadInvoiceInfoByRepairOrderID(int RepairOrderID)
        {
            _Invoice = clsInvoice.FindByRepairOrderID(RepairOrderID);

            if (_Invoice == null)
            {
                MessageBox.Show(
              "Invoice not found.",
               "Error",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);

                _SetIntialInfo();
                return;
            }

            _LoadInvoiceDetails();

        }
    }
}
