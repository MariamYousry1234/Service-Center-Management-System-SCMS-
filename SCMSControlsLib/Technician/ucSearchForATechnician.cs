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
    public partial class ucSearchForATechnician : UserControl
    {
        public Func<int?, int?> TechnicianSaved;
        public ucSearchForATechnician()
        {
            InitializeComponent();
            cbField.SelectedIndex = 0;
        }

        public bool AddEditVisible
        {
            set
            {
                btnAddEdit.Visible = value;

                if (btnAddEdit.Visible)
                    btnAddEdit.Image = Properties.Resources.plus;
            }
        }

        public bool gbEnabeld
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
        public int? TechnicianID
        {
            get
            {
                return ucShowTechnicianInfo1.TechnicianID;
            }
        }

        public clsTechnician TechnicianInfo
        {
            get
            {
                return ucShowTechnicianInfo1.TechnicianInfo; ;
            }
        }

        //update case
        public void LoadTechnicianInfo(int? TechnicianID = null)
        {
            cbField.SelectedIndex = 0;

            if (TechnicianID == null)
            {
                btnAddEdit.Image = Properties.Resources.plus;
            }
            else
            {
                btnAddEdit.Image = Properties.Resources.pen;
                txtSearch.Text = TechnicianID.ToString();
                ucShowTechnicianInfo1.LoadTechnicianInfo(TechnicianID.Value);
                gbSearch.Enabled = false;
            }
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
                case "Technician ID":
                    {
                       ucShowTechnicianInfo1.LoadTechnicianInfo(Convert.ToInt32(txtSearch.Text));
                    }
                    break;
                case "Employee ID":
                    {
                        ucShowTechnicianInfo1.LoadTechnicianInfoByEmployeeID(Convert.ToInt32(txtSearch.Text));
                    }
                    break;

                case "Phone Number":
                    {
                        ucShowTechnicianInfo1.LoadTechnicianInfoByPhoneNumber(txtSearch.Text);
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
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            int? TechnicianID = TechnicianSaved?.Invoke(ucShowTechnicianInfo1.TechnicianID);

            if (TechnicianID.HasValue)
            {
                txtSearch.Text = TechnicianID.ToString();
                ucShowTechnicianInfo1.LoadTechnicianInfo(TechnicianID.Value);
            }
               
        }
    }
}
