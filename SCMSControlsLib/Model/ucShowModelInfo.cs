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
    public partial class ucShowModelInfo : UserControl
    {
        clsModel _Model;

        public ucShowModelInfo()
        {
            InitializeComponent();
        }

        private void _SetIntialData()
        {
            lblModelID.Text = "???";
            lblModelName.Text = "???";
            lblBrandID.Text = "???";
            lblBrandName.Text = "???";
        }

        private void _LoadData()
        {
            lblModelID.Text = _Model.ModelID.ToString();
            lblModelName.Text = _Model.ModelName;
            lblBrandID.Text = _Model.BrandID.ToString();
            lblBrandName.Text = _Model.BrandInfo.BrandName;
        }
        public void LoadModelInfo(int ModelID)
        {
            _Model = clsModel.FindModel(ModelID);

            if(_Model == null)
            {
                _SetIntialData();
                MessageBox.Show($"This model with id= {ModelID} Not found!",
                    "Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LoadData();
        }

        public void LoadModelInfo(int BrandID,string ModelName)
        {
            _Model = clsModel.FindModel(BrandID,ModelName);

            if (_Model == null)
            {
                _SetIntialData();
                MessageBox.Show($"This model with name = {ModelName} Not found!",
                    "Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LoadData();
        }
    }
}
