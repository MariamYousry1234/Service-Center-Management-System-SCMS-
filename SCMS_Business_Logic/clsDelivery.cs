using SCMS_Data_Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SCMS_Business_Logic
{
    public  class clsDelivery
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        public int DeliveryID { get; private set; }

        public int RepairOrderID { set; get; }

        public DateTime DeliveryDate { get; private set; }

        public int DeliveredByUserID { set; get; }

        public clsUser DeliveredUserInfo;

        public string? DeliveryNotes { set; get; }

        public DateTime? WarrantyEndDate { set; get; }

        public string? AfterRepairImagePath { set; get;}

        public clsDelivery()
        {
            DeliveryID = -1;
            RepairOrderID = -1;
            DeliveryDate = DateTime.Now;
            DeliveredByUserID = -1;
            WarrantyEndDate = null;
            DeliveryNotes = null;
            AfterRepairImagePath = null;

            Mode = enMode.AddNew;
        }

        private clsDelivery(
            int DeliveryID,
            int RepairOrderID,
            DateTime DeliveryDate,
            int DeliveredByUserID,
            string? DeliveryNotes,
            DateTime? WarrantyEndDate,
            string? AfterRepairImagePath)
        {
            this.DeliveryID = DeliveryID;
            this.RepairOrderID = RepairOrderID;
            this.DeliveryDate = DeliveryDate;
            this.DeliveredByUserID = DeliveredByUserID;
            this.DeliveryNotes = DeliveryNotes;
            this.WarrantyEndDate = WarrantyEndDate;
            this.AfterRepairImagePath = AfterRepairImagePath;

            DeliveredUserInfo = clsUser.FindUser(DeliveredByUserID);

            Mode = enMode.Update;
        }

        private bool AddNewDelivery()
        {
            int? DeliveryID = clsDeliveryDataAccess.AddNewDelivery(
                this.RepairOrderID,
                this.DeliveredByUserID,
                this.DeliveryNotes,
                this.WarrantyEndDate,
                this.AfterRepairImagePath);

            if (DeliveryID != null)
            {
                this.DeliveryID = DeliveryID.Value;
                return true;
            }

            return false;
        }

        private bool UpdateDelivery()
        {
            return clsDeliveryDataAccess.UpdateDelivery(
                this.DeliveryID,
                this.RepairOrderID,
                this.DeliveryNotes,
                this.WarrantyEndDate,
                this.AfterRepairImagePath);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (AddNewDelivery())
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                    return false;

                case enMode.Update:

                    return UpdateDelivery();
            }

            return false;
        }

        public static clsDelivery FindDelivery(int DeliveryID)
        {
            int RepairOrderID = -1;
            DateTime DeliveryDate = DateTime.Now;
            int DeliveredByUserID = -1;
            string? DeliveryNotes = null;
            DateTime? WarrantyEndDate = DateTime.MinValue;
            string? AfterRepairImagePath = null;

            if (clsDeliveryDataAccess.FindDelivery(
                DeliveryID,
                ref RepairOrderID,
                ref DeliveryDate,
                ref DeliveredByUserID,
                ref DeliveryNotes,
                ref WarrantyEndDate,
                ref AfterRepairImagePath))
            {
                return new clsDelivery(
                    DeliveryID,
                    RepairOrderID,
                    DeliveryDate,
                    DeliveredByUserID,
                    DeliveryNotes,
                    WarrantyEndDate,
                    AfterRepairImagePath);
            }

            return null;
        }

        public static clsDelivery FindDeliveryByRepairOrderID(int RepairOrderID)
        {
            int DeliveryID = -1;
            DateTime DeliveryDate = DateTime.Now;
            int DeliveredByUserID = -1;
            string? DeliveryNotes = null;
            DateTime? WarrantyEndDate = DateTime.MinValue;
            string? AfterRepairImagePath = null;

            if (clsDeliveryDataAccess.FindDeliveryByRepairOrderID(
                RepairOrderID,
                ref DeliveryID,
                ref DeliveryDate,
                ref DeliveredByUserID,
                ref DeliveryNotes,
                ref WarrantyEndDate,
                ref AfterRepairImagePath))
            {
                return new clsDelivery(
                    DeliveryID,
                    RepairOrderID,
                    DeliveryDate,
                    DeliveredByUserID,
                    DeliveryNotes,
                    WarrantyEndDate,
                    AfterRepairImagePath);
            }

            return null;
        }

        public static bool DeleteDelivery(int DeliveryID)
        {
            return clsDeliveryDataAccess.DeleteDelivery(DeliveryID);
        }

        public static bool IsDeliveryExists(int DeliveryID)
        {
            return clsDeliveryDataAccess.IsDeliveryExists(DeliveryID);
        }

        public static bool IsDeliveryExistsByRepairOrderID(
     int RepairOrderID)
        {
            return clsDeliveryDataAccess.IsDeliveryExistsByRepairOrderID(RepairOrderID);
        }

        public static Task<DataTable> GetDeliveriesAsync(
            int NumberOfDeliveriesEachPage,
            int NumberOfPage)
        {
            return clsDeliveryDataAccess.GetDeliveriesAsync(
                NumberOfDeliveriesEachPage,
                NumberOfPage);
        }

        public static Task<int> GetDeliveriesNumberOfPagesAsync(
            int DeliveriesEachPage)
        {
            return clsDeliveryDataAccess.GetDeliveriesNumberOfPagesAsync(
                DeliveriesEachPage);
        }

    }
}
