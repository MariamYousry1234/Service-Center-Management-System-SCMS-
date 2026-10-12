using SCMS_Data_Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SCMS_Business_Logic
{
    public class clsSupplier
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;

        public int SupplierID { set; get; }

        public string SupplierName { set; get; }

        public string PhoneNumber { set; get; }

        public string? Address { set; get; }

        public bool IsActive { get; private set; }


        public clsSupplier()
        {
            SupplierID = -1;
            SupplierName = "";
            PhoneNumber = "";
            Address = null;
            IsActive = true;

            Mode = enMode.AddNew;
        }


        private clsSupplier(
            int SupplierID,
            string SupplierName,
            string PhoneNumber,
            string? Address,
            bool IsActive)
        {
            this.SupplierID = SupplierID;
            this.SupplierName = SupplierName;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
            this.IsActive = IsActive;

            Mode = enMode.Update;
        }


        private bool AddNewSupplier()
        {
            int? SupplierID =
                clsSupplierDataAccess.AddNewSupplier(
                    this.SupplierName,
                    this.PhoneNumber,
                    this.Address);

            if (SupplierID != null)
            {
                this.SupplierID = SupplierID.Value;
                return true;
            }

            return false;
        }


        private bool UpdateSupplier()
        {
            return clsSupplierDataAccess.UpdateSupplier(
                this.SupplierID,
                this.SupplierName,
                this.PhoneNumber,
                this.Address);
        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (AddNewSupplier())
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                    return false;

                case enMode.Update:

                    return UpdateSupplier();
            }

            return false;
        }


        public static clsSupplier FindSupplier(int SupplierID)
        {
            string SupplierName = "";
            string PhoneNumber = "";
            string? Address = null;
            bool IsActive = false;

            if (clsSupplierDataAccess.FindSupplier(
                SupplierID,
                ref SupplierName,
                ref PhoneNumber,
                ref Address,
                ref IsActive))
            {
                return new clsSupplier(
                    SupplierID,
                    SupplierName,
                    PhoneNumber,
                    Address,
                    IsActive);
            }

            return null;
        }

        public static clsSupplier FindSupplierByPhoneNumber(string PhoneNumber)
        { 

            string SupplierName = "";
            int SupplierID =0;
            string? Address = null;
            bool IsActive = false;

            if (clsSupplierDataAccess.FindSupplier(
                ref SupplierID,
                ref SupplierName,
                 PhoneNumber,
                ref Address,
                ref IsActive))
            {
                return new clsSupplier(
                    SupplierID,
                    SupplierName,
                    PhoneNumber,
                    Address,
                    IsActive);
            }

            return null;
        }

        public static clsSupplier FindSupplier(string SupplierName)
        {

            string PhoneNumber = "";
            int SupplierID = 0;
            string? Address = null;
            bool IsActive = false;

            if (clsSupplierDataAccess.FindSupplier(
                ref SupplierID,
                 SupplierName,
                ref PhoneNumber,
                ref Address,
                ref IsActive))
            {
                return new clsSupplier(
                    SupplierID,
                    SupplierName,
                    PhoneNumber,
                    Address,
                    IsActive);
            }

            return null;
        }
        public static bool DeleteSupplier(int SupplierID)
        {
            return clsSupplierDataAccess.DeleteSupplier(SupplierID);
        }


        public static bool IsSupplierExists(int SupplierID)
        {
            return clsSupplierDataAccess.IsSupplierExists(SupplierID);
        }
        public static bool IsSupplierExists(string SupplierName)
        {
            return clsSupplierDataAccess.IsSupplierExists(SupplierName);
        }

        public  bool Deactivate()
        {
            return clsSupplierDataAccess.DeactivateSupplier(this.SupplierID);
        }

        public  bool Activate()
        {
            return clsSupplierDataAccess.ActivateSupplier(this.SupplierID);
        }

        public static Task<DataTable> GetSuppliersAsync()
        {
            return clsSupplierDataAccess.GetSuppliersAsync();
        }


        public static Task<int> GetSuppliersNumberOfPagesAsync(
            int SuppliersEachPage)
        {
            return clsSupplierDataAccess.GetSuppliersNumberOfPagesAsync(
                SuppliersEachPage);
        }



    }
}
