using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using SCMS_Business_Logic;

namespace SCMSControlsLib
{
    public partial class ucPersonalInfo : UserControl
    {
        
        public ucPersonalInfo()
        {
            InitializeComponent();
        }

       public struct stPersonalInfo
        {


            public string FirstName;

            public string SecondName;

            public string? ThirdName;

            public string? LastName;


            public clPerson.enGender Gender;

        
            public string PhoneNumber { set; get; }

            public string? Email { set; get; }

            public string Address { set; get; }

        }

        public bool gbEnabled
        {
            set
            {
                gbInfo.Enabled = value;
            }
            get
            {
                return gbInfo.Enabled;
            }
        }
        public void LoadInfo(
            string FirstName,
           string SecondName,
           string? ThirdName,
           string? LastName,
          clPerson.enGender Gender,
         string PhoneNumber,
          string? Email,
            string Address)
        {
            txtFirstName.Text =FirstName;
            txtSecondName.Text =SecondName;
            txtThirdName.Text =ThirdName ?? "";
            txtLastName.Text = LastName ?? "";
            rbMale.Checked = (Gender == clPerson.enGender.Male);
            rbFemale.Checked = (Gender == clPerson.enGender.Female);
            txtPhoneNumber.Text = PhoneNumber;
            txtAddress.Text = Address;
            txtEmail.Text = Email;
        }
    
   
        public void txtFocus()
        {
            txtFirstName.Focus();
        }
        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            pbImage.Image = rbMale.Checked ?
                Properties.Resources.man:
                Properties.Resources.woman;
                  
        }

        public stPersonalInfo? GetFinalInfo()
        {
            if (!txtFirstName.IsValid() || !txtSecondName.IsValid() || !txtPhoneNumber.IsValid()
                || !txtAddress.IsValid()) return null;

            stPersonalInfo _PersonalInfo = new stPersonalInfo();
            _PersonalInfo.FirstName = txtFirstName.Text;
            _PersonalInfo.SecondName = txtSecondName.Text;
            _PersonalInfo.ThirdName = string.IsNullOrEmpty(txtThirdName.Text) ? null : txtThirdName.Text;
            _PersonalInfo.LastName = string.IsNullOrEmpty(txtLastName.Text) ? null : txtLastName.Text;
            _PersonalInfo.Gender = rbMale.Checked ? clPerson.enGender.Male : clPerson.enGender.Female;
            _PersonalInfo.PhoneNumber = txtPhoneNumber.Text;
            _PersonalInfo.Email= string.IsNullOrEmpty(txtEmail.Text) ? null : txtEmail.Text;
            _PersonalInfo.Address = txtAddress.Text;

            return _PersonalInfo;
        }
    }
}
