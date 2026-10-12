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
            ucShowAllPreviousOperationsForPart1.ShowPurchaseDetails = LoadPurchaseDetailsForm;
            await ucShowAllPreviousOperationsForPart1.LoadAllPrevoiusPurchaseOperations(_PartID);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadPurchaseDetailsForm(int PurchaseID)
        {
            frmShowPurchaseDetails frm = new frmShowPurchaseDetails(PurchaseID);

            frm.ShowDialog();
        }
    }
}
