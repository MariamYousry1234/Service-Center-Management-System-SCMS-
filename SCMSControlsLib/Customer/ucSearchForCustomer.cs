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
    public partial class ucSearchForCustomer : UserControl
    {
        public ucSearchForCustomer()
        {
            InitializeComponent();
            cbField.SelectedIndex = 0;
        }

        public int? CustomerID
        {
            get {

                return ucShowCustomerInfo1.CustomerID;
                
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
        public void LoadCustomerInfo(int CustomerID)
        {
            cbField.SelectedIndex = 0;           
            txtSearch.Text = CustomerID.ToString();
            ucShowCustomerInfo1.LoadCustomerInfo(CustomerID);
        }

        private void cbField_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtSearch.Focus();
            txtSearch.Length = cbField.SelectedItem.ToString() == "Phone Number" ? 11 : (int?)null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!txtSearch.IsValid()) return;

            switch (cbField.SelectedItem.ToString())
            {
                case "Customer ID":
                    {
                        ucShowCustomerInfo1.LoadCustomerInfo(Convert.ToInt32(txtSearch.Text.Trim()));
                    }
                    break;
                case "Phone Number":
                    {
                        ucShowCustomerInfo1.LoadCustomerInfoByPhoneNumber(txtSearch.Text);
                       
                    }
                    break;

            }
            txtSearch.Focus();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnSearch.PerformClick();
            
          
        }
    }
}
