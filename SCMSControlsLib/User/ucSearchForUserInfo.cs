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
    public partial class ucSearchForUserInfo : UserControl
    {
        public ucSearchForUserInfo()
        {
            InitializeComponent();

            cbField.SelectedIndex = 0;
        }

        public void txtFocus()
        {
            txtSearch.Focus();
        }
        private void cbField_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.WritingType = cbField.Text == "Username" ? cusTextBox.enWritingType.Text :
                cusTextBox.enWritingType.Numbers;

            txtSearch.Clear();
            txtSearch.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!txtSearch.IsValid()) return;

            switch(cbField.SelectedItem.ToString())
            {
                case "User ID":
                    {
                        ucShowUserInfo1.LoadUserInfo(Convert.ToInt32(txtSearch.Text.Trim()));
                    }
                    break;

                case "Username":
                    {
                        ucShowUserInfo1.LoadUserInfoByUsername(txtSearch.Text.Trim());
                    }
                    break;
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnSearch.PerformClick();
        }
    }
}
