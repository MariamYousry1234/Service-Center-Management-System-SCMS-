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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Service_Center_Management_System__SCMS_
{
    public partial class frmAddEditPartBrand : Form
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode = enMode.AddNew;

        clsPartBrand _PartBrand;
        int _PartBrandID;
        public frmAddEditPartBrand()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
            _PartBrand = new clsPartBrand();
        }

        public frmAddEditPartBrand(int PartBrandID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _PartBrandID = PartBrandID;
        }

        private void _SetIntialData()
        {
            if (_Mode == enMode.AddNew)
            {
                this.Text = "Add New Part Brand";
                lblTitle.Text = "Add New Part Brand";
                lblBrandID.Text = "[???]";
                txtBrandName.Clear();

            }
            else
            {
                this.Text = "Update Part Brand Info";
                lblTitle.Text = "Update Part Brand Info";
            }
        
        }


        private void _LoadDataToUpdate()
        {
            _PartBrand = clsPartBrand.FindPartBrand(_PartBrandID);

            if (_PartBrand == null)
            {
                MessageBox.Show($"Can not find brand with id={_PartBrandID}", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblBrandID.Text = _PartBrand.PartBrandID.ToString();
            txtBrandName.Text = _PartBrand.PartBrandName;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditPartBrand_Load(object sender, EventArgs e)
        {
            _SetIntialData();

            if (_Mode == enMode.Update)
                _LoadDataToUpdate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!txtBrandName.IsValid()) return;

            int? BrandID = clsPartBrand.GetPartBrandIDByName(txtBrandName.Text.Trim());
            if (BrandID != null)
            {
                MessageBox.Show($"This brand already exists with id = {BrandID}", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }


            if (MessageBox.Show("Are you sure you want to save part brand data?", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.Cancel) return;


            _PartBrand.PartBrandName = txtBrandName.Text;

            if (_PartBrand.Save())
            {
                MessageBox.Show($"Data Saved Successfully", "Saved", MessageBoxButtons.OK,
                  MessageBoxIcon.Information);

                _Mode = enMode.Update;
                lblBrandID.Text = _PartBrand.PartBrandID.ToString();
                _SetIntialData();
            }
            else
            {
                MessageBox.Show("Failed to save brand data.", "An error occurred", MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
        }

        private void frmAddEditPartBrand_Activated(object sender, EventArgs e)
        {
            txtBrandName.Focus();
        }
    }
}
