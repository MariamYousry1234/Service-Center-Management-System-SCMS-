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
    public partial class frmShowPurchaseDetails : Form
    {

        int _PurchaseID;
        public frmShowPurchaseDetails(int PurchaseID)
        {
            InitializeComponent();

            _PurchaseID = PurchaseID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowPurchaseDetails_Load(object sender, EventArgs e)
        {
            ucShowPurchaseDetails1.LoadPurchaseInfo(_PurchaseID);
        }
    }
}
