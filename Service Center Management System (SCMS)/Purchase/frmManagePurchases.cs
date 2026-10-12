using SCMS_Business_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service_Center_Management_System__SCMS_
{
    public partial class frmManagePurchases : Form
    {
        private int TotalPages = 1;
        private int CurrentPage = 1;
        private int NumberOfRowsEachPage = Convert.ToInt32(ConfigurationManager.AppSettings["NumberOfRowsEachPage"]);
       
        public frmManagePurchases()
        {
            InitializeComponent();
        }
        private async Task _LoadDataAsync()
        {
            DataTable Data = await clsPurchase.GetPurchasesAsync(NumberOfRowsEachPage, CurrentPage);
            dgvData.DataSource = Data;
            lblPageNumber.Text = CurrentPage.ToString();

            if (dgvData.Rows.Count > 0)
            {
                dgvData.Columns[1].Width = 180;
                dgvData.Columns[2].Width = 150;
                dgvData.Columns[5].Width = 200;

            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCreateSparePartPurchase frm = new frmCreateSparePartPurchase();

            frm.ShowDialog();
        }

        private async void frmManagePurchases_Load(object sender, EventArgs e)
        {
            btnPrevious.Enabled = false;
            CurrentPage = 1;

            TotalPages = await clsPurchase.GetPurchasesNumberOfPagesAsync(NumberOfRowsEachPage);
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

            cancelToolStripMenuItem.Enabled =
                !(bool)dgvData.CurrentRow.Cells["IsCancelled"].Value;

        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PurchaseID = (int)dgvData.CurrentRow.Cells[0].Value;

            if (MessageBox.Show($"Are you sure you want to cancel this purchase with id = {PurchaseID}",
                "confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.Cancel) return;


            clsPurchase PurchaseInfo = clsPurchase.FindPurchase(PurchaseID);

            if(PurchaseInfo.Cancel(clsGlobal.CurrentUser.UserID))
            {
                MessageBox.Show($"Purchase with id = {PurchaseID} cancelled successfully",
                    "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmManagePurchases_Load(null, null);

                return;
            }

            MessageBox.Show($"Purchase with id = {PurchaseID} could not be cancelled",
                  "Cancel Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPurchaseDetails frm =
                new frmShowPurchaseDetails((int)dgvData.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
