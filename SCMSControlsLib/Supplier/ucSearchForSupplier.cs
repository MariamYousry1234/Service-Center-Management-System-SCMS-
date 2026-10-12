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
    public partial class ucSearchForSupplier : UserControl
    {
        public ucSearchForSupplier()
        {
            InitializeComponent();

            cbField.SelectedIndex = 0;
        }

        public clsSupplier Supplier
        {
            get
            {
                return ucShowSupplierInfo1.Supplier;
            }
        }
        public int? SupplierID
        {
            get
            {
                return ucShowSupplierInfo1.SupplierID;
            }
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

        private void cbField_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtSearch.Focus();
            
            if(cbField.SelectedItem.ToString() == "Phone Number")
            {
                txtSearch.Length = 11;
                txtSearch.WritingType = cusTextBox.enWritingType.Numbers;
            }
            else
            {
                txtSearch.Length = null;
                txtSearch.WritingType = cusTextBox.enWritingType.None;
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!txtSearch.IsValid()) return;

            switch (cbField.SelectedItem.ToString())
            {
                case "Supplier ID":
                    {
                        ucShowSupplierInfo1.LoadSupplierInfo(Convert.ToInt32(txtSearch.Text.Trim()));
                    }
                    break;

                case "Supplier Name":
                    {
                        ucShowSupplierInfo1.LoadSupplierInfo(txtSearch.Text);
                    }
                    break;
                case "Phone Number":
                    {
                        ucShowSupplierInfo1.LoadSupplierInfoByPhoneNumber(txtSearch.Text);

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
