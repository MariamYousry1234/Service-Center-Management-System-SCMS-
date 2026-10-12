using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service_Center_Management_System__SCMS_
{
    public partial class frmShowAllModelsForBrand : Form
    {
        int _BrandID;
        public frmShowAllModelsForBrand(int BrandID)
        {
            InitializeComponent();


            _BrandID = BrandID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowAllModelsForBrand_Load(object sender, EventArgs e)
        {
            ucShowAllModelsForBrand1.LoadAllModels(_BrandID);
        }
    }
}
