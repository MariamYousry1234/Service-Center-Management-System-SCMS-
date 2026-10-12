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
    public partial class ucShowPurchaseDetails : UserControl
    {

        clsPurchase _Purchase;

        public ucShowPurchaseDetails()
        {
            InitializeComponent();
        }

        private void _SetIntialData()
        {
           
            gbInfo.Text = "Information For Purchase ID = [???]";
            lblPartID.Text = "[???]";
            lblPartName.Text = "[???]";
            lblSupplierID.Text = "[???]";
            lblSupplierName.Text = "[???]";
            lblPurchasePrice.Text = "[???]";
            lblPurchaseDate.Text = "[???]";
            lblQuantity.Text = "[???]";
            lblTotalPrice.Text = "[???]";
            lblCancelledByUser.Text = "[???]";
            lblCreatedUser.Text = "[???]";
            lblIsCancelled.Text = "[???]";
            lblCancelledDate.Text = "[???]";
        }
        private void _LoadData()
        {
            gbInfo.Text = $"Information For Purchase ID = {_Purchase.PurchaseID}";
            lblPartID.Text = _Purchase.PartID.ToString();
            lblPartName.Text =_Purchase.PartInfo.PartName;
            lblSupplierID.Text = _Purchase.SupplierID.ToString();
            lblSupplierName.Text = _Purchase.SupplierInfo.SupplierName;
            lblPurchasePrice.Text = _Purchase.PurchasePrice.ToString();
            lblPurchaseDate.Text = _Purchase.PurchaseDate.ToString("dd/MM/yyyy");
            lblQuantity.Text = _Purchase.Quantity.ToString();
            lblTotalPrice.Text = _Purchase.TotalPrice.ToString();
            lblCancelledByUser.Text = _Purchase.LastUpdatedUserInfo?.Username??"Un Known";
            lblCreatedUser.Text = _Purchase.CreatedUserInfo.Username;
            lblIsCancelled.Text =_Purchase.IsCancelled?"YES":"NO";
            lblCancelledDate.Text = _Purchase.LastUpdatedDate?.ToString("dd/MM/yyyy")??"Un Known";
        }
        public void LoadPurchaseInfo(int PurchaseID)
        {
            _Purchase = clsPurchase.FindPurchase(PurchaseID);

            if(_Purchase==null)
            {
                MessageBox.Show($"Purchase with id = {PurchaseID} Not found!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                _SetIntialData();
                return;
            }

            _LoadData();
        }
    }
}
