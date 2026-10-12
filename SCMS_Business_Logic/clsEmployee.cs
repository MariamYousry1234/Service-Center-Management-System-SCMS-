using SCMS_Data_Access;
using System;
using System.Data;
using System.Net;
using System.Threading.Tasks;

namespace SCMS_Business_Logic
{
    public class clsEmployee :clPerson
    {
        public enum enMode
        {
            AddNew = 1,
            Update = 2
        }

        public enMode Mode = enMode.AddNew;

        public int EmployeeID { get; set; }
    
        public DateTime HireDate { get; set; }

        public bool IsActive { get; private set; }

        public int CreatedByUserID { get; set; }

        public DateTime CreatedDate { get; private set; }

        public int? LastUpdatedUserID { get; set; }

        public DateTime? LastUpdatedDate { get; private set; }


        public clsEmployee()
        {       
            LastUpdatedUserID = null;
            LastUpdatedDate = null;

            Mode = enMode.AddNew;

        }


        private clsEmployee(
            int EmployeeID,
            string FirstName,
           string SecondName,
           string? ThirdName,
           string? LastName,
           enGender Gender,
           string PhoneNumber,
            string? Email,
            string Address,
            DateTime HireDate,
            bool IsActive,
            int CreatedByUserID,
            DateTime CreatedDate,
            int? LastUpdatedUserID,
            DateTime? LastUpdatedDate)
        {
            this.EmployeeID = EmployeeID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.Gender = Gender;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.Address = Address;
            this.HireDate = HireDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;
            this.LastUpdatedUserID = LastUpdatedUserID;
            this.LastUpdatedDate = LastUpdatedDate;

            Mode = enMode.Update;
        }


        private bool AddNewEmployee()
        {
           
            int? EmployeeID =
                clsEmployeeDataAccess.AddNewEmployee(
                      this.FirstName,
                     this.SecondName,
                     this.ThirdName,
                     this.LastName,
                     (byte)this.Gender,
                     this.PhoneNumber,
                    this.Email,
                    this.Address,
                    this.HireDate,
                    this.CreatedByUserID
                 );

            if (EmployeeID != null)
            {
                this.EmployeeID = EmployeeID.Value;
                return true;
            }

            return false;
        }


        private bool UpdateEmployee()
        {
            return clsEmployeeDataAccess.UpdateEmployee(
                this.EmployeeID,
               this.FirstName,
                this.SecondName,
                this.ThirdName,
                this.LastName,
                (byte)this.Gender,
                this.PhoneNumber,
                this.Email,
                this.Address,
                this.HireDate,
                this.LastUpdatedUserID
               );
        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (AddNewEmployee())
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                    return false;


                case enMode.Update:

                    return UpdateEmployee();
            }

            return false;
        }


        public static clsEmployee FindEmployee(int EmployeeID)
        {
            string FirstName = "",
                SecondName = "",
                PhoneNumber = "",
                Address = "";
            string? ThirdName = null, LastName = null, Email = null;
            DateTime HireDate = DateTime.Now;
            bool IsActive = false;

            int CreatedByUserID = 0;
            DateTime CreatedDate = DateTime.MinValue;

            int? LastUpdatedUserID = null;
            DateTime? LastUpdatedDate = null;
            byte Gender = 0;

            if (clsEmployeeDataAccess.FindEmployee(
                EmployeeID,
               ref FirstName,
                ref SecondName,
                ref ThirdName,
                ref LastName,
                ref Gender,
                ref PhoneNumber,
                ref Email,
                ref Address,
                ref HireDate,
                ref IsActive,
                ref CreatedByUserID,
                ref CreatedDate,
                ref LastUpdatedUserID,
                ref LastUpdatedDate))
            {
                return new clsEmployee(
                    EmployeeID,
                     FirstName,
                    SecondName,
                    ThirdName,
                    LastName,
                    (enGender)Gender,
                    PhoneNumber,
                    Email,
                    Address,
                    HireDate,
                    IsActive,
                    CreatedByUserID,
                    CreatedDate,
                    LastUpdatedUserID,
                    LastUpdatedDate);
            }

            return null;
        }


        
        public static clsEmployee FindEmployeeByPhoneNumber(
            string PhoneNumber)
        {
            int EmployeeID = 0;
            string FirstName = "",
             SecondName = "",
             Address = "";
            string? ThirdName = null, LastName = null, Email = null;

            DateTime HireDate = DateTime.Now;
            bool IsActive = false;
            byte Gender = 0;
            int CreatedByUserID = 0;
            DateTime CreatedDate = DateTime.MinValue;

            int? LastUpdatedUserID = null;
            DateTime? LastUpdatedDate = null;


            if (clsEmployeeDataAccess.FindEmployeeByPhoneNumber(
                PhoneNumber,
                ref EmployeeID,
                ref FirstName,
                ref SecondName,
                ref ThirdName,
                ref LastName,
                ref Gender,
                ref Email,
                ref Address,
                ref HireDate,
                ref IsActive,
                ref CreatedByUserID,
                ref CreatedDate,
                ref LastUpdatedUserID,
                ref LastUpdatedDate))
            {
                return new clsEmployee(
                    EmployeeID,
                     FirstName,
                    SecondName,
                    ThirdName,
                    LastName,
                    (enGender)Gender,
                    PhoneNumber,
                    Email,
                    Address,
                    HireDate,
                    IsActive,
                    CreatedByUserID,
                    CreatedDate,
                    LastUpdatedUserID,
                    LastUpdatedDate);
            }

            return null;
        }

        public static bool IsEmployeeExists(int EmployeeID)
        {
            return clsEmployeeDataAccess.IsEmployeeExists(EmployeeID);
        }


        public static bool DeleteEmployee(int EmployeeID)
        {
            return clsEmployeeDataAccess.DeleteEmployee(EmployeeID);
        }


        public static Task<DataTable> GetEmployeesAsync(
            int NumberOfEmployeesEachPage,
            int NumberOfPage)
        {
            return clsEmployeeDataAccess.GetEmployeesAsync(
                NumberOfEmployeesEachPage,
                NumberOfPage);
        }


        public static Task<int> GetEmployeesNumberOfPagesAsync(
            int EmployeesEachPage)
        {
            return clsEmployeeDataAccess.GetEmployeesNumberOfPagesAsync(
                EmployeesEachPage);
        }


        public  bool Deactivate()
        { 
            if(clsEmployeeDataAccess.DeactivateEmployee(this.EmployeeID))
            {
                this.IsActive = false;
                return true;
            }
            return false;
        }
        public bool Activate()
        {
            if (clsEmployeeDataAccess.ActivateEmployee(this.EmployeeID))
            {
                this.IsActive = true;
                return true;
            }
            return false;
        }

        public bool IsAlreadyCustomer()
        {
            return clsEmployeeDataAccess.IsEmployeeAlreadyCustomer(this.EmployeeID);
        }

        public  int? ConvertToCustomer( string? Notes,
           int CreatedByUserID)
        {
           return clsEmployeeDataAccess.ConvertEmployeeToCustomer(this.EmployeeID, Notes,
               CreatedByUserID);
        }
     }
}