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
    public partial class frmAddEditDiagnosis : Form
    {
        enum enMode { AddNew=0,Update=1}
        enMode _Mode = enMode.AddNew;

        clsDiagnosis _Diagnosis;
        int _DiagnosisID;


        clsRepairOrder _RepairOrder;
        int _RepairOrderID;

        public frmAddEditDiagnosis(int RepairOrderID,bool IsAddNew)
        {
            InitializeComponent();

            _Mode = enMode.AddNew;  

            //check if repair order exists 
            _RepairOrder = clsRepairOrder.Find(RepairOrderID);

            if(_RepairOrder==null)
            {
                MessageBox.Show($"Repair order with id ={RepairOrderID} Not found!",
                    "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                this.Close();
                return;
            }


            //check if repair order already has diagnosis
            if(_RepairOrder.DiagnosisInfo != null)
            {
                MessageBox.Show(
                    $"Repair order with id ={RepairOrderID} already has diagnosis with id ={_RepairOrder.DiagnosisInfo.DiagnosisID}!",
                   "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                this.Close();
                return;
            }

            _RepairOrderID = RepairOrderID;
            _Diagnosis = new clsDiagnosis();
        }

        public frmAddEditDiagnosis(int DiagnosisID)
        {
            InitializeComponent();

            _Mode = enMode.Update;

            _DiagnosisID = DiagnosisID;
        }

        private void _LoadIntailData()
        {
          

            if (_Mode == enMode.AddNew)
            {
                this.Text = "Add New Diagnosis";
                lblTitle.Text = "Add New Diagnosis";
                gbInfo.Text = "Diagnosis ID = [???]";
                lblRepairOrderID.Text = _RepairOrder.RepairOrderID.ToString();
                lblDeviceID.Text = _RepairOrder.DeviceID.ToString();
                dtpECDate.Value = DateTime.Now.Date;
            }
            else
            {
                this.Text = "Update Diagnosis Info";
                lblTitle.Text = "Update Diagnosis Info";
                gbInfo.Text = $"Diagnosis ID ={_DiagnosisID}";

            }


        }

        private void _LoadDataToUpdate()
        {
            _Diagnosis = clsDiagnosis.FindDiagnosis(_DiagnosisID);

            if (_Diagnosis == null)
            {
                MessageBox.Show($"Can not found diagnosis with id ={_DiagnosisID}");
                btnSave.Enabled = false;
             
                return;
            }

            if(_Diagnosis.Status != null)
            {
                MessageBox.Show(
                   "You cannot modify this diagnosis because it has already been processed.",
                   "Not Allowed",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);

                btnSave.Enabled = false;
                return;
            }

            _RepairOrderID = _Diagnosis.RepairOrderID;
            lblRepairOrderID.Text = _RepairOrderID.ToString();
            lblDeviceID.Text = clsRepairOrder.Find(_RepairOrderID).DeviceID.ToString();
            txtDetectedProblems.Text = _Diagnosis.DetectedProblems;
            txtRequireParts.Text = _Diagnosis.RequireParts??"";
            txtLaborCost.Text = _Diagnosis.LaborCost.ToString();
            dtpECDate.Value = _Diagnosis.EstimatedCompletionDate;
            txtTehnicianNotes.Text = _Diagnosis.TechnicianNotes??"";
            txtEstimatedCost.Text = _Diagnosis.EstimatedCost.ToString();
           
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditDiagnosis_Load(object sender, EventArgs e)
        {
            _LoadIntailData();

            if (_Mode == enMode.Update)
                _LoadDataToUpdate();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!txtDetectedProblems.IsValid() || !txtLaborCost.IsValid()
                || !txtEstimatedCost.IsValid()) return;


            if(dtpECDate.Value.Date < DateTime.Today.Date)
            {
                MessageBox.Show("Estimated completion date cannot be earlier than today.",
                       "Invalid Date",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);

                return;
            }

            if(Convert.ToSingle(txtEstimatedCost.Text)< Convert.ToSingle(txtLaborCost.Text))
            {
                MessageBox.Show("Estimated cost cannot be less than labor cost.",
                   "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (MessageBox.Show("Are you sure you want to save diagnosis data?", "Confirm",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            == DialogResult.Cancel) return;


            _Diagnosis.RepairOrderID = _RepairOrderID;
            _Diagnosis.DetectedProblems =txtDetectedProblems.Text;

            _Diagnosis.RequireParts=
                 string.IsNullOrEmpty(txtRequireParts.Text) ? null : txtRequireParts.Text;

            _Diagnosis.LaborCost =Convert.ToSingle(txtLaborCost.Text);

            _Diagnosis.EstimatedCompletionDate = dtpECDate.Value;

            _Diagnosis.TechnicianNotes=
                 string.IsNullOrEmpty(txtTehnicianNotes.Text) ? null : txtTehnicianNotes.Text;


            _Diagnosis.EstimatedCost = Convert.ToSingle(txtEstimatedCost.Text);

            if (_Mode == enMode.AddNew)
                _Diagnosis.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if(_Diagnosis.Save())
            {
                MessageBox.Show($"Data Saved Successfully",
                "Saved", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                _Mode = enMode.Update;
                _DiagnosisID = _Diagnosis.DiagnosisID;


                _LoadIntailData();
            
            }
            else
            {
                MessageBox.Show("Failed to save diagnosis data.", "An error occurred", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        private void frmAddEditDiagnosis_Activated(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddNew)
                txtDetectedProblems.Focus();
        }
    }
}
