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
    public partial class frmAddEditUser : Form
    {
        enum enMode { AddNew=0,Update=1}
        enMode _Mode = enMode.AddNew;

        int? _EmployeeID;
        int _UserID;
        clsUser _User;
        public frmAddEditUser()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
            _User = new clsUser();
            _EmployeeID = null;
        }
        public frmAddEditUser(int UserID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _UserID = UserID;
        }



        private void btnSelectingEmployee_Click(object sender, EventArgs e)
        {
            frmSelectEmployee frm = new frmSelectEmployee();

            frm.EmployeeID += (int? EmployeeID) =>
            {
                _EmployeeID = EmployeeID;

                lblEmployeeID.Text = $"[ {_EmployeeID.ToString()} ]";
            };

            frm.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(_EmployeeID == null)
            {
                MessageBox.Show("No employee selected", "Not valid", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (_Mode == enMode.AddNew)
            {
                bool IsActive = clsEmployee.FindEmployee(_EmployeeID.Value).IsActive;

                if (!IsActive)
                {
                    MessageBox.Show($"Employee with id = {_EmployeeID.Value} is inactive",
                        "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
            }

            if (!txtUsername.IsValid() ||
                !txtPassword.IsValid() ||
                !txtConfirmPassword.IsValid()) return;

            if (txtUsername.Text.Trim() != _User.Username &&
                clsUser.IsUsernameExists(txtUsername.Text.Trim()))
            
            {
                MessageBox.Show("Username already exists ,Choose another username", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }

            if(txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                errorProvider1.SetError(txtConfirmPassword,
                    "Password confirmation does not match the password.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword,null);
            }



            if (MessageBox.Show("Are you sure you want to save user data?", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.Cancel) return;


            _User.EmployeeID =(int) _EmployeeID;
            _User.Username = txtUsername.Text.Trim();
            _User.Password = txtPassword.Text;
            _User.Permissions = null;
       

            if(_User.Save())
            {
                MessageBox.Show("Data saved successfully", "Saved", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                lblUserID.Text = _User.UserID.ToString();
                _Mode = enMode.Update;
                _SetIntialInfo();
            }
            else
            {
                MessageBox.Show("Failed to save the changes.", "Failed", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _SetIntialInfo()
        {
            btnSelectingEmployee.Focus();
            if (_Mode==enMode.AddNew)
            {
                this.Text = "Add New User";
                lblTitle.Text = "Add New User";
                lblUserID.Text = "[???]";
                lblEmployeeID.Text= "[???]";
                lblCreatedDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }
            else
            {
                this.Text = "Edit User Info";
                lblTitle.Text = "Edit User Info";
            }
        }

        public void _LoadDataToUpdate()
        {
            _User = clsUser.FindUser(_UserID);

            if(_User==null)
            {
                MessageBox.Show($"User with id={_UserID} Not found!", "Not found", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Close();
                return;
            }


            _EmployeeID = _User.EmployeeID;
            lblUserID.Text = _User.UserID.ToString();
            lblEmployeeID.Text = _User.EmployeeID.ToString();
            txtUsername.Text = _User.Username;
            txtPassword.Text = _User.Password;
            txtConfirmPassword.Text = _User.Password;
            chbIsActive.Checked = _User.IsActive;
            lblCreatedDate.Text = _User.CreatedDate.ToString("dd//MM/yyyy");

        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            _SetIntialInfo();

            if (_Mode == enMode.Update)
                _LoadDataToUpdate();

        }
    }
}
