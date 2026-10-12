using SCMS_Business_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service_Center_Management_System__SCMS_
{
    public partial class frmManageSpareParts : Form
    {
        private int TotalPages = 1;
        private int CurrentPage = 1;
        private int NumberOfRowsEachPage = Convert.ToInt32(ConfigurationManager.AppSettings["NumberOfRowsEachPage"]);


        public frmManageSpareParts()
        {
            InitializeComponent();
        }


        private async Task _LoadDataAsync()
        {
            DataTable Data = await clsSparePart.GetSparePartsAsync(NumberOfRowsEachPage, CurrentPage);
            dgvData.DataSource = Data;
            lblPageNumber.Text = CurrentPage.ToString();

            if (dgvData.Rows.Count > 0)
            {
                dgvData.Columns[1].Width = 180;
                dgvData.Columns[2].Width = 180;
                dgvData.Columns[3].Width = 180;

            }
        }

        private async void frmManageSpareParts_Load(object sender, EventArgs e)
        {
            btnPrevious.Enabled = false;
            CurrentPage = 1;

            TotalPages = await clsSparePart.GetSparePartsNumberOfPagesAsync(NumberOfRowsEachPage);
            lblTotalPages.Text = TotalPages.ToString();


            if (TotalPages == 0 || TotalPages == 1)
            {
                lblTotalPages.Text = "1";
                lblPageNumber.Text = "1";
                btnNext.Enabled = false;
            }
            else
                btnNext.Enabled = true;

            await _LoadDataAsync();
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            if (++CurrentPage <= TotalPages)
            {
                btnPrevious.Enabled = true;

                await _LoadDataAsync();

                //Is last page?
                if (CurrentPage == TotalPages)
                    btnNext.Enabled = false;
            }
        }

        private async void btnPrevious_Click(object sender, EventArgs e)
        {
            if (--CurrentPage >= 1)
            {
                btnNext.Enabled = true;

                await _LoadDataAsync();


                if (CurrentPage == 1)
                    btnPrevious.Enabled = false;
            }
        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {        
            if(dgvData.CurrentRow ==null)
            {
                guna2ContextMenuStrip1.Enabled = false;
                return;
            }

            guna2ContextMenuStrip1.Enabled = true;

            decativateToolStripMenuItem.Text=
                (bool)dgvData.CurrentRow.Cells["IsActive"].Value? "Deactivate":"Activate";

            purchaseToolStripMenuItem.Enabled = 
                (bool)dgvData.CurrentRow.Cells["IsActive"].Value;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditSparePart frm = new frmAddEditSparePart();

            frm.ShowDialog();

            frmManageSpareParts_Load(null, null);

        }

        private void decativateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show($"Are you sure you want to {decativateToolStripMenuItem.Text} this spare part",
                 "Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)
                ==DialogResult.Cancel)return;

            clsSparePart CurrentSparePart =
                clsSparePart.FindSparePart((int)dgvData.CurrentRow.Cells[0].Value);

            if(CurrentSparePart.IsActive)
            {
                if(CurrentSparePart.Deactivate())
                {
                    MessageBox.Show("Spare part deactivated successfully", "", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    frmManageSpareParts_Load(null, null);
                    return;
                }
                
            }
            else
            {
                if (CurrentSparePart.Activate())
                {
                    MessageBox.Show("Spare part activated successfully", "", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    frmManageSpareParts_Load(null, null);
                    return;
                }
            }

            MessageBox.Show("An Error occured", "", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);

        }

        private void updateInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditSparePart frm = new frmAddEditSparePart((int)dgvData.CurrentRow.Cells[0].Value);

            frm.ShowDialog();

            frmManageSpareParts_Load(null, null);
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowSparePartDetails frm =
                new frmShowSparePartDetails((int)dgvData.CurrentRow.Cells[0].Value);

            frm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearchForSparePart frm = new frmSearchForSparePart();

            frm.ShowDialog();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreateSparePartPurchase frm =
                new frmCreateSparePartPurchase((int)dgvData.CurrentRow.Cells[0].Value);


            frm.ShowDialog();

            frmManageSpareParts_Load(null, null);
        }

        private void showAllPuchaseOperationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowAllPreviousPuchaseOperationsForPart frm = 
                new frmShowAllPreviousPuchaseOperationsForPart((int)dgvData.CurrentRow.Cells[0].Value);


            frm.ShowDialog();
        }
    }
}
