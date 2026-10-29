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
using static SCMSControlsLib.ucPersonalInfo;

namespace Service_Center_Management_System__SCMS_
{
    public partial class frmAddEditEmployee : Form
    {

        public Action <int> EmployeeID;

        public enum enMode { AddNew = 0,Update = 1,ConvertingToEmployee =2}
        public  enMode _Mode = enMode.AddNew;


        clsEmployee _Employee;
        int _EmployeeID;
        clsCustomer _Customer;
        int _CustomerID;
        public frmAddEditEmployee()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
           
        }

        public frmAddEditEmployee(int EmployeeID)
        {
            InitializeComponent();

            _Mode = enMode.Update;

            _EmployeeID = EmployeeID;
        }


        public frmAddEditEmployee(int CustomerID,bool FromCustomer)
        {
            InitializeComponent();


            _Mode = enMode.ConvertingToEmployee;
            _CustomerID = CustomerID;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_EmployeeID != 0)
                EmployeeID?.Invoke(_EmployeeID);
            this.Close();
        }

        void _SetIntialInfo()
        {
       
            if(_Mode==enMode.Update)
            {
                this.Text = "Edit Employee Info";
                lblTitle.Text = "Edit Employee Info";

                lblEmployeeID.Text = _EmployeeID.ToString();

            }
            else
            {
                this.Text = "Add New Employee";
                lblTitle.Text = "Add New Employee";
                lblEmployeeID.Text = "[???]";
                lblCreatedDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                dtpHireDate.Value = DateTime.Now;
                lblCreatedByUser.Text = clsGlobal.CurrentUser.Username;
            }
        }

        void _LoadData()
        {
            _SetIntialInfo(); 
            if (_Mode == enMode.AddNew)
            {
                ucPersonalInfo1.txtFocus();
                _Employee = new clsEmployee();
            }
            else if(_Mode==enMode.Update)
            {
                _Employee = clsEmployee.FindEmployee(_EmployeeID);

                if (_Employee == null)
                {
                    MessageBox.Show($"Employee with Id = {_EmployeeID} Not found!");
                    return;
                }


                ucPersonalInfo1.LoadInfo(_Employee.FirstName, _Employee.SecondName, _Employee.ThirdName,
                             _Employee.LastName, _Employee.Gender, _Employee.PhoneNumber, _Employee.Email,
                             _Employee.Address);


                dtpHireDate.Value = _Employee.HireDate;
                chbIsActive.Checked = _Employee.IsActive;
                lblCreatedDate.Text = _Employee.CreatedDate.ToString("dd/MM/yyyy");
                lblCreatedByUser.Text = clsUser.FindUser(_Employee.CreatedByUserID).Username;
            }
            else
            {
                _Customer = clsCustomer.FindCustomer(_CustomerID);

                if(_Customer == null)
                {
                    MessageBox.Show($"Customer with Id = {_CustomerID} Not found!","",
                        MessageBoxButtons.OK,MessageBoxIcon.Error);
                             
                    return;
                }

                if(_Customer.IsAlreadyEmployee())
                {
                    MessageBox.Show($"Customer is already an employee!","",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ucPersonalInfo1.LoadInfo(_Customer.FirstName, _Customer.SecondName, _Customer.ThirdName,
                    _Customer.LastName, _Customer.Gender, _Customer.PhoneNumber, _Customer.Email,
                    _Customer.Address);

                ucPersonalInfo1.gbEnabled = false;
            }
        }
        private void frmAddEditEmployee_Load(object sender, EventArgs e)
        {
            _LoadData();
        
        }

        private void _ConvertCustomerToEmployee()
        {
            int? EmployeeId = _Customer.ConvertToEmployee(dtpHireDate.Value,
              clsGlobal.CurrentUser.UserID);

            if( EmployeeId != null)
            {
                MessageBox.Show($"Data Saved Successfully\nNew employee id = {EmployeeId}",
                    "Saved", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                EmployeeID?.Invoke(EmployeeId.Value);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to save employee data.", "An error occurred", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dtpHireDate.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Date cannot be in the future", "Not Valid", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                return;
            }


            if (MessageBox.Show("Are you sure you want to save employee data?", "Confirm",
                  MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                  == DialogResult.Cancel) return;

            if (_Mode == enMode.ConvertingToEmployee)
            {
                _ConvertCustomerToEmployee();
            }
            else
            {
                ucPersonalInfo.stPersonalInfo? Info =
                     ucPersonalInfo1.GetFinalInfo();

                if (Info == null) return;

                //Personal info
                _Employee.FirstName = Info.Value.FirstName;
                _Employee.SecondName = Info.Value.SecondName;
                _Employee.ThirdName = Info.Value.ThirdName;
                _Employee.LastName = Info.Value.LastName;
                _Employee.Gender = Info.Value.Gender;
                _Employee.PhoneNumber = Info.Value.PhoneNumber;
                _Employee.Email = Info.Value.Email;
                _Employee.Address = Info.Value.Address;


                _Employee.HireDate = dtpHireDate.Value;

                if (_Mode == enMode.AddNew)
                {

                    _Employee.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                }
                else
                {

                    _Employee.LastUpdatedUserID = clsGlobal.CurrentUser.UserID;
                }

                if (_Employee.Save())
                {
                    MessageBox.Show($"Data Saved Successfull", "Saved", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);


                    _Mode = enMode.Update;
                    _EmployeeID = _Employee.EmployeeID;
                    _SetIntialInfo();

                    EmployeeID?.Invoke(_EmployeeID);
                }
                else
                {
                    MessageBox.Show("Failed to save employee data.", "An error occurred", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }

            }
           

        }

        private void frmAddEditEmployee_Activated(object sender, EventArgs e)
        {
            if(_Mode==enMode.AddNew)
                ucPersonalInfo1.txtFocus();
        }
    }
}
