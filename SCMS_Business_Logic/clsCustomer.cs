using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCMS_Data_Access;

namespace SCMS_Business_Logic
{
    public class clsCustomer :clPerson
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;

        public int CustomerID { get; set; }

        public string? Notes { get; set; }

        public int CreatedByUserID { get; set; }

        public clsUser CreatedUserInfo { get; set; }

        public DateTime CreatedDate { get; private set; }

        public int? LastUpdatedUserID { get; set; }

        public clsUser? LastUpdatedUserInfo { get; set; }

        public DateTime? LastUpdatedDate { get; private set; }

        public bool HasRepairOrders
        {
            get
            {
                return clsRepairOrder.IsCustomerHasRepairOrders(this.CustomerID);
            }
        }

        public bool HasDevices
        {
            get
            {
                return clsDevice.IsCustomerHasDevices(this.CustomerID);
            }
        }

        public bool HasPayments
        {
            get
            {
                return clsPayment.IsCustomerHasPayments(this.CustomerID);
            }
        }

        public clsCustomer()
        {
            this.Notes = null;
          

            CreatedUserInfo = new clsUser();
            LastUpdatedUserInfo = new clsUser();

            this.Mode = enMode.AddNew;
        }


        private clsCustomer(
            int CustomerID,
            string FirstName,
           string SecondName,
           string? ThirdName,
           string? LastName,
           enGender Gender,
           string PhoneNumber,
            string? Email,
           string Address,
           string? Notes,
           int CreatedByUserID,
           DateTime CreatedDate,
           int? LastUpdatedUserID,
           DateTime? LastUpdatedDate
          )
        {
            this.CustomerID = CustomerID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.Gender = Gender;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.Address = Address;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;
            this.LastUpdatedUserID = LastUpdatedUserID;
            this.LastUpdatedDate = LastUpdatedDate;
         
            
            this.CreatedUserInfo = clsUser.FindUser(CreatedByUserID);

            if (LastUpdatedUserID != null)
                this.LastUpdatedUserInfo = clsUser.FindUser(LastUpdatedUserID.Value);

            Mode = enMode.Update;
        }


        private bool AddNewCustomer()
        {
            int? CustomerID = clsCustomerDataAccess.AddNewCustomer(
                this.FirstName,
                this.SecondName,
                this.ThirdName,
                this.LastName,
                (byte)this.Gender,
                this.PhoneNumber,
                this.Email,
                this.Address,
                this.Notes,
                this.CreatedByUserID

            );

            if (CustomerID != null)
            {
                this.CustomerID = (int)CustomerID;
                return true;
            }

            return false;
        }


        private bool UpdateCustomer()
        {
            return clsCustomerDataAccess.UpdateCustomer(
                this.CustomerID,
               this.FirstName,
                this.SecondName,
                this.ThirdName,
                this.LastName,
                (byte)this.Gender,
                this.PhoneNumber,
                this.Email,
                this.Address,
                this.Notes,
                this.LastUpdatedUserID
            );
        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        if (AddNewCustomer())
                        {
                            Mode = enMode.Update;
                            return true;
                        }

                        return false;
                    }

                case enMode.Update:
                    {
                        return UpdateCustomer();
                    }
            }

            return false;
        }


        public static clsCustomer FindCustomer(int CustomerID)
        {
            string FirstName = "",
                SecondName = "",
                PhoneNumber = "", 
                Address = "";
            string? ThirdName = null, LastName = null, Email = null, Notes = null; ;

            byte Gender = 0;

            int CreatedByUserID = 0;
            DateTime CreatedDate = DateTime.Now;

            int? LastUpdatedUserID = null;
            DateTime? LastUpdatedDate = null;
          

            if (clsCustomerDataAccess.FindCustomer(
                CustomerID,
                ref  FirstName,
                ref  SecondName,
                ref  ThirdName,
                ref  LastName,
                ref  Gender,
                ref  PhoneNumber,
                ref  Email,
               ref  Address,
                ref Notes,
                ref CreatedByUserID,
                ref CreatedDate,
                ref LastUpdatedUserID,
                ref LastUpdatedDate
            ))
            {
                return new clsCustomer(
                    CustomerID,
                    FirstName,
                    SecondName,
                    ThirdName,
                    LastName,
                    (enGender)Gender,
                    PhoneNumber,
                    Email,
                    Address,
                    Notes,
                    CreatedByUserID,
                    CreatedDate,
                    LastUpdatedUserID,
                    LastUpdatedDate
                  );
            }

            return null;
        }

        public static clsCustomer FindCustomerByPhoneNumber(string PhoneNumber)
        {
            string FirstName = "",
              SecondName = "",
              Address = "";
            string? ThirdName = null, LastName = null, Email = null, Notes = null;

            int CustomerID = 0,  CreatedByUserID = 0;

            DateTime CreatedDate = DateTime.Now;
            byte Gender = 0;
            int? LastUpdatedUserID = null;
            DateTime? LastUpdatedDate = null;
      
            if (clsCustomerDataAccess.FindCustomerByPhoneNumber(
                PhoneNumber,
                ref CustomerID,
                 ref FirstName,
                ref SecondName,
                ref ThirdName,
                ref LastName,
                ref Gender,
                ref Email,
                ref Address,
                ref Notes,
                ref CreatedByUserID,
                ref CreatedDate,
                ref LastUpdatedUserID,
                ref LastUpdatedDate
               ))
            {
                return new clsCustomer(
                    CustomerID,
                    FirstName,
                    SecondName,
                    ThirdName,
                    LastName,
                    (enGender)Gender,
                    PhoneNumber,
                    Email,
                    Address,
                    Notes,
                    CreatedByUserID,
                    CreatedDate,
                    LastUpdatedUserID,
                    LastUpdatedDate
                   );
            }

            return null;
        }

   
        public static bool IsCustomerExists(int CustomerID)
        {
            return clsCustomerDataAccess.IsCustomerExists(CustomerID);
        }


        public static bool DeleteCustomer(int CustomerID)
        {
            return clsCustomerDataAccess.DeleteCustomer(CustomerID);
        }


        public static Task<DataTable> GetCustomersAsync(
            int NumberOfCustomersEachPage,
            int NumberOfPage)
        {
            return clsCustomerDataAccess.GetCustomersAsync(
                NumberOfCustomersEachPage,
                NumberOfPage);
        }


        public static Task<int> GetCustomersNumberOfPagesAsync(
            int CustomersEachPage)
        {
            return clsCustomerDataAccess.GetCustomersNumberOfPagesAsync(
                CustomersEachPage);
        }

 
        public Task<DataTable> GetAllRepairOrdersAsync()
        {
            return clsRepairOrder.GetAllRepairOrdersForCustomerAsync(this.CustomerID);
        }

      
        public bool IsAlreadyEmployee()
        {
            return clsCustomerDataAccess.IsCustomerAlreadyEmployee(this.CustomerID);
        }

        public int? ConvertToEmployee(DateTime HireDate,int CreatedByUserID)
        {
            return clsCustomerDataAccess.ConvertCustomerToEmployee(this.CustomerID, HireDate,
                CreatedByUserID);
        }

        public Task<DataTable> GetAllPayments()
        {
            return clsPayment.GetAllPaymentsForCustomer(this.CustomerID);
        }

    }
}