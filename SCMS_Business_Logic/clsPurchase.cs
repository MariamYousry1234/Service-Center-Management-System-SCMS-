using SCMS_Data_Access;
using System;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SCMS_Business_Logic
{
    public class clsPurchase
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;

        public int PurchaseID { set; get; }

        public int PartID { set; get; }
        public clsSparePart PartInfo;

        public DateTime PurchaseDate { get; private set; }

        public int Quantity { set; get; }

        public float PurchasePrice { set; get; }

        public int SupplierID { set; get; }
        public clsSupplier SupplierInfo;

        public float TotalPrice { get; private set; }

        public int CreatedByUserID { set; get; }
        public clsUser CreatedUserInfo;

        public int? LastUpdatedUserID { set; get; }
        public clsUser LastUpdatedUserInfo;

        public DateTime? LastUpdatedDate { get; private set; }

        public bool IsCancelled { get; private set; }

        public clsPurchase()
        {
            PurchaseID = -1;
            PartID = -1;
            PurchaseDate = DateTime.Now;
            Quantity = 0;
            PurchasePrice = 0;
            SupplierID = -1;
            TotalPrice = 0;
            CreatedByUserID = -1;
            Mode = enMode.AddNew;
        }

        private clsPurchase(
            int PurchaseID,
            int PartID,
            DateTime PurchaseDate,
            int Quantity,
            float PurchasePrice,
            int SupplierID,
            float TotalPrice,
            int CreatedByUserID,
            DateTime? LastUpdatedDate,
            int? LastUpdatedUserID,
            bool IsCancellled
            )
        {
            this.PurchaseID = PurchaseID;
            this.PartID = PartID;
            this.PurchaseDate = PurchaseDate;
            this.Quantity = Quantity;
            this.PurchasePrice = PurchasePrice;
            this.SupplierID = SupplierID;
            this.TotalPrice = TotalPrice;
            this.CreatedByUserID = CreatedByUserID;
            this.LastUpdatedDate = LastUpdatedDate;
            this.LastUpdatedUserID = LastUpdatedUserID;
            this.IsCancelled = IsCancellled;

            PartInfo = clsSparePart.FindSparePart(PartID);
            SupplierInfo = clsSupplier.FindSupplier(SupplierID);
            CreatedUserInfo = clsUser.FindUser(CreatedByUserID);

            if (LastUpdatedUserID != null)
                LastUpdatedUserInfo = clsUser.FindUser(LastUpdatedUserID.Value);

            Mode = enMode.Update;
        }

        private bool AddNewPurchase()
        {
            int? PurchaseID = clsPurchaseDataAccess.AddNewPurchase(
                this.PartID,
                this.PurchaseDate,
                this.Quantity,
                this.PurchasePrice,
                this.SupplierID,
                this.CreatedByUserID);

            if (PurchaseID != null)
            {
                this.PurchaseID = PurchaseID.Value;
                return true;
            }

            return false;
        }

        private bool UpdatePurchase()
        {
            return clsPurchaseDataAccess.UpdatePurchase(
                this.PurchaseID,
                this.PartID,
                this.PurchaseDate,
                this.Quantity,
                this.PurchasePrice,
                this.SupplierID,
                this.LastUpdatedUserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (AddNewPurchase())
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                    return false;

                case enMode.Update:

                    return UpdatePurchase();
            }

            return false;
        }

        public static clsPurchase FindPurchase(int PurchaseID)
        {
            int PartID = -1;
            DateTime PurchaseDate = DateTime.Now;
            int Quantity = 0;
            float PurchasePrice = 0;
            int SupplierID = -1;
            float TotalPrice = 0;
            int CreatedByUserID = -1;
            DateTime? LastUpdatedDate = null;
            int? LastUpdatedUserID = null;
            bool IsCancelled = false;

            if (clsPurchaseDataAccess.FindPurchase(
                PurchaseID,
                ref PartID,
                ref PurchaseDate,
                ref Quantity,
                ref PurchasePrice,
                ref SupplierID,
                ref TotalPrice,
                ref CreatedByUserID,
                ref LastUpdatedDate,
                ref LastUpdatedUserID,
                ref IsCancelled))
            {
                return new clsPurchase(
                    PurchaseID,
                    PartID,
                    PurchaseDate,
                    Quantity,
                    PurchasePrice,
                    SupplierID,
                    TotalPrice,
                    CreatedByUserID,
                    LastUpdatedDate,
                    LastUpdatedUserID,
                    IsCancelled);
            }

            return null;
        }

        public static bool DeletePurchase(int PurchaseID)
        {
            return clsPurchaseDataAccess.DeletePurchase(PurchaseID);
        }

        public static bool IsPurchaseExists(int PurchaseID)
        {
            return clsPurchaseDataAccess.IsPurchaseExists(PurchaseID);
        }

        public static Task<DataTable> GetPurchasesAsync(
            int NumberOfPurchasesEachPage,
            int NumberOfPage)
        {
            return clsPurchaseDataAccess.GetPurchasesAsync(
                NumberOfPurchasesEachPage,
                NumberOfPage);
        }

        public static Task<int> GetPurchasesNumberOfPagesAsync(
            int PurchasesEachPage)
        {
            return clsPurchaseDataAccess.GetPurchasesNumberOfPagesAsync(
                PurchasesEachPage);
        }

        public bool Cancel(int CancelledByUserID)
        {
            if(clsPurchaseDataAccess.CancelPurchase(this.PurchaseID,CancelledByUserID))
            {
                this.IsCancelled = true;
                return true;
            }

            return false;
        }

        public static Task<DataTable> GetAllPurchaseOperationsForPartAsync(int PartID)
        {
            return clsPurchaseDataAccess.GetAllPurchaseOperationsForPartAsync(PartID);
        }
      }
}
