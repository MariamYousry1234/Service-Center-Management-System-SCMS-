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

namespace Service_Center_Management_System__SCMS_
{
    public partial class frmCreateSparePartPurchase : Form
    {
        clsPurchase _Purchase;
      
        public frmCreateSparePartPurchase()
        {
            InitializeComponent();
        }
        public frmCreateSparePartPurchase(int SparePartID)
        {
            InitializeComponent();

        
            ucSearchForSparePart1.LoadPartData(SparePartID);
            ucSearchForSparePart1.gbEnabled = false;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!txtPurchasePrice.IsValid())
            {
                MessageBox.Show("Please enter purchase price", "Not allowed", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if(ucSearchForSparePart1.SparePartID ==null)
            {
                MessageBox.Show("Please select a spare part.", "Not allowed", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                return;
            }

            if (!ucSearchForSparePart1.SparePart.IsActive)
            {
                MessageBox.Show("The selected spare part is inactive.", "Not allowed",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ucSearchForSupplier1.SupplierID == null)
            {
                MessageBox.Show("Please select a supplier.", "Not allowed", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return;
            }

            if (!ucSearchForSupplier1.Supplier.IsActive)
            {
                MessageBox.Show("The selected supplier is inactive.", "Not allowed",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(Convert.ToSingle(txtPurchasePrice.Text.Trim())<0)
            {
                MessageBox.Show("Purchase price cannot be negative.", "Not allowed",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to save purchase date?", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.Cancel) return;



            _Purchase.PartID = ucSearchForSparePart1.SparePartID.Value;
            _Purchase.SupplierID = ucSearchForSupplier1.SupplierID.Value;
            _Purchase.PurchasePrice = Convert.ToSingle(txtPurchasePrice.Text.Trim());
            _Purchase.Quantity = (int) nudQuantity.Value;
            _Purchase.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if(_Purchase.Save())
            {
                MessageBox.Show($"Data Saved Successfully",
                 "Saved", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);

                lblPurchaseID.Text = _Purchase.PurchaseID.ToString();
                lblTotalPrice.Text = ((float)_Purchase.PurchasePrice * _Purchase.Quantity).ToString();

                ucSearchForSparePart1.gbEnabled = false;
                ucSearchForSupplier1.gbEnabled = false;
                txtPurchasePrice.Enabled = false;
                nudQuantity.Enabled = false;
            }
            else
            {
                MessageBox.Show("Failed to save purchase data.", "An error occurred", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void frmCreateSparePartPurchase_Load(object sender, EventArgs e)
        {
            lblCreatedUser.Text = clsGlobal.CurrentUser.Username;
            lblPurchaseDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            _Purchase = new clsPurchase();
        }

        private void lblTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void frmCreateSparePartPurchase_Activated(object sender, EventArgs e)
        {
            ucSearchForSparePart1.txtFocus();
        }
    }
}
