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
    public partial class ucShowUserInfo : UserControl
    {
        clsUser _User;
        int? _UserID = null;
        public ucShowUserInfo()
        {
            InitializeComponent();
        }

        public clsUser UserInfo
        {
            get { 
                return _User;
            }
        }

        public int? UserID
        {
            get { 
                return _UserID;
            }
        }
        private void _SetDefaultDate()
        {
            lblUserID.Text = "[???]";
            lblUsername.Text= "[???]";
            lblEmployeeID.Text= "[???]";
            lblIsActive.Text= "[???]";
            lblCreatedDate.Text= "[???]";
            lblFullName.Text = "[???]";
            lblGender.Text = "[???]";
        }

        private void _LoadDate()
        {
            _UserID = _User.UserID;
            lblUserID.Text = _User.UserID.ToString();
            lblUsername.Text = _User.Username;
            lblEmployeeID.Text = _User.EmployeeID.ToString();
            lblIsActive.Text = _User.IsActive ? "Yes" : "No";
            lblCreatedDate.Text = _User.CreatedDate.ToString("dd/MM/yyyy");
            lblFullName.Text = _User.EmployeeInfo.FullName;
            lblGender.Text = _User.EmployeeInfo.Gender == clPerson.enGender.Male ? "Male" : "Female";
        }
        public void LoadUserInfo(int UserID)
        {
           _User= clsUser.FindUser(UserID);

            if(_User == null)
            {
                _UserID = null;
                _SetDefaultDate();
                MessageBox.Show($"User with id= {UserID} Not found!", "Not found", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            _LoadDate();
        }


        public void LoadUserInfoByUsername(string Username)
        {
            _User = clsUser.FindUserByUsername(Username);

            if (_User == null)
            {
                _UserID = null;
                _SetDefaultDate();
               MessageBox.Show($"User with username= {Username} Not found!", "Not found", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            _LoadDate();
        }
    }
}
