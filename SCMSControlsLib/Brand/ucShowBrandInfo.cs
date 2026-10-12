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
    public partial class ucShowBrandInfo : UserControl
    {
        clsBrand _Brand;
        public ucShowBrandInfo()
        {
            InitializeComponent();
        }


        private void _SetIntialData()
        {
            lblBrandID.Text = "[???]";
            lblBrandName.Text = "[???]";
        }
        private void _LoadData()
        {
            lblBrandID.Text = _Brand.BrandID.ToString();
            lblBrandName.Text = _Brand.BrandName;
        }
        public void LoadBrandInfo(int BrandID)
        {
            _Brand = clsBrand.FindBrand(BrandID);

            if (_Brand == null)
            {
                MessageBox.Show($"Brand with id={BrandID} Not found!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                _SetIntialData();
                return;
            }
            _LoadData();

        }

        public void LoadBrandInfo(string BrandName)
        {
            _Brand = clsBrand.FindBrand(BrandName);

            if (_Brand == null)
            {
                MessageBox.Show($"Brand with Name={BrandName} Not found!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                _SetIntialData();
                return;
            }
            _LoadData();

        
         }
    }
}
