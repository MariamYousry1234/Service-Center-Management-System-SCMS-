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
    public partial class ucShowTechnicianInfo : UserControl
    {
        clsTechnician _Technician;
        int? _TechnicianID;
        public ucShowTechnicianInfo()
        {
            InitializeComponent();
        }

        public int? TechnicianID
        {
            get
            {
                return _TechnicianID;
            }
        }

        public clsTechnician TechnicianInfo
        {
            get
            {
                return _Technician;
            }
        }
        private void _SetIntialInfo()
        {
            lblTechnicianID.Text = "???";
            lblSpecialization.Text= "???";
            lblCreatedByUser.Text= "???";
            lblCreatedDate.Text= "???";
            lblLastUpdatedDate.Text= "???";
            lblLastUpdatedUser.Text= "???";
        }

        private void _LoadTechnicianData()
        {
            _TechnicianID = _Technician.TechnicianID;

            ucShowEmployeeInfo1.LoadEmployeeInfo(_Technician.EmployeeID);

            lblTechnicianID.Text = _TechnicianID.ToString();
            lblSpecialization.Text = _Technician.txtSpecialization;
            lblCreatedByUser.Text = _Technician.CreatedByUserInfo.Username;
            lblCreatedDate.Text = _Technician.CreatedDate.ToString("dd/MM/yyyy");
            lblLastUpdatedDate.Text = _Technician.LastUpdatedDate?.ToString("dd/MM/yyyy") ?? "Un Known";
            lblLastUpdatedUser.Text = _Technician.LastUpdatedUserInfo?.Username ?? "Un Known";
        }
        public void LoadTechnicianInfo(int TechnicianID)
        {
            _Technician = clsTechnician.FindTechnician(TechnicianID);

            if(_Technician ==null)
            {
                MessageBox.Show($"Technician with id ={TechnicianID} Not found!", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                _TechnicianID = null;
                _SetIntialInfo();
                return;

            }

            _LoadTechnicianData();
        }

        public void LoadTechnicianInfoByEmployeeID(int EmployeeID)
        {
            _Technician = clsTechnician.FindTechnicianByEmployeeID(EmployeeID);

            if (_Technician == null)
            {
                MessageBox.Show($"Technician with Employee id ={EmployeeID} Not found!", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                _TechnicianID = null;
                _SetIntialInfo();
                return;

            }

            _LoadTechnicianData();

        }

        public void LoadTechnicianInfoByPhoneNumber(string PhoneNumber)
        {
            _Technician = clsTechnician.FindTechnicianByPhoneNumber(PhoneNumber);

            if (_Technician == null)
            {
                MessageBox.Show($"Technician with phone number ={PhoneNumber} Not found!", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                _TechnicianID = null;
                _SetIntialInfo();
                return;

            }

            _LoadTechnicianData();

        }
    }
}
