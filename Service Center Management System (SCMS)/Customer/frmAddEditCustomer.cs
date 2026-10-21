using SCMS_Business_Logic;
using SCMSControlsLib;
using SharedLib;
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
using static SCMS_Business_Logic.clsEmployee;

namespace Service_Center_Management_System__SCMS_
{
    public partial class frmAddEditCustomer : Form
    {
        public Action<int> CustomerID;
        public enum enMode { AddNew = 0, Update = 1,ConvertingToCustomer=2}
        public enMode _Mode = enMode.AddNew;

        clsCustomer _Customer;
        int _CustomerID;
        clsEmployee _Employee;
        int _EmployeeID;

        private string ApplicationName = ConfigurationManager.AppSettings["ApplicationName"];
        public frmAddEditCustomer()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        public frmAddEditCustomer(int CustomerID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _CustomerID = CustomerID;
        }

        public frmAddEditCustomer(int EmployeeID,bool FromEmployee)
        {
            InitializeComponent();

            _Mode = enMode.ConvertingToCustomer;
            _EmployeeID = EmployeeID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_CustomerID != 0)
                CustomerID?.Invoke(_CustomerID);

            this.Close();
        }

        void _SetIntialInfo()
        {  

            if (_Mode == enMode.Update)
            {
                this.Text = "Edit Customer Info";
                lblTitle.Text = "Edit Customer Info";
                lblCustomerID.Text = _CustomerID.ToString();

            }
            else
            {
                this.Text = "Add New Customer";
                lblTitle.Text = "Add New Customer";
                lblCustomerID.Text = "[???]";
                lblCreatedDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                lblCreatedByUser.Text = clsGlobal.CurrentUser.Username;
            }
        }


        void _LoadData()
        {
            _SetIntialInfo();
            if (_Mode == enMode.AddNew)
            {
                ucPersonalInfo1.txtFocus();
                _Customer = new clsCustomer();
            }
            else if (_Mode == enMode.Update)
            {
                _Customer = clsCustomer.FindCustomer(_CustomerID);

                if (_Customer == null)
                {
                    MessageBox.Show($"Customer with Id = {_CustomerID} Not found!");
                    return;
                }

                ucPersonalInfo1.LoadInfo(_Customer.FirstName, _Customer.SecondName, _Customer.ThirdName,
                   _Customer.LastName, _Customer.Gender, _Customer.PhoneNumber, _Customer.Email,
                   _Customer.Address);
              
                txtNotes.Text = _Customer.Notes ?? "";
                lblCreatedDate.Text = _Customer.CreatedDate.ToString("dd/MM/yyyy");
                lblCreatedByUser.Text = _Customer.CreatedUserInfo.Username;
            }
            else
            {
                _Employee = clsEmployee.FindEmployee(_EmployeeID);

                if (_Employee == null)
                {
                    MessageBox.Show($"Employee with Id = {_EmployeeID} Not found!", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                if (_Employee.IsAlreadyCustomer())
                {
                    MessageBox.Show($"Employee is already a customer!", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ucPersonalInfo1.LoadInfo(_Employee.FirstName, _Employee.SecondName, _Employee.ThirdName,
                   _Employee.LastName, _Employee.Gender, _Employee.PhoneNumber, _Employee.Email,
                   _Employee.Address);

                ucPersonalInfo1.gbEnabled = false;
            }
        }

        private void frmAddEditCustomer_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void _ConvertEmployeeToCustomer()
        {
            int? CustomerId = _Employee.ConvertToCustomer(txtNotes.Text,
              clsGlobal.CurrentUser.UserID);

            if (CustomerId != null)
            {
                MessageBox.Show($"Data Saved Successfully\nNew customer id = {CustomerId}",
                    "Saved", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CustomerID?.Invoke(CustomerId.Value);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to save customer data.", "An error occurred", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save customer date?", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.Cancel) return;


            if (_Mode==enMode.ConvertingToCustomer)
            {
                _ConvertEmployeeToCustomer();
                return;
            }


            ucPersonalInfo.stPersonalInfo? Info =
                ucPersonalInfo1.GetFinalInfo();

            if (Info == null) return;

          
            //Personal info
            _Customer.FirstName = Info.Value.FirstName;
            _Customer.SecondName = Info.Value.SecondName;
            _Customer.ThirdName = Info.Value.ThirdName;
            _Customer.LastName = Info.Value.LastName;
            _Customer.Gender = Info.Value.Gender;
            _Customer.PhoneNumber = Info.Value.PhoneNumber;
            _Customer.Email = Info.Value.Email;
            _Customer.Address = Info.Value.Address;

            //Additional info
            _Customer.Notes = string.IsNullOrEmpty(txtNotes.Text) ? null : txtNotes.Text;

            if (_Mode == enMode.AddNew)
            {
                _Customer.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            }
            else
            {
                
                _Customer.LastUpdatedUserID = clsGlobal.CurrentUser.UserID;
            }



            if (_Customer.Save())
            {
                MessageBox.Show($"Data Saved Successfully", "Saved", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);


                _Mode = enMode.Update;
                _CustomerID = _Customer.CustomerID;
                _SetIntialInfo();
            
                CustomerID?.Invoke(_CustomerID);

                if(_Mode==enMode.AddNew ||
                    _Mode==enMode.ConvertingToCustomer)
                {

                    clsEventLogger.WriteEntryToEventLog(
                       ApplicationName,
                       $"User with username = {clsGlobal.CurrentUser.Username} created customer with ID = {_CustomerID} successfully",
                        System.Diagnostics.EventLogEntryType.Information);

                }
            }
            else
            {
                MessageBox.Show("Failed to save customer data.", "An error occurred", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

     
    
    }
}
