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
    public partial class frmManageInvoices : Form
    {
        private int TotalPages = 1;
        private int CurrentPage = 1;
        private int NumberOfRowsEachPage = Convert.ToInt32(ConfigurationManager.AppSettings["NumberOfRowsEachPage"]);

        clsRepairOrder _CurrentRepairOrder;
      
        public frmManageInvoices()
        {
            InitializeComponent();
        }

        private async Task _LoadInvoicesDataAsync()
        {
            DataTable Data = await clsInvoice.GetInvoicesAsync(NumberOfRowsEachPage, CurrentPage);
            dgvData.DataSource = Data;
            lblPageNumber.Text = CurrentPage.ToString();

            if (dgvData.Rows.Count > 0)
            {
                dgvData.Columns[8].Width = 200;
                
            }
        }

        private async void frmManageInvoices_Load(object sender, EventArgs e)
        {
            btnPrevious.Enabled = false;
            CurrentPage = 1;

            TotalPages = await clsInvoice.GetInvoicesNumberOfPagesAsync(NumberOfRowsEachPage);
            lblTotalPages.Text = TotalPages.ToString();


            if (TotalPages == 0 || TotalPages == 1)
            {
                lblTotalPages.Text = "1";
                lblPageNumber.Text = "1";
                btnNext.Enabled = false;
            }
            else
                btnNext.Enabled = true;
            await _LoadInvoicesDataAsync();
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            if (++CurrentPage <= TotalPages)
            {
                btnPrevious.Enabled = true;

                await _LoadInvoicesDataAsync();

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

                await _LoadInvoicesDataAsync();


                if (CurrentPage == 1)
                    btnPrevious.Enabled = false;
            }
        }

        private void updateInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            if (_CurrentRepairOrder.Status != clsRepairOrder.enStatus.InvoiceIssuing ||
                     _CurrentRepairOrder.HasPayments
                )
                return;


            frmIssueInvoice frm = new frmIssueInvoice((int)dgvData.CurrentRow.Cells[0].Value);

            frm.ShowDialog();
            frmManageInvoices_Load(null, null);
        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

            if (dgvData.CurrentRow == null)
            {
                guna2ContextMenuStrip1.Enabled = false;
                return;
            }

            guna2ContextMenuStrip1.Enabled = true;

            _CurrentRepairOrder = clsRepairOrder.Find((int)dgvData.CurrentRow.Cells[1].Value);

         
            updateInfoToolStripMenuItem.Enabled = 
                _CurrentRepairOrder.Status == clsRepairOrder.enStatus.InvoiceIssuing &&
                !_CurrentRepairOrder.HasPayments;
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowInvoiceDetails frm =
                new frmShowInvoiceDetails((int)dgvData.CurrentRow.Cells[0].Value);


            frm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearchForInvoice frm = new frmSearchForInvoice();

            frm.ShowDialog();

        }
    }
}
