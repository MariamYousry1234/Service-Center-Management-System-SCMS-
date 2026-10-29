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
    public partial class ucShowAllModelsForBrand : UserControl
    {
        public ucShowAllModelsForBrand()
        {
            InitializeComponent();
        }

        public async void LoadAllModels(int BrandID)
        {
            string BrandName = clsBrand.FindBrand(BrandID).BrandName;
            gbAllModels.Text = $"All Models For Brand = {BrandName}";
            dgvAllModels.DataSource = await clsModel.GetModelsForBrandAsync(BrandID);

            lblNumberOfModels.Text = dgvAllModels.Rows.Count.ToString();

            if (dgvAllModels.Rows.Count>0)
            {
                dgvAllModels.Columns[1].Width = 250;
                dgvAllModels.Columns[2].Width =250;
            }
        }
    }
}
