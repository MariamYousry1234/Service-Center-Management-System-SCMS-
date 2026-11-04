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
        clsBrand _BrandInfo;

        int? _BrandID;
        public ucShowAllModelsForBrand()
        {
            InitializeComponent();
        }

        public async void LoadAllModels(int BrandID)
        {
            _BrandInfo = clsBrand.FindBrand(BrandID);

            if(_BrandInfo ==null)
            {

                MessageBox.Show("Brand information was not found.", "Brand Not Found",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);


                gbAllModels.Text = "All Models For Brand = [???]";
                _BrandID = null;
                return;
            }

            _BrandID = BrandID;
            string BrandName =_BrandInfo.BrandName;

            gbAllModels.Text = $"All Models For Brand = {BrandName}";
            dgvAllModels.DataSource = await clsModel.GetModelsForBrandAsync(BrandID);

            lblNumberOfModels.Text = dgvAllModels.Rows.Count.ToString();

            if (dgvAllModels.Rows.Count>0)
            {
                dgvAllModels.Columns[1].Width = 250;
                dgvAllModels.Columns[2].Width =250;
            }
        }

        private void deleteModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ModelID =(int)dgvAllModels.CurrentRow.Cells[0].Value;

            if (MessageBox.Show($"Are you sure you want to delete model with id = {ModelID} ?",
                 "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                 == DialogResult.Cancel) return;


           if( clsModel.DeleteModel(ModelID))
            {
                MessageBox.Show("Model deleted successfully.", "Success",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAllModels(_BrandID.Value);
            }
            else
            {
                MessageBox.Show("Failed to delete the model.", "Delete Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
   
            }


        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            contextMenuStrip1.Enabled =
                dgvAllModels.CurrentRow != null;
        }
    }
}
