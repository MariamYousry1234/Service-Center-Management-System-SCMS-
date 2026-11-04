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
    public partial class ucSearchForABrand : UserControl
    {
        public ucSearchForABrand()
        {
            InitializeComponent();

            cbField.SelectedIndex = 0;
        }

        private void cbField_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtSearch.Focus();
        }

        public void txtFocus()
        {
            txtSearch.Focus();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!txtSearch.IsValid()) return;

            switch (cbField.SelectedItem.ToString())
            {
                case "Brand ID":
                    {
                        ucShowBrandInfo1.LoadBrandInfo(Convert.ToInt32(txtSearch.Text));
                    }
                    break;
                case "Brand Name":
                    {
                        ucShowBrandInfo1.LoadBrandInfo(txtSearch.Text);
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
