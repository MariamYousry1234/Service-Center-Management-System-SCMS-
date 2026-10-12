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
    public partial class ucSearchForAModel : UserControl
    {
        public ucSearchForAModel()
        {
            InitializeComponent();

            
        }

        private async Task  _LoadBrandNames()
        {
            DataTable dt =  await clsBrand.GetAllBrandNamesAsync();

            foreach (DataRow Row in dt.Rows)
            {
                cbBrands.Items.Add(Row["BrandName"].ToString());
            }

            cbBrands.SelectedIndex = 0;

        }
        public void txtFocus()
        {
            txtModel.Focus();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!txtModel.IsValid()) return;

            int BrandID=clsBrand.FindBrand(cbBrands.SelectedItem.ToString()).BrandID;


            ucShowModelInfo1.LoadModelInfo(BrandID,txtModel.Text.Trim());

        }

        private void txtModel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnSearch.PerformClick();
        }

        private  async void _LoadBrandNames(object sender, EventArgs e)
        {
            if (!DesignMode)
                await _LoadBrandNames();
        }
    }
}
