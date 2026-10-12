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
    public partial class ucSearchForSparePart : UserControl
    {
        public ucSearchForSparePart()
        {
            InitializeComponent();

            cbField.SelectedIndex = 0;
        }

        public int? SparePartID
        {
            get
            {
                return ucShowSparePartDetails1.SparePartID;
            }
        }

        public clsSparePart SparePart
        {
            get
            {
                return ucShowSparePartDetails1.SparePartInfo;
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

        public void LoadPartData(int SparePartID)
        {
            txtSearch.Text = SparePartID.ToString();
            cbField.SelectedIndex = 0;
            ucShowSparePartDetails1.LoadSparePartInfo(SparePartID);
        }
        private void cbField_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtSearch.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!txtSearch.IsValid()) return;

            switch (cbField.SelectedItem.ToString())
            {
                case "Part ID":
                    {
                        ucShowSparePartDetails1.LoadSparePartInfo(Convert.ToInt32(txtSearch.Text.Trim()));
                    }
                    break;
                case "Part Name":
                    {
                        ucShowSparePartDetails1.LoadSparePartInfo(txtSearch.Text);

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
