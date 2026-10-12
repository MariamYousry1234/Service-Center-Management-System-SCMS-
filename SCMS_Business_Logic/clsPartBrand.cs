using SCMS_Data_Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCMS_Business_Logic
{
    public class clsPartBrand
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;

        public int PartBrandID { get; set; }

        public string PartBrandName { get; set; }


        public clsPartBrand()
        {
            PartBrandName = "";
            Mode = enMode.AddNew;
        }

        private clsPartBrand(
            int PartBrandID,
            string PartBrandName)
        {
            this.PartBrandID = PartBrandID;
            this.PartBrandName = PartBrandName;

            Mode = enMode.Update;
        }

        private bool AddNewPartBrand()
        {
            int? PartBrandID =
                clsPartBrandDataAccess.AddNewPartBrand(
                    this.PartBrandName);

            if (PartBrandID != null)
            {
                this.PartBrandID = PartBrandID.Value;
                return true;
            }

            return false;
        }

        private bool UpdatePartBrand()
        {
            return clsPartBrandDataAccess.UpdatePartBrand(
                this.PartBrandID,
                this.PartBrandName);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (AddNewPartBrand())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return UpdatePartBrand();
            }

            return false;
        }

        public static clsPartBrand FindPartBrand(int PartBrandID)
        {
            string PartBrandName = "";

            if (clsPartBrandDataAccess.FindPartBrand(
                PartBrandID,
                ref PartBrandName))
            {
                return new clsPartBrand(
                    PartBrandID,
                    PartBrandName);
            }

            return null;
        }
        public static clsPartBrand FindPartBrand(string PartBrandName)
        {
            int PartBrandID =0;

            if (clsPartBrandDataAccess.FindPartBrand(
                ref PartBrandID,
                 PartBrandName))
            {
                return new clsPartBrand(
                    PartBrandID,
                    PartBrandName);
            }

            return null;
        }
        public static bool DeletePartBrand(int PartBrandID)
        {
            return clsPartBrandDataAccess.DeletePartBrand(
                PartBrandID);
        }

        public static bool IsPartBrandExists(int PartBrandID)
        {
            return clsPartBrandDataAccess.IsPartBrandExists(
                PartBrandID);
        }

        public static Task<DataTable> GetPartBrandsAsync()
        {
            return clsPartBrandDataAccess.GetPartBrandsAsync();
        }

        public static Task<int> GetPartBrandsNumberOfPagesAsync(
            int PartBrandsEachPage)
        {
            return clsPartBrandDataAccess.GetPartBrandsNumberOfPagesAsync(
                PartBrandsEachPage);
        }

        public static int? GetPartBrandIDByName(string PartBrandName)
        {
            return clsPartBrandDataAccess.GetPartBrandIDByName(PartBrandName);
        }
    }
}
