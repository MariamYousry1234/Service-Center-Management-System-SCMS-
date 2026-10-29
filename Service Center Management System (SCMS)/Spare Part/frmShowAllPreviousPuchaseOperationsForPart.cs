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
    public partial class frmShowAllPreviousPuchaseOperationsForPart : Form
    {
        int _PartID;
        public frmShowAllPreviousPuchaseOperationsForPart(int PartID)
        {
            InitializeComponent();

            _PartID = PartID;
        }

        private async void frmShowAllPreviousPuchaseOperationsForPart_Load(object sender, EventArgs e)
        {
            ucShowAllPreviousOperationsForPart1.ShowPurchaseDetails = _LoadPurchaseDetailsForm;
            ucShowAllPreviousOperationsForPart1.ShowSupplierDetails = _LoadSupplierDetailsForm;

            await ucShowAllPreviousOperationsForPart1.LoadAllPrevoiusPurchaseOperations(_PartID);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _LoadPurchaseDetailsForm(int PurchaseID)
        {
            frmShowPurchaseDetails frm = new frmShowPurchaseDetails(PurchaseID);

            frm.ShowDialog();
        }

        private void _LoadSupplierDetailsForm(int SupplierID)
        {
           frmShowSupplierInfo frm = new frmShowSupplierInfo(SupplierID);

           frm.ShowDialog();
        }
    }
}
