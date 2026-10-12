using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCMS_Data_Access;

namespace SCMS_Business_Logic
{
    public class clsPartCategory
    {
        public enum enMode { AddNew = 1, Update = 2 }

        public enMode Mode = enMode.AddNew;

        public int PartCategoryID { get; set; }

        public string PartCategoryName { get; set; }


        public clsPartCategory()
        {
            PartCategoryName = "";
            Mode = enMode.AddNew;
        }


        private clsPartCategory(
            int PartCategoryID,
            string PartCategoryName)
        {
            this.PartCategoryID = PartCategoryID;
            this.PartCategoryName = PartCategoryName;

            Mode = enMode.Update;
        }


        private bool AddNewPartCategory()
        {
            int? PartCategoryID =
                clsPartCategoryDataAccess.AddNewPartCategory(
                    this.PartCategoryName);

            if (PartCategoryID != null)
            {
                this.PartCategoryID = PartCategoryID.Value;
                return true;
            }

            return false;
        }


        private bool UpdatePartCategory()
        {
            return clsPartCategoryDataAccess.UpdatePartCategory(
                this.PartCategoryID,
                this.PartCategoryName);
        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        if (AddNewPartCategory())
                        {
                            Mode = enMode.Update;
                            return true;
                        }

                        return false;
                    }

                case enMode.Update:
                    {
                        return UpdatePartCategory();
                    }
            }

            return false;
        }


        public static clsPartCategory FindPartCategory(
            int PartCategoryID)
        {
            string PartCategoryName = "";

            if (clsPartCategoryDataAccess.FindPartCategory(
                PartCategoryID,
                ref PartCategoryName))
            {
                return new clsPartCategory(
                    PartCategoryID,
                    PartCategoryName);
            }

            return null;
        }

        public static clsPartCategory FindPartCategory(
            string PartCategoryName)
        {
            int PartCategoryID = 0;

            if (clsPartCategoryDataAccess.FindPartCategoryByName(
                ref PartCategoryID,
                 PartCategoryName))
            {
                return new clsPartCategory(
                    PartCategoryID,
                    PartCategoryName);
            }

            return null;
        }
        public static bool DeletePartCategory(
            int PartCategoryID)
        {
            return clsPartCategoryDataAccess.DeletePartCategory(
                PartCategoryID);
        }


        public static bool IsPartCategoryExists(
            int PartCategoryID)
        {
            return clsPartCategoryDataAccess.IsPartCategoryExists(
                PartCategoryID);
        }


        public static Task<DataTable> GetPartCategoriesAsync()
        {
            return clsPartCategoryDataAccess.GetPartCategoriesAsync();
        }


        public static Task<int> GetPartCategoriesNumberOfPagesAsync(
            int PartCategoriesEachPage)
        {
            return clsPartCategoryDataAccess.GetPartCategoriesNumberOfPagesAsync(
                PartCategoriesEachPage);
        }

        public static int? GetPartCategoryIDByName(string PartCategoryName)
        {
            return clsPartCategoryDataAccess.GetPartCategoryIDByName(PartCategoryName);
        }
    }
}
