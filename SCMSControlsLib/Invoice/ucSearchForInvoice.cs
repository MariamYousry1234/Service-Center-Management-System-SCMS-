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
    public partial class ucSearchForInvoice : UserControl
    {
        public ucSearchForInvoice()
        {
            InitializeComponent();

            cbField.SelectedIndex = 0;
        }

        public void txtFocus()
        {
            txtSearch.Focus();
        }

        public bool gbEnabled
        {
            set
            {
                gbSearch.Enabled = value;
            }
            get
            {
                return gbSearch.Enabled;
            }
        }

        
        public void LoadInvoice(int InvoiceID)
        {
            cbField.SelectedIndex = 0;
            txtSearch.Text = InvoiceID.ToString();

            ucShowInvoiceDetails1.LoadInvoiceInfo(InvoiceID);
            
        }

        public void LoadInvoiceByRepairOrderID(int RepairOrderID)
        {
            cbField.SelectedIndex = 1;
            txtSearch.Text = RepairOrderID.ToString();

            ucShowInvoiceDetails1.LoadInvoiceInfoByRepairOrderID(RepairOrderID);
        }
        private void cbField_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtSearch.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!txtSearch.IsValid()) return;

            switch (cbField.SelectedItem.ToString())
            {
                case "Invoice ID":
                    {
                        ucShowInvoiceDetails1.LoadInvoiceInfo(Convert.ToInt32(txtSearch.Text));
                    }
                    break;

                case "Repair Order ID":
                    {
                        ucShowInvoiceDetails1.LoadInvoiceInfoByRepairOrderID(Convert.ToInt32(txtSearch.Text));
                    }
                    break;

            }
            txtSearch.Focus();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnSearch.PerformClick();
        }
    }
}
