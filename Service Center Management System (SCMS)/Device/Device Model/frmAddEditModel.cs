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
    public partial class frmAddEditModel : Form
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode = enMode.AddNew;

        clsModel _Model;
        int _ModelID;
        public frmAddEditModel()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
            _Model = new clsModel();
        }

        public frmAddEditModel(int ModelID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _ModelID = ModelID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void _LoadBrandNames()
        {
            DataTable dt = await clsBrand.GetAllBrandNamesAsync();

            foreach(DataRow Row in dt.Rows)
            {
                cbBrands.Items.Add(Row["BrandName"].ToString());
            }

            cbBrands.SelectedIndex = 0;

        }
        private void _SetIntialData()
        {
            _LoadBrandNames();

            if (_Mode == enMode.AddNew)
            {
                this.Text = "Add New Model";
                lblTitle.Text = "Add New Model";
                lblModelID.Text = "[???]";
                txtModelName.Clear();
            }
            else
            {
                this.Text = "Update Model Info";
                lblTitle.Text = "Update Model Info";
            }
            txtModelName.Focus();
        }

        private void _LoadDataToUpdate()
        {
            _Model = clsModel.FindModel(_ModelID);

            if (_Model == null)
            {
                MessageBox.Show($"Can not find model with id={_ModelID}", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblModelID.Text = _Model.ModelID.ToString();
            cbBrands.SelectedItem = _Model.BrandInfo.BrandName;
            txtModelName.Text = _Model.ModelName;
            txtModelName.SelectionStart = txtModelName.Text.Length;
        }

        private void frmAddEditModel_Load(object sender, EventArgs e)
        {
            _SetIntialData();

            if (_Mode == enMode.Update)
                _LoadDataToUpdate();
        }

        private void frmAddEditModel_Activated(object sender, EventArgs e)
        {
            txtModelName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!txtModelName.IsValid()) return;

            int BrandID = clsBrand.FindBrand(cbBrands.SelectedItem.ToString()).BrandID;

            clsModel Model = clsModel.FindModel(BrandID, txtModelName.Text.Trim());

            if (Model != null)
            {
                MessageBox.Show($"This model already exists for this brand with id = {Model.ModelID} ",
                    "", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            _Model.BrandID = BrandID;
            _Model.ModelName = txtModelName.Text.Trim();

            if (_Model.Save())
            {
                MessageBox.Show($"Data Saved Successfully", "Saved", MessageBoxButtons.OK,
                  MessageBoxIcon.Information);

                _Mode = enMode.Update;
                lblModelID.Text = _Model.ModelID.ToString();
                this.Text = "Update Model Info";
                lblTitle.Text = "Update Model Info";
            }
            else
            {
                MessageBox.Show("Failed to save model data.", "An error occurred", MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
        }
    }
}
