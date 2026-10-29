using SCMS_Business_Logic;
using SCMSControlsLib;
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
    public partial class frmAddEditTechnician : Form
    {
        public Action<int> delegateTechnicianID;

        enum enMode { AddNew=0,Update=1 }
        enMode _Mode;

        clsTechnician _Technician;
        int _TechnicianID;
        public frmAddEditTechnician()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddEditTechnician(int TechnicianID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _TechnicianID = TechnicianID;
        }
        private void _SetIntailInfo()
        {   if (_Mode==enMode.AddNew)
            {
                this.Text = "Add New Technician";
                lblTitle.Text = "Add New Technician";
                cbSpecialization.SelectedIndex = 0;
                lblTechnicianID.Text = "[???]";
                lblUserCreated.Text = clsGlobal.CurrentUser.Username;
                lblCreatedDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

            }
            else
            {
                this.Text = "Edit Technician Info";
                lblTitle.Text = "Edit Technician Info";
                lblTechnicianID.Text = _TechnicianID.ToString();
            }

        }


        private void _LoadDate()
        {
            _SetIntailInfo();

            if(_Mode==enMode.AddNew)
            {
                ucSearchForEmployeeWithAddingEditing1.LoadEmployeeInfo();
                _Technician = new clsTechnician();
            }
            else
            {
                _Technician = clsTechnician.FindTechnician(_TechnicianID);

                if(_Technician==null)
                {
                    MessageBox.Show($"Technician with Id = {_TechnicianID} Not found!");
                    return;
                }

                ucSearchForEmployeeWithAddingEditing1.LoadEmployeeInfo(_Technician.EmployeeID);

                lblTechnicianID.Text = _Technician.TechnicianID.ToString();
                cbSpecialization.SelectedIndex = ((byte)_Technician.Specialization - 1);
                lblUserCreated.Text = _Technician.CreatedByUserInfo.Username;
                lblCreatedDate.Text = _Technician.CreatedDate.ToString("dd/MM/yyyy");
            }

        }
        private void frmAddEditTechnician_Load(object sender, EventArgs e)
        {
            _LoadDate();
            ucSearchForEmployeeWithAddingEditing1.EmployeeSaved = LoadAddEditEmployeeForm;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(_TechnicianID != 0)
                delegateTechnicianID?.Invoke(_TechnicianID);

            this.Close();
        }

        int? LoadAddEditEmployeeForm(int? EmployeeID)
        {
            int? NewEmployeeID = null;

            frmAddEditEmployee frm;

            if(_Mode==enMode.AddNew)
            {
                frm = new frmAddEditEmployee();
            }
            else
            {
                frm = new frmAddEditEmployee(EmployeeID.Value);
            }

            frm.EmployeeID += (int EmployeeId) =>
            {
                NewEmployeeID = EmployeeId;
            };

            frm.ShowDialog();

            return NewEmployeeID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          
            if (ucSearchForEmployeeWithAddingEditing1.EmployeeID == null)
            {
                MessageBox.Show("No Employee Selected", "Not Valid", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if(_Mode==enMode.AddNew &&
                !ucSearchForEmployeeWithAddingEditing1.EmployeeInfo.IsActive)
            {
                MessageBox.Show($"Employee with id = {ucSearchForEmployeeWithAddingEditing1.EmployeeID} is inactive",
                    "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int? TechnicianID = clsTechnician.GetTechnicianIDByEmployeeID((int)ucSearchForEmployeeWithAddingEditing1.EmployeeID);
         
            if (_Mode == enMode.AddNew &&
                TechnicianID != null)
            {
                MessageBox.Show($"This employee is already a technician with id= {TechnicianID}\nSelect another employee", "Invalid Operation", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to save technician data?", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.Cancel) return;


            _Technician.EmployeeID = (int)ucSearchForEmployeeWithAddingEditing1.EmployeeID;
            _Technician.Specialization = (clsTechnician.enSpecialization)(cbSpecialization.SelectedIndex + 1);

            if (_Mode == enMode.AddNew)
            {
                _Technician.CreatedDate = DateTime.Now;
                _Technician.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            }
            else
            {
                _Technician.LastUpdatedDate = DateTime.Now;
                _Technician.LastUpdatedUserID = clsGlobal.CurrentUser.UserID;
            }



            if (_Technician.Save())
            {
                MessageBox.Show($"Data Saved Successfully", "Saved", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);


                _Mode = enMode.Update;
                _TechnicianID = _Technician.TechnicianID;
                _SetIntailInfo();
                ucSearchForEmployeeWithAddingEditing1.LoadEmployeeInfo(_Technician.EmployeeID);


                delegateTechnicianID?.Invoke(_Technician.TechnicianID);
            }
            else
            {
                MessageBox.Show("Failed to save technician data.", "An error occurred", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }

        }

        private void frmAddEditTechnician_Activated(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddNew)
                ucSearchForEmployeeWithAddingEditing1.txtFocus();
        }
    }
}
