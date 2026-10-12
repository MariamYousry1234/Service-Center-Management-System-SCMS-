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
    public partial class frmAddEditSupplier : Form
    {
        enum enMode { AddNew = 0, Update = 1 }

        enMode _Mode = enMode.AddNew;


        clsSupplier _Supplier;
        int _SupplierID;

        public frmAddEditSupplier()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
            _Supplier = new clsSupplier();
        }

        public frmAddEditSupplier(int SupplierID)
        {
            InitializeComponent();

            _Mode = enMode.Update;

            _SupplierID = SupplierID;
        }

        private void  _LoadIntailData()
        {

            if (_Mode == enMode.AddNew)
            {
                this.Text = "Add New Supplier";
                lblTitle.Text = "Add New Supplier";
                gbInfo.Text = "Add New Supplier";

                lblSupplierID.Text = "[???]";
                txtSupplierName.Clear();
                txtSupplierName.Focus();
                txtPhoneNumber.Clear();
                txtAddress.Clear();
                chkIsActive.Checked = true;
            }
            else
            {
                this.Text = "Update Supplier Info";
                lblTitle.Text = "Update Supplier Info";
                gbInfo.Text = "Update Supplier Info";
            }

         

        }

        private void _LoadDataToUpdate()
        {
            _Supplier = clsSupplier.FindSupplier(_SupplierID);

            if (_Supplier == null)
            {
                MessageBox.Show($"Can not found supplier with id ={_SupplierID}");
                this.Close();
                return;
            }

            lblSupplierID.Text = _Supplier.SupplierID.ToString();
            txtSupplierName.Text = _Supplier.SupplierName;
            txtPhoneNumber.Text = _Supplier.PhoneNumber;
            txtAddress.Text = _Supplier.Address ?? "";
            chkIsActive.Checked = _Supplier.IsActive;

        }

        private void frmAddEditSupplier_Load(object sender, EventArgs e)
        {
            _LoadIntailData();


            if (_Mode == enMode.Update)
                _LoadDataToUpdate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!txtSupplierName.IsValid() &&
                !txtPhoneNumber.IsValid()) return;

            if(_Mode==enMode.AddNew && clsSupplier.IsSupplierExists(txtSupplierName.Text))
            {
                MessageBox.Show("Supplier name already exists", "Not allowed", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }


            if (MessageBox.Show("Are you sure you want to save supplier date?", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.Cancel) return;


            _Supplier.SupplierName = txtSupplierName.Text;
            _Supplier.PhoneNumber = txtPhoneNumber.Text;
            _Supplier.Address = string.IsNullOrEmpty(txtAddress.Text) ? null : txtAddress.Text;
            
            if(_Supplier.Save())
            {
                MessageBox.Show($"Data Saved Successfull",
                 "Saved", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);

                _Mode = enMode.Update;

                this.Text = "Update Supplier Info";
                lblTitle.Text = "Update Supplier Info";
                gbInfo.Text = "Update Supplier Info";

                _SupplierID = _Supplier.SupplierID;
                lblSupplierID.Text = _SupplierID.ToString();
            }
            else
            {
                MessageBox.Show("Failed to save supplier data.", "An error occurred", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
