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
    public partial class ucSearchForDeviceType : UserControl
    {
        public ucSearchForDeviceType()
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

            switch(cbField.SelectedItem.ToString())
            {
                case "Device Type ID":
                    {
                        ucShowDeviceTypeInfo1.LoadDeviceTypeInfo(Convert.ToInt32(txtSearch.Text));
                    }
                    break;
                case "Device Type Name":
                    {
                        ucShowDeviceTypeInfo1.LoadDeviceTypeInfo(txtSearch.Text);
                    }
                    break;
            }

            txtSearch.Focus();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnSearch.PerformClick();
               
         

        }
    }
}
