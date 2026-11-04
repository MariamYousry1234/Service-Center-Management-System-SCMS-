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
    public partial class ucShowEmployeeInfo : UserControl
    {
        
        clsEmployee _Employee;
        int? _EmployeeID = null;
        public ucShowEmployeeInfo()
        {
            InitializeComponent();
        }

         public int? EmployeeID
        {
            get
            {
                return _EmployeeID;
            }
        }

        public clsEmployee EmployeeInfo
        {
            get
            {
                return _Employee;
            }
        }
        private void _SetDefaultDate()
        {
            ucShowPersonInfo1.SetDefaultData();

            lblEmployeeID.Text = "???";
            lblHireDate.Text = "???";
            lblCreatedByUser.Text= "???";
            lblLastUpdatedDate.Text= "???";
            lblCreatedDate.Text= "???";
            lblLastUpdatedUser.Text= "???";
        }
        private void _LoadInfo()
        {
            _EmployeeID = _Employee.EmployeeID;
            ucShowPersonInfo1.LoadPersonInfo(_Employee.FullName,_Employee.txtGender,
                _Employee.PhoneNumber,_Employee.Email,_Employee.Address);

            lblEmployeeID.Text = _EmployeeID.ToString();
            lblHireDate.Text = _Employee.HireDate.ToString("dd/MM/yyyy");
     
           lblIsActive.Text = _Employee.IsActive?"Yes":"No";
           lblCreatedByUser.Text = _Employee.CreatedByUserID!=null?
                clsUser.FindUser((int)_Employee.CreatedByUserID).Username : "UnKnown";

            lblCreatedDate.Text = _Employee.CreatedDate.ToString("dd/MM/yyyy") ?? "UnKnown";
            lblLastUpdatedUser.Text =_Employee.LastUpdatedUserID==null? "Un Known" :
               clsUser.FindUser((int)_Employee.LastUpdatedUserID).Username;
            lblLastUpdatedDate.Text = _Employee.LastUpdatedDate?.ToString("dd/MM/yyyy") ?? "UnKnown";
        }
        public void LoadEmployeeInfo(int EmployeeID)
        {
            _Employee = clsEmployee.FindEmployee(EmployeeID);

            if(_Employee==null)
            {
                _EmployeeID = null;
                _SetDefaultDate();
                MessageBox.Show($"Employee with id ={EmployeeID} Not found!", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            _LoadInfo();
        }

      

        public void LoadEmployeeInfoByPhoneNumber(string PhoneNumber)
        {
            _Employee = clsEmployee.FindEmployeeByPhoneNumber(PhoneNumber);

            if (_Employee == null)
            {
                _EmployeeID = null;
                _SetDefaultDate();
                MessageBox.Show($"Employee with phone number ={PhoneNumber} Not found!", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            _LoadInfo();
        }
    }
}
