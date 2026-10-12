using SCMS_Business_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCMSControlsLib
{
    public partial class ucShowDiagnosisDetails : UserControl
    {
        clsDiagnosis _Diagnosis;
        clsRepairOrder _RepairOrder;
        public ucShowDiagnosisDetails()
        {
            InitializeComponent();
        }
        private void _SetIntialData()
        {
            lblDiagnosisID.Text= "[???]";
            lblRepairOrderID.Text = "[???]";
            lblAssignedTechnicianID.Text = "[???]";
            lblDeviceID.Text = "[???]";
            lblCreatedDate.Text = "[???]";
            lblStatus.Text = "[???]";
            lblEsCompletionDate.Text = "[???]";
            lblRequireParts.Text = "[???]";
            lblTechnicianNotes.Text = "[???]";
            lblDetectedProblems.Text = "[???]";
            lblATechnicianName.Text = "[???]";
            lblDeviceTypeName.Text= "[???]";
            lblLaborCost.Text= "[???]";
            lblApprovalDate.Text= "[???]";
            lblEstimatedCost.Text= "[???]";
            lblCreatedUser.Text = "[???]";
        }

        private void _LoadDiagnosisInfo()
        {
            lblDiagnosisID.Text = _Diagnosis.DiagnosisID.ToString();
            lblRepairOrderID.Text = _Diagnosis.RepairOrderID.ToString();
            lblAssignedTechnicianID.Text = _RepairOrder.AssignedTechnicianID.ToString();
            lblDeviceID.Text = _RepairOrder.DeviceID.ToString();
            lblCreatedDate.Text = _Diagnosis.CreatedDate.ToString("dd/MM/yyyy");
            lblStatus.Text =_Diagnosis.Status== null? "Un Known": 
                _Diagnosis.Status == clsDiagnosis.enStatus.Approval ?"Approval":"Rejected";

            lblEsCompletionDate.Text = _Diagnosis.EstimatedCompletionDate.ToString("dd/MM/yyyy");
            lblRequireParts.Text =_Diagnosis.RequireParts??"Un Known";
            lblTechnicianNotes.Text =_Diagnosis.TechnicianNotes??"Un Known";
            lblDetectedProblems.Text = _Diagnosis.DetectedProblems;
            lblATechnicianName.Text =
                _RepairOrder.AssignedTechnicianInfo.EmployeeInfo.FullName;
            lblDeviceTypeName.Text = _RepairOrder.DeviceInfo.DeviceTypeInfo.DeviceTypeName;
            lblLaborCost.Text = _Diagnosis.LaborCost.ToString();
            lblApprovalDate.Text =_Diagnosis.ApprovalDate?.ToString()??"Un Known";
            lblEstimatedCost.Text = _Diagnosis.EstimatedCost.ToString();
            lblCreatedUser.Text = _Diagnosis.CreatedUserInfo.Username;
        }

        public void LoadDiagnosisInfo(int DiagnosisID)
        {
            _Diagnosis = clsDiagnosis.FindDiagnosis(DiagnosisID);

            if (_Diagnosis == null)
            {
                MessageBox.Show($"Diagnosis with id = {DiagnosisID} Not found!", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                _SetIntialData();
                return;
            }

            _RepairOrder = clsRepairOrder.Find(_Diagnosis.RepairOrderID);

            if (_RepairOrder==null)
            {
                MessageBox.Show(
                      "The associated Repair Order could not be found.",
                       "",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                       );

                _SetIntialData();
                return;
            }
            _LoadDiagnosisInfo();
        }
    }
}
