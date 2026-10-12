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
    public partial class ucSearchForAnEmployee : UserControl
    {
        public ucSearchForAnEmployee()
        {
            InitializeComponent();

            cbField.SelectedIndex = 0;
                
        }

        public int? EmployeeID
        {
            get { 
                return ucShowEmployeeInfo1.EmployeeID;
            }
        }

        public clsEmployee EmployeeInfo
        {
            get
            {
                return ucShowEmployeeInfo1.EmployeeInfo;
            }
        }
        public void txtFocus()
        {
            txtSearch.Focus();
        }

        public bool gbEnabled
        {
            set
            {
                gbSearch.Enabled = value;
            }
            get
            {
                return gbSearch.Enabled;
            }
        }
        public void LoadEmployeeInfo(int EmployeeID)
        {
            cbField.SelectedIndex = 0;
            ucShowEmployeeInfo1.LoadEmployeeInfo(EmployeeID);
            txtSearch.Text = EmployeeID.ToString();
        }
        private void cbField_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtSearch.Focus();
            txtSearch.Length = cbField.SelectedItem.ToString() == "Phone Number" ? 11 :(int?) null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!txtSearch.IsValid()) return;

            switch(cbField.SelectedItem.ToString())
            {
                case "Employee ID":
                    {
                        ucShowEmployeeInfo1.LoadEmployeeInfo(Convert.ToInt32(txtSearch.Text));
                    }
                    break;

                case "Phone Number":
                    {
                        ucShowEmployeeInfo1.LoadEmployeeInfoByPhoneNumber(txtSearch.Text);
                    }
                    break;

            }
            txtSearch.Focus();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch.PerformClick();
                return;
            }

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
