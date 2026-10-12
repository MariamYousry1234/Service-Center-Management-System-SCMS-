using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCMS_Data_Access;
using SharedLib;
using System.Configuration;

namespace SCMS_Business_Logic
{
    public  class clsUser
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        public int UserID { set; get; }

        public int EmployeeID { set; get; }

        public clsEmployee EmployeeInfo;
        
        public string Username { set; get; }

        public string Password {
            set;
            get;
        }

        public int? Permissions { set; get; }

        public bool IsActive { get; private set; }

        public DateTime CreatedDate { get; private set; }


        public clsUser()
        {
            EmployeeInfo = new clsEmployee();
            Mode = enMode.AddNew;
        }

        private clsUser(
            int UserID,
            int EmployeeID,
            string Username,
            string Password,
            int? Permissions,
            bool IsActive,
            DateTime CreatedDate)
        {
            this.UserID = UserID;
            this.EmployeeID = EmployeeID;
            this.Username = Username;
            this.Password = clsSymmetric.Decrypt(Password, ConfigurationManager.AppSettings["EncrytDecryptKey"]); 
            this.Permissions = Permissions;
            this.IsActive = IsActive;
            this.CreatedDate = CreatedDate;

            EmployeeInfo = clsEmployee.FindEmployee(EmployeeID);

            Mode = enMode.Update;
        }

        private bool AddNewUser()
        {
            if (!this.EmployeeInfo.IsActive) return false;

            string EncryptPassword 
                = clsSymmetric.Encrypt(this.Password, ConfigurationManager.AppSettings["EncrytDecryptKey"]);

            int? UserID = clsUserDataAccess.AddNewUser(
                this.EmployeeID,
                this.Username,
                EncryptPassword,
                this.Permissions
              );

            if (UserID != null)
            {
                this.UserID = UserID.Value;
                return true;
            }

            return false;
        }

        private bool UpdateUser()
        {

            return clsUserDataAccess.UpdateUser(
                this.UserID,
                this.EmployeeID,
                this.Username,
                this.Permissions
                );
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                    return false;

                case enMode.Update:
                    return UpdateUser();
            }

            return false;
        }

        public static clsUser FindUser(int UserID)
        {
            int EmployeeID = 0;
            string Username = "";
            string EncryptPassword = "";
            int? Permissions = null;
            bool IsActive = false;
            DateTime CreatedDate = DateTime.Now;

            if (clsUserDataAccess.FindUser(
                UserID,
                ref EmployeeID,
                ref Username,
                ref EncryptPassword,
                ref Permissions,
                ref IsActive,
                ref CreatedDate))
            {
                
                return new clsUser(
                    UserID,
                    EmployeeID,
                    Username,
                    EncryptPassword,
                    Permissions,
                    IsActive,
                    CreatedDate);
            }

            return null;
        }

        public static clsUser FindUserByUsername(string Username)
        {
            int UserID = 0;
            int EmployeeID = 0;
            string EncryptPassword = "";
            int? Permissions = null;
            bool IsActive = false;
            DateTime CreatedDate = DateTime.Now;

            if (clsUserDataAccess.FindUserByUsername(
                Username,
                ref UserID,
                ref EmployeeID,
                ref EncryptPassword,
                ref Permissions,
                ref IsActive,
                ref CreatedDate))
            {

                return new clsUser(
                    UserID,
                    EmployeeID,
                    Username,
                    EncryptPassword,
                    Permissions,
                    IsActive,
                    CreatedDate);
            }

            return null;
        }

        public static clsUser FindByUsernameAndPassword(string Username,string Password)
        {
            int UserID = 0;
            int EmployeeID = 0;
            int? Permissions = null;
            bool IsActive = false;
            DateTime CreatedDate = DateTime.Now;

            string EncryptPassword =
                clsSymmetric.Encrypt(Password, ConfigurationManager.AppSettings["EncrytDecryptKey"]);

            if (clsUserDataAccess.FindByUsernameAndPassword(
                Username,
                ref UserID,
                ref EmployeeID,
                EncryptPassword,
                ref Permissions,
                ref IsActive,
                ref CreatedDate))
            {
          
               
                return new clsUser(
                    UserID,
                    EmployeeID,
                    Username,
                    EncryptPassword,
                    Permissions,
                    IsActive,
                    CreatedDate);
            }

            return null;
        }
        public static bool IsUserExists(int UserID)
        {
            return clsUserDataAccess.IsUserExists(UserID);
        }

        public static bool IsUsernameExists(string Username)
        {
            return clsUserDataAccess.IsUsernameExists(Username);
        }

        public static bool DeleteUser(int UserID)
        {
            return clsUserDataAccess.DeleteUser(UserID);
        }

        public static bool IsEmployeeAlreadyAUser(int EmployeeID)
        {
            return clsUserDataAccess.IsEmployeeAlreadyAUser(EmployeeID);
        }

        public static Task<DataTable> GetUsersAsync(
            int NumberOfUsersEachPage,
            int NumberOfPage)
        {
            return clsUserDataAccess.GetUsersAsync(
                NumberOfUsersEachPage,
                NumberOfPage);
        }

        public bool Deactivate()
        {
            if(clsUserDataAccess.DeactivateUser(this.UserID))
            {
                this.IsActive = false;
                return true;
            }

            return true;
        }

        public bool Activate()
        {
            if (clsUserDataAccess.ActivateUser(this.UserID))
            {
                this.IsActive = true;
                return true;
            }

            return true;
        }

        public bool UpdatePassword(string NewPassword)
        {
            string EncryptPassword =
                clsSymmetric.Encrypt(NewPassword, ConfigurationManager.AppSettings["EncrytDecryptKey"]);

            if( clsUserDataAccess.UpdatePassword(this.UserID, EncryptPassword))
            {
                this.Password = NewPassword;
                return true;
            }

            return false;
        }
        public static Task<int> GetUsersNumberOfPagesAsync(
            int UsersEachPage)
        {
            return clsUserDataAccess.GetUsersNumberOfPagesAsync(
                UsersEachPage);
        }

        public static Task<DataTable> GetAccountsForAnEmployee(int EmployeeID)
        {
            return clsUserDataAccess.GetAccountsForAnEmployee(EmployeeID);
        }


    }
}
