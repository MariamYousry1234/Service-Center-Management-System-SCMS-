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
    public partial class frmAddEditBrand : Form
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode = enMode.AddNew;

        clsBrand _Brand;
        int _BrandID;
        public frmAddEditBrand()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
            _Brand =new clsBrand();
        }
        public frmAddEditBrand(int BrandID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _BrandID = BrandID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _SetIntialData()
        {
            if (_Mode == enMode.AddNew)
            {
                this.Text = "Add New Brand";
                lblTitle.Text = "Add New Brand";
                lblBrandID.Text = "[???]";
                txtBrandName.Clear();

            }
            else
            {
                this.Text = "Update Brand Info";
                lblTitle.Text = "Update Brand Info";
            }
            txtBrandName.Focus();
        }

        private void _LoadDataToUpdate()
        {
            _Brand = clsBrand.FindBrand(_BrandID);

            if (_Brand == null)
            {
                MessageBox.Show($"Can not find brand with id={_BrandID}", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblBrandID.Text = _Brand.BrandID.ToString();
            txtBrandName.Text = _Brand.BrandName;

        }

        private void frmAddEditBrand_Load(object sender, EventArgs e)
        {
            _SetIntialData();

            if (_Mode == enMode.Update)
                _LoadDataToUpdate();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!txtBrandName.IsValid()) return;

            int? BrandID = clsBrand.GetBrandIDByBrandName(txtBrandName.Text.Trim());
            if (BrandID != null)
            {
                MessageBox.Show($"This brand already exists with id = {BrandID}", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            _Brand.BrandName = txtBrandName.Text;

            if (_Brand.Save())
            {
                MessageBox.Show($"Data Saved Successfully", "Saved", MessageBoxButtons.OK,
                  MessageBoxIcon.Information);

                _Mode = enMode.Update;
                lblBrandID.Text = _Brand.BrandID.ToString();
                _SetIntialData();
            }
            else
            {
                MessageBox.Show("Failed to save brand data.", "An error occurred", MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
        }

        private void frmAddEditBrand_Activated(object sender, EventArgs e)
        {
            txtBrandName.Focus();
        }
    }
}
