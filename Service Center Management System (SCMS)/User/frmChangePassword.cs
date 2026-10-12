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
    public partial class frmChangePassword : Form
    {
        int _UserID;
        clsUser _User = clsGlobal.CurrentUser;
        public frmChangePassword(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!txtOldPassword.IsValid() || !txtNewPassword.IsValid() ||
                !txtConfirmPassword.IsValid()) return;

           if(txtNewPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                errorProvider1.SetError(txtConfirmPassword,
              "Password confirmation does not match the password.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }


     
            if(!_User.UpdatePassword(txtNewPassword.Text.Trim()))
            {
                MessageBox.Show("Failed to save user data.", "An error occurred", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);     
            }
            else
            {
                MessageBox.Show($"Data Saved Successfull", "Saved", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            ucShowUserInfo1.LoadUserInfo(_UserID);

            txtOldPassword.Text = clsGlobal.CurrentUser.Password;
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";

            txtNewPassword.Focus();
        }

       
    }
}
