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
    public partial class ucShowSparePartDetails : UserControl
    {
        clsSparePart _SparePart;
        int? PartID;
        public ucShowSparePartDetails()
        {
            InitializeComponent();
        }

        public clsSparePart SparePartInfo
        {
            get
            {
                return _SparePart;
            }
        }

        public int? SparePartID
        {
            get
            {
                return PartID;
            }
        }
        private void _SetIntialData()
        {
            PartID = null;
            gbInfo.Text = "Information For Spare Part ID = [???]";
            lblPartName.Text = "[???]";
            lblPartBrand.Text = "[???]";
            lblPartCategory.Text = "[???]";
            lblSellingPrice.Text = "[???]";
            lblQuantity.Text = "[???]";
            lblMSLevel.Text = "[???]";
            lblIsActive.Text = "[???]";
            lblUserCreated.Text = "[???]";
            lblCreatedDate.Text = "[???]";
            lblLastUpdatedDate.Text = "[???]";
            lblLUUser.Text = "[???]";
        }
        private void _LoadSparePartInfo()
        {
            PartID = _SparePart.PartID;
            gbInfo.Text = $"Information For Spare Part ID ={_SparePart.PartID}";
            lblPartName.Text = _SparePart.PartName;
            lblPartBrand.Text = _SparePart.PartBrandInfo.PartBrandName;
            lblPartCategory.Text = _SparePart.PartCategoryInfo.PartCategoryName;
            lblSellingPrice.Text = _SparePart.SellingPrice.ToString();
            lblQuantity.Text = _SparePart.Quantity.ToString();
            lblMSLevel.Text = _SparePart.MinimumStockLevel.ToString();
            lblIsActive.Text =_SparePart.IsActive?"YES": "NO";
            lblUserCreated.Text = _SparePart.CreatedUserInfo.Username;
            lblCreatedDate.Text = _SparePart.CreatedDate.ToString("dd/MM/yyyy");
            lblLastUpdatedDate.Text = _SparePart.LastUpdatedDate?.ToString("dd/MM/yyyy")??"Un Known";
            lblLUUser.Text = _SparePart.LastUpdatedUserInfo?.Username??"Un Known";

        }
        public void LoadSparePartInfo(int SpartPartID)
        {
            _SparePart = clsSparePart.FindSparePart(SpartPartID);

            if(_SparePart==null)
            {
                MessageBox.Show($"Spare part with id = {SpartPartID} Not found!", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                _SetIntialData();
                return;
            }
            _LoadSparePartInfo();
        }

        public void LoadSparePartInfo(string SpartPartName)
        {
            _SparePart = clsSparePart.FindSparePart(SpartPartName);

            if (_SparePart == null)
            {
                MessageBox.Show($"Spare part with name= {SpartPartName} Not found!", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                _SetIntialData();
                return;
            }
            _LoadSparePartInfo();
        }

    }
}
