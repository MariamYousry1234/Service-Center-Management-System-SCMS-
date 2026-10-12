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
    public partial class frmShowInvoiceDetails : Form
    {
        int _InvoiceID;
        public frmShowInvoiceDetails(int InvoiceID)
        {
            InitializeComponent();

            _InvoiceID = InvoiceID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowInvoiceDetails_Load(object sender, EventArgs e)
        {
            ucShowInvoiceDetails1.LoadInvoiceInfo(_InvoiceID);
        }
    }
}
