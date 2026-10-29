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
    public partial class frmAddEditPartCategories : Form
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode = enMode.AddNew;

        clsPartCategory _PartCategory;
        int _PartCategoryID;
        public frmAddEditPartCategories()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
            _PartCategory = new clsPartCategory();
        }

        public frmAddEditPartCategories(int PartCategoryID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _PartCategoryID = PartCategoryID;
        }

        private void _SetIntialData()
        {
            if (_Mode == enMode.AddNew)
            {
                this.Text = "Add New Part Category";
                lblTitle.Text = "Add New Part Category";
                lblCategoryID.Text = "[???]";
                txtCategoryName.Clear();

            }
            else
            {
                this.Text = "Update Part Category Info";
                lblTitle.Text = "Update Part Category Info";
            }
       
        }

        private void _LoadDataToUpdate()
        {
            _PartCategory = clsPartCategory.FindPartCategory(_PartCategoryID);

            if (_PartCategory == null)
            {
                MessageBox.Show($"Can not find category with id={_PartCategoryID}", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblCategoryID.Text = _PartCategory.PartCategoryID.ToString();
            txtCategoryName.Text = _PartCategory.PartCategoryName;
            txtCategoryName.SelectionStart = txtCategoryName.Text.Length;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditPartCategories_Activated(object sender, EventArgs e)
        {
            txtCategoryName.Focus();
        }

        private void frmAddEditPartCategories_Load(object sender, EventArgs e)
        {
            _SetIntialData();

            if (_Mode == enMode.Update)
                _LoadDataToUpdate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!txtCategoryName.IsValid()) return;

            int? CategoryID = clsPartCategory.GetPartCategoryIDByName(txtCategoryName.Text.Trim());
            if (CategoryID != null)
            {
                MessageBox.Show($"This category already exists with id = {CategoryID}", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }


            if (MessageBox.Show("Are you sure you want to save part category data?", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.Cancel) return;


            _PartCategory.PartCategoryName = txtCategoryName.Text;

            if (_PartCategory.Save())
            {
                MessageBox.Show($"Data Saved Successfully", "Saved", MessageBoxButtons.OK,
                  MessageBoxIcon.Information);

                _Mode = enMode.Update;
                lblCategoryID.Text = _PartCategory.PartCategoryID.ToString();
                _SetIntialData();
            }
            else
            {
                MessageBox.Show("Failed to save brand data.", "An error occurred", MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
        }
    }


}
