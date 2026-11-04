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
    public partial class frmAddEditSparePart : Form
    {
        enum enMode { AddNew = 0, Update = 1 }

        enMode _Mode = enMode.AddNew;

        clsSparePart _SparePart;
        int _SparePartID;
        public frmAddEditSparePart()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
            _SparePart = new clsSparePart();
        }

        public frmAddEditSparePart(int SparePartID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _SparePartID = SparePartID;
        }

        private async Task _LoadPartCategoriesToComboBox()
        {
            DataTable AllCategories =await  clsPartCategory.GetPartCategoriesAsync();

            foreach(DataRow Row in AllCategories.Rows)
            {
                cbPartCategory.Items.Add(Row["PartCategoryName"].ToString());
            }

            cbPartCategory.SelectedIndex = 0;
        }

        private async Task _LoadPartBrandsToComboBox()
        {
            DataTable AllBrands = await clsPartBrand.GetPartBrandsAsync();

            foreach (DataRow Row in AllBrands.Rows)
            {
                cbPartBrand.Items.Add(Row["PartBrandName"].ToString());
            }

            cbPartBrand.SelectedIndex = 0;
        }
        private async Task _LoadIntailData()
        {
             
            if (_Mode==enMode.AddNew)
            {
                this.Text = "Add New Spare Part";
                lblTitle.Text= "Add New Spare Part";
                gbInfo.Text= "Add New Spare Part";

                lblPartID.Text = "[???]";
                txtPartName.Clear();
                txtPartName.Focus();
                txtSellingPrice.Clear();
                nudQuantity.Value = 1;
                nudMSLevel.Value = 1;
                lblCreatedUser.Text = clsGlobal.CurrentUser.Username;
                chkIsActive.Checked = true;
            }
            else
            {
                this.Text = "Update Spare Part Info";
                lblTitle.Text = "Update Spare Part Info";
                gbInfo.Text = "Update Spare Part Info";
            }

            await _LoadPartCategoriesToComboBox();

            await _LoadPartBrandsToComboBox();

        }

        private void _LoadDataToUpdate()
        {
            _SparePart = clsSparePart.FindSparePart(_SparePartID);

            if(_SparePart ==null)
            {
                MessageBox.Show($"Can not found spare part with id ={_SparePartID}");
                this.Close();
                return;
            }

            lblPartID.Text = _SparePart.PartID.ToString();
            txtPartName.Text = _SparePart.PartName;
            cbPartCategory.SelectedItem = _SparePart.PartCategoryInfo.PartCategoryName ;
            cbPartBrand.SelectedItem = _SparePart.PartBrandInfo.PartBrandName;
            txtSellingPrice.Text = _SparePart.SellingPrice.ToString();
            nudQuantity.Value = _SparePart.Quantity;
            nudMSLevel.Value = _SparePart.MinimumStockLevel;
            lblCreatedUser.Text = _SparePart.CreatedUserInfo.Username;
            chkIsActive.Checked = _SparePart.IsActive;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmAddEditSparePart_Load(object sender, EventArgs e)
        {
             await _LoadIntailData();

            if (_Mode == enMode.Update)
                _LoadDataToUpdate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {    
            if (!txtPartName.IsValid() || !txtSellingPrice.IsValid()) return;


            if (Convert.ToSingle(txtSellingPrice.Text.Trim()) < 0)
            {
                MessageBox.Show("Selling price cannot be negative.", "Not allowed",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_Mode==enMode.AddNew &&
                clsSparePart.IsSparePartExists(txtPartName.Text))
            {
                MessageBox.Show("This spare part already exists", "Exists", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }


            if (MessageBox.Show("Are you sure you want to save spare part data?", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.Cancel) return;


            _SparePart.PartName = txtPartName.Text;
            _SparePart.PartCategoryID = clsPartCategory.FindPartCategory(cbPartCategory.Text).PartCategoryID;
            _SparePart.PartBrandID = clsPartBrand.FindPartBrand(cbPartBrand.Text).PartBrandID;
            _SparePart.SellingPrice = Convert.ToSingle(txtSellingPrice.Text.Trim());
            _SparePart.Quantity = Convert.ToInt32(nudQuantity.Value);
            _SparePart.MinimumStockLevel = Convert.ToByte(nudMSLevel.Value);

            if(_Mode==enMode.AddNew)
               _SparePart.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            else
                _SparePart.LastUpdatedUserID = clsGlobal.CurrentUser.UserID;


            if(_SparePart.Save())
            {
                MessageBox.Show($"Data Saved Successfully",
                   "Saved", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);

                _Mode = enMode.Update;
  
                this.Text = "Update Spare Part Info";
                lblTitle.Text = "Update Spare Part Info";
                gbInfo.Text = "Update Spare Part Info";

                _SparePartID = _SparePart.PartID;
                lblPartID.Text = _SparePartID.ToString();
            }
            else
            {
                MessageBox.Show("Failed to save spare part data.", "An error occurred", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        private void frmAddEditSparePart_Activated(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddNew)
                txtPartName.Focus();
        }
    }
}
