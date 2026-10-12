using SCMS_Data_Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCMS_Business_Logic
{
    public class clsSparePart
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;

        public int PartID { set; get; }

        public string PartName { set; get; }

        public float SellingPrice { set; get; }

        public int Quantity { set; get; }

        public byte MinimumStockLevel { set; get; }

        public bool IsActive { get; private set; }

        public int PartCategoryID { set; get; }
        public clsPartCategory PartCategoryInfo;

        public int PartBrandID { set; get; }
        public clsPartBrand PartBrandInfo;

        public int CreatedByUserID { set; get; }
        public clsUser CreatedUserInfo;

        public DateTime CreatedDate { get; private set; }

        public int? LastUpdatedUserID { set; get; }
        public clsUser LastUpdatedUserInfo;

        public DateTime? LastUpdatedDate { get; private set; }

        public clsSparePart()
        {
            PartID = -1;
            PartName = "";
            SellingPrice = 0;
            Quantity = 0;
            MinimumStockLevel = 0;
            IsActive = true;

            PartCategoryID = -1;
            PartBrandID = -1;

            CreatedByUserID = -1;

            Mode = enMode.AddNew;
        }

        private clsSparePart(
            int PartID,
            string PartName,
            float SellingPrice,
            int Quantity,
            byte MinimumStockLevel,
            bool IsActive,
            int PartCategoryID,
            int PartBrandID,
            int CreatedByUserID,
            DateTime CreatedDate,
            int? LastUpdatedUserID,
            DateTime? LastUpdatedDate)
        {
            this.PartID = PartID;
            this.PartName = PartName;
            this.SellingPrice = SellingPrice;
            this.Quantity = Quantity;
            this.MinimumStockLevel = MinimumStockLevel;
            this.IsActive = IsActive;

            this.PartCategoryID = PartCategoryID;
            this.PartBrandID = PartBrandID;

            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;

            this.LastUpdatedUserID = LastUpdatedUserID;
            this.LastUpdatedDate = LastUpdatedDate;

            PartCategoryInfo = clsPartCategory.FindPartCategory(PartCategoryID);
            PartBrandInfo = clsPartBrand.FindPartBrand(PartBrandID);
            CreatedUserInfo = clsUser.FindUser(CreatedByUserID);

            if (LastUpdatedUserID != null)
                LastUpdatedUserInfo = clsUser.FindUser(LastUpdatedUserID.Value);

            Mode = enMode.Update;
        }

        private bool AddNewSparePart()
        {
            int? PartID = clsSparePartDataAccess.AddNewSparePart(
                this.PartName,
                this.SellingPrice,
                this.Quantity,
                this.MinimumStockLevel,
                this.PartCategoryID,
                this.PartBrandID,
                this.CreatedByUserID);

            if (PartID != null)
            {
                this.PartID = PartID.Value;
                return true;
            }

            return false;
        }

        private bool UpdateSparePart()
        {
            return clsSparePartDataAccess.UpdateSparePart(
                this.PartID,
                this.PartName,
                this.SellingPrice,
                this.MinimumStockLevel,
                this.PartCategoryID,
                this.PartBrandID,
                this.LastUpdatedUserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (AddNewSparePart())
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                    return false;

                case enMode.Update:

                    return UpdateSparePart();
            }

            return false;
        }

        public static clsSparePart FindSparePart(int PartID)
        {
            string PartName = "";
            float SellingPrice = 0;
            int Quantity = 0;
            byte MinimumStockLevel = 0;
            bool IsActive = true;

            int PartCategoryID = -1;
            int PartBrandID = -1;

            int CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;

            int? LastUpdatedUserID = null;
            DateTime? LastUpdatedDate = null;

            if (clsSparePartDataAccess.FindSparePart(
                PartID,
                ref PartName,
                ref SellingPrice,
                ref Quantity,
                ref MinimumStockLevel,
                ref IsActive,
                ref PartCategoryID,
                ref PartBrandID,
                ref CreatedByUserID,
                ref CreatedDate,
                ref LastUpdatedUserID,
                ref LastUpdatedDate))
            {
                return new clsSparePart(
                    PartID,
                    PartName,
                    SellingPrice,
                    Quantity,
                    MinimumStockLevel,
                    IsActive,
                    PartCategoryID,
                    PartBrandID,
                    CreatedByUserID,
                    CreatedDate,
                    LastUpdatedUserID,
                    LastUpdatedDate);
            }

            return null;
        }


        public static clsSparePart FindSparePart(string PartName )
        {
            int  PartID = 0;
            float SellingPrice = 0;
            int Quantity = 0;
            byte MinimumStockLevel = 0;
            bool IsActive = true;

            int PartCategoryID = -1;
            int PartBrandID = -1;

            int CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;

            int? LastUpdatedUserID = null;
            DateTime? LastUpdatedDate = null;

            if (clsSparePartDataAccess.FindSparePart(
                ref  PartID,
                 PartName,
                ref SellingPrice,
                ref Quantity,
                ref MinimumStockLevel,
                ref IsActive,
                ref PartCategoryID,
                ref PartBrandID,
                ref CreatedByUserID,
                ref CreatedDate,
                ref LastUpdatedUserID,
                ref LastUpdatedDate))
            {
                return new clsSparePart(
                    PartID,
                    PartName,
                    SellingPrice,
                    Quantity,
                    MinimumStockLevel,
                    IsActive,
                    PartCategoryID,
                    PartBrandID,
                    CreatedByUserID,
                    CreatedDate,
                    LastUpdatedUserID,
                    LastUpdatedDate);
            }

            return null;
        }
        public static bool DeleteSparePart(int PartID)
        {
            return clsSparePartDataAccess.DeleteSparePart(PartID);
        }

        public static bool IsSparePartExists(int PartID)
        {
            return clsSparePartDataAccess.IsSparePartExists(PartID);
        }

        public static bool IsSparePartExists(string PartName)
        {
            return clsSparePartDataAccess.IsSparePartExists(PartName);
        }
        public bool Deactivate()
        {
            return clsSparePartDataAccess.DeactivateSparePart(this.PartID);
        }


        public bool Activate()
        {
            return clsSparePartDataAccess.ActivateSparePart(this.PartID);
        }

        public static Task<DataTable> GetSparePartsAsync(
            int NumberOfSparePartsEachPage,
            int NumberOfPage)
        {
            return clsSparePartDataAccess.GetSparePartsAsync(
                NumberOfSparePartsEachPage,
                NumberOfPage);
        }

        public static Task<int> GetSparePartsNumberOfPagesAsync(
            int SparePartsEachPage)
        {
            return clsSparePartDataAccess.GetSparePartsNumberOfPagesAsync(
                SparePartsEachPage);
        }

        public  Task <DataTable> GetAllPurchaseOperationsAsync()
        {
            return clsPurchase.GetAllPurchaseOperationsForPartAsync(this.PartID);
        }
    }
}
