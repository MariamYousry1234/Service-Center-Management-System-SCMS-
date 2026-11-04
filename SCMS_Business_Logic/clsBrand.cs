using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCMS_Data_Access;

namespace SCMS_Business_Logic
{
    public class clsBrand
    {
        public enum enMode { AddNew = 1, Update = 2 }

        public enMode Mode = enMode.AddNew;

        public int BrandID { set; get; }

        public string BrandName { set; get; }

        public bool HasModels
        {
            get
            {
                return clsBrandDataAccess.IsBrandHasModels(this.BrandID);
            }

        }

        public clsBrand()
        {
            this.BrandName = "";
            this.Mode = enMode.AddNew;
        }


        private clsBrand(int BrandID, string BrandName)
        {
            this.BrandID = BrandID;
            this.BrandName = BrandName;

            this.Mode = enMode.Update;
        }


        private bool AddNewBrand()
        {
            int? BrandID = clsBrandDataAccess.AddNewBrand(
                this.BrandName);

            if (BrandID != null)
            {
                this.BrandID = (int)BrandID;
                return true;
            }

            return false;
        }


        private bool UpdateBrand()
        {
            return clsBrandDataAccess.UpdateBrand(
                this.BrandID,
                this.BrandName);
        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        if (AddNewBrand())
                        {
                            Mode = enMode.Update;
                            return true;
                        }

                        return false;
                    }

                case enMode.Update:
                    {
                        return UpdateBrand();
                    }
            }

            return false;
        }


        public static clsBrand FindBrand(int BrandID)
        {
            string BrandName = "";

            if (clsBrandDataAccess.FindBrand(
                BrandID,
                ref BrandName))
            {
                return new clsBrand(
                    BrandID,
                    BrandName);
            }

            return null;
        }

        public static clsBrand FindBrand(string BrandName)
        {
            int BrandID =0;

            if (clsBrandDataAccess.FindBrand(
               ref BrandID,
                BrandName))
            {
                return new clsBrand(
                    BrandID,
                    BrandName);
            }

            return null;
        }

        public static bool IsBrandExists(int BrandID)
        {
            return clsBrandDataAccess.IsBrandExists(BrandID);
        }


        public static int? GetBrandIDByBrandName(string BrandName)
        {
            return clsBrandDataAccess.GetBrandIDByBrandName(BrandName);
        }

        public static bool DeleteBrand(int BrandID)
        {
            return clsBrandDataAccess.DeleteBrand(BrandID);
        }


        public static Task<DataTable> GetBrandsAsync(
            int NumberOfBrandsEachPage,
            int NumberOfPage)
        {
            return clsBrandDataAccess.GetBrandsAsync(
                NumberOfBrandsEachPage,
                NumberOfPage);
        }


        public static Task<int> GetBrandsNumberOfPagesAsync(
            int BrandsEachPage)
        {
            return clsBrandDataAccess.GetBrandsNumberOfPagesAsync(
                BrandsEachPage);
        }

        public static Task<DataTable> GetAllBrandNamesAsync()
        {
            return clsBrandDataAccess.GetAllBrandNamesAsync();
        }
    }
}