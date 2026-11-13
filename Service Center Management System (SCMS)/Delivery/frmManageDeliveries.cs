using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using SCMS_Business_Logic;

namespace Service_Center_Management_System__SCMS_
{
    public partial class frmManageDeliveries : Form
    {
        private int TotalPages = 1;
        private int CurrentPage = 1;
        private int NumberOfRowsEachPage = Convert.ToInt32(ConfigurationManager.AppSettings["NumberOfRowsEachPage"]);

        private DataTable _DeliveryData;
        public frmManageDeliveries()
        {
            InitializeComponent();
        }

        private async Task _LoadDeliveriesDataAsync()
        {
            _DeliveryData = await clsDelivery.GetDeliveriesAsync(NumberOfRowsEachPage, CurrentPage);
            dgvData.DataSource = _DeliveryData;
            lblPageNumber.Text = CurrentPage.ToString();

            if (dgvData.Rows.Count > 0)
            {
                dgvData.Columns[3].Width = 200;
                dgvData.Columns[4].Width = 120;
                dgvData.Columns[5].Width = 200;
                dgvData.Columns[6].Width = 200;
            }

            cbFiltering.SelectedIndex = 0;
        }

        private async void frmManageDeliveries_Load(object sender, EventArgs e)
        {
            btnPrevious.Enabled = false;
            CurrentPage = 1;

            TotalPages = await clsDelivery.GetDeliveriesNumberOfPagesAsync(NumberOfRowsEachPage);
            lblTotalPages.Text = TotalPages.ToString();


            if (TotalPages == 0 || TotalPages == 1)
            {
                lblTotalPages.Text = "1";
                lblPageNumber.Text = "1";
                btnNext.Enabled = false;
            }
            else
                btnNext.Enabled = true;


    

            await _LoadDeliveriesDataAsync();

            cbFiltering.SelectedIndex = 0;
            txtFiltering.Enabled = false;
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            if (++CurrentPage <= TotalPages)
            {
                btnPrevious.Enabled = true;

                await _LoadDeliveriesDataAsync();

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

                await _LoadDeliveriesDataAsync();


                if (CurrentPage == 1)
                    btnPrevious.Enabled = false;
            }
        }

        private void showRepairOrderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowRepairOrderDetails frm =
                new frmShowRepairOrderDetails((int)dgvData.CurrentRow.Cells[1].Value);

            frm.ShowDialog();
        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            guna2ContextMenuStrip1.Enabled = dgvData.CurrentRow != null;
        }

        private void updateInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditDelivery frm =
                new frmAddEditDelivery((int)dgvData.CurrentRow.Cells[0].Value);

            frm.ShowDialog();
        }

        private void showDeliveryInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowDeliveryInfo frm =
                new frmShowDeliveryInfo((int)dgvData.CurrentRow.Cells[0].Value);

            frm.ShowDialog();
        }

        private void cbFiltering_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltering.Clear();
            if (cbFiltering.SelectedIndex == 0)
            {
                txtFiltering.Enabled = false;

                _DeliveryData.DefaultView.RowFilter = " ";
            }
            else
            {
                txtFiltering.Enabled = true;
           
                txtFiltering.Focus();


                if (cbFiltering.Text == "Delivery ID" ||
                    cbFiltering.Text == "Repair Order ID" ||
                   cbFiltering.Text == "Customer ID")
                {
                    txtFiltering.WritingType = SCMSControlsLib.cusTextBox.enWritingType.Numbers;
                }
                else
                {
                    txtFiltering.WritingType = SCMSControlsLib.cusTextBox.enWritingType.None;
                }
            }
               
        }

        private void txtFiltering_TextChanged(object sender, EventArgs e)
        {
            if (!txtFiltering.IsValid()) return;

            if (cbFiltering.Text != "None")
            {
                if (cbFiltering.Text == "DeliveryID" ||
                   cbFiltering.Text == "RepairOrderID" ||
                  cbFiltering.Text == "CustomerID")
                {
                    if (string.IsNullOrEmpty(txtFiltering.Text))
                        _DeliveryData.DefaultView.RowFilter = "";
                    else
                        _DeliveryData.DefaultView.RowFilter = $"{cbFiltering.Text} = {txtFiltering.Text.Trim()}";

                }
                else
                {
                    _DeliveryData.DefaultView.RowFilter = $"{cbFiltering.Text} like '{txtFiltering.Text}%'";
                }
            }

    
        }
    }
}
