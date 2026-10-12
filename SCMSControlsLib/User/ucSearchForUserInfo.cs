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

        private void cbField_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtSearch.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
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
    }
}
