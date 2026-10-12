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
    public partial class frmManageDiagnoses : Form
    {
        private int TotalPages = 1;
        private int CurrentPage = 1;
        private int NumberOfRowsEachPage = Convert.ToInt32(ConfigurationManager.AppSettings["NumberOfRowsEachPage"]);


        clsDiagnosis _CurrentDiagnosis;
        public frmManageDiagnoses()
        {
            InitializeComponent();
        }

        private async Task _LoadDiagnosesDataAsync()
        {
            DataTable Data = await clsDiagnosis.GetDiagnosesAsync(NumberOfRowsEachPage, CurrentPage);
            dgvData.DataSource = Data;
            lblPageNumber.Text = CurrentPage.ToString();

            if (dgvData.Rows.Count > 0)
            {
                dgvData.Columns[3].Width = 200;
                dgvData.Columns[4].Width = 170;
            }
        }

        private async void frmManageDiagnoses_Load(object sender, EventArgs e)
        {
            btnPrevious.Enabled = false;
            CurrentPage = 1;

            TotalPages = await clsDiagnosis.GetDiagnosesNumberOfPagesAsync(NumberOfRowsEachPage);
            lblTotalPages.Text = TotalPages.ToString();


            if (TotalPages == 0 || TotalPages == 1)
            {
                lblTotalPages.Text = "1";
                lblPageNumber.Text = "1";
                btnNext.Enabled = false;
            }
            else
                btnNext.Enabled = true;
            await _LoadDiagnosesDataAsync();
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            if (++CurrentPage <= TotalPages)
            {
                btnPrevious.Enabled = true;

                await _LoadDiagnosesDataAsync();

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

                await _LoadDiagnosesDataAsync();


                if (CurrentPage == 1)
                    btnPrevious.Enabled = false;
            }
        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgvData.CurrentRow == null)
            {
                guna2ContextMenuStrip1.Enabled =false;
                _CurrentDiagnosis = null;
                return;
            }


            guna2ContextMenuStrip1.Enabled = true ;

            _CurrentDiagnosis = 
                clsDiagnosis.FindDiagnosis((int)dgvData.CurrentRow.Cells[0].Value);

            updateInfoToolStripMenuItem.Enabled = _CurrentDiagnosis.Status == null;
        }

        private void updateInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_CurrentDiagnosis.Status != null) return;

            frmAddEditDiagnosis frm =
                new frmAddEditDiagnosis((int)dgvData.CurrentRow.Cells[0].Value);

            frm.ShowDialog();

            frmManageDiagnoses_Load(null, null);

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowDiagnosisDetails frm =
                new frmShowDiagnosisDetails((int)dgvData.CurrentRow.Cells[0].Value);


            frm.ShowDialog();
        }
    }
}
