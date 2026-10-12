using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCMS_Business_Logic;

namespace SCMSControlsLib
{
    public partial class ucShowPersonInfo: UserControl
    {
        
        public ucShowPersonInfo()
        {
            InitializeComponent();
        }


      

        public void SetDefaultData()
        {
            lblFullName.Text ="[???]";
            lblPhone.Text = "[???]";
            lblEmail.Text = "[???]";
            lblAddress.Text = "[???]";
            lblGender.Text = "[???]";
            pbImage.Image = Properties.Resources.man;          
        }
       

        public void LoadPersonInfo(
           string FullName,
          string Gender,
         string PhoneNumber,
          string? Email,
            string Address)
        {

        
            lblFullName.Text =FullName;
            lblPhone.Text = PhoneNumber;
            lblEmail.Text = Email ?? "Not found";
            lblAddress.Text = Address ;
            lblGender.Text = Gender;
            pbImage.Image = Gender == "Male" ? Properties.Resources.man :
                 Properties.Resources.woman;
        }

    }
}
