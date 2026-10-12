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

namespace Service_Center_Management_System__SCMS_
{
    public partial class frmCustomerApproval : Form
    {

        clsDiagnosis _Diagnosis;
        int _DiagnosisID;

        public frmCustomerApproval(int DiagnosisID)
        {
            InitializeComponent();

            _DiagnosisID = DiagnosisID;
        }

        private void frmCustomerApproval_Load(object sender, EventArgs e)
        {
            _Diagnosis = clsDiagnosis.FindDiagnosis(_DiagnosisID);

            if (_Diagnosis == null)
            {
                MessageBox.Show($"Diagnosis with id = {_DiagnosisID} Not found!", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }
              
            if(_Diagnosis.Status !=null)
            {
                MessageBox.Show(
                $"This diagnosis has already been {(_Diagnosis.Status == clsDiagnosis.enStatus.Approval ? "approved" : "rejected")}.",
                 "Diagnosis",
                MessageBoxButtons.OK,
                 MessageBoxIcon.Information);

                btnSave.Enabled = false;
                return;
            }

            ucShowDiagnosisDetails1.LoadDiagnosisInfo(_DiagnosisID);
            rbApproved.Checked = true;

        }

        private void rbApproved_CheckedChanged(object sender, EventArgs e)
        {
            dtpApprovalDate.Enabled = rbApproved.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(dtpApprovalDate.Value.Date>DateTime.Today.Date)
            {

                MessageBox.Show("Approval date cannot be in the future.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (MessageBox.Show("Are you sure you want to save data?", "Confirm",
             MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
           == DialogResult.Cancel) return;



            if ( _Diagnosis.UpdateStatus(rbApproved.Checked ? clsDiagnosis.enStatus.Approval :
                clsDiagnosis.enStatus.Rejected, dtpApprovalDate.Enabled ? (DateTime?)
                dtpApprovalDate.Value :
                null,clsGlobal.CurrentUser.UserID))
            {

                MessageBox.Show(
                   rbApproved.Checked
                    ? "Customer approval has been saved successfully."
                     : "Customer rejection has been saved successfully.",
                 "Success",
                 MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                 MessageBox.Show(
                    "Failed to save customer confirmation.",
                    "Error",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);

            }
        }
    }
}
