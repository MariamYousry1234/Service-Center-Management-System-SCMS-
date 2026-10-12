using SCMS_Data_Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCMS_Business_Logic
{
    public class clsRepairUsedPart
    {

        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;

        public int RepairUsedPartID { set; get; }

        public int RepairOrderID { set; get; }

        public clsRepairOrder RepairOrderInfo;

        public int UsedPartID { set; get; }

        public clsSparePart UsedPartInfo;

        public int Quantity { set; get; }

        public float PartPrice { set; get; }

        public float TotalPrice { get; private set; }

        public DateTime UsedDate { get; private set; }

        public clsRepairUsedPart()
        {
            RepairUsedPartID = -1;
            RepairOrderID = -1;
            UsedPartID = -1;
            Quantity = 0;
            PartPrice = 0;
            TotalPrice = 0;
            UsedDate = DateTime.MinValue;

            Mode = enMode.AddNew;
        }

        private clsRepairUsedPart(
            int RepairUsedPartID,
            int RepairOrderID,
            int UsedPartID,
            int Quantity,
            float PartPrice,
            float TotalPrice,
            DateTime UsedDate)
        {
            this.RepairUsedPartID = RepairUsedPartID;
            this.RepairOrderID = RepairOrderID;
            this.UsedPartID = UsedPartID;
            this.Quantity = Quantity;
            this.PartPrice = PartPrice;
            this.TotalPrice = TotalPrice;
            this.UsedDate = UsedDate;

            RepairOrderInfo =
                clsRepairOrder.Find(RepairOrderID);

            UsedPartInfo =
                clsSparePart.FindSparePart(UsedPartID);

            Mode = enMode.Update;
        }

        private bool AddNewRepairUsedPart()
        {
            int? RepairUsedPartID =
                clsRepairUsedPartDataAccess.AddNewRepairUsedPart(
                    this.RepairOrderID,
                    this.UsedPartID,
                    this.Quantity,
                    this.PartPrice);

            if (RepairUsedPartID != null)
            {
                this.RepairUsedPartID =
                    RepairUsedPartID.Value;

                this.TotalPrice = this.Quantity * this.PartPrice;
                return true;
            }

            return false;
        }

        private bool UpdateRepairUsedPart()
        {
            return clsRepairUsedPartDataAccess.UpdateRepairUsedPart(
                this.RepairUsedPartID,
                this.RepairOrderID,
                this.UsedPartID,
                this.Quantity,
                this.PartPrice);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (AddNewRepairUsedPart())
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                    return false;

                case enMode.Update:

                    return UpdateRepairUsedPart();
            }

            return false;
        }

        public static clsRepairUsedPart FindRepairUsedPart(
            int RepairUsedPartID)
        {
            int RepairOrderID = -1;
            int UsedPartID = -1;
            int Quantity = 0;
            float PartPrice = 0;
            float TotalPrice = 0;
            DateTime UsedDate = DateTime.MinValue;


            if (clsRepairUsedPartDataAccess.FindRepairUsedPart(
                RepairUsedPartID,
                ref RepairOrderID,
                ref UsedPartID,
                ref Quantity,
                ref PartPrice,
                ref TotalPrice,
                ref UsedDate))
            {
                return new clsRepairUsedPart(
                    RepairUsedPartID,
                    RepairOrderID,
                    UsedPartID,
                    Quantity,
                    PartPrice,
                    TotalPrice,
                    UsedDate);
            }

            return null;
        }

        public static bool DeleteRepairUsedPart(
            int RepairUsedPartID)
        {
            return clsRepairUsedPartDataAccess
                .DeleteRepairUsedPart(RepairUsedPartID);
        }

        public static bool IsRepairUsedPartExists(
            int RepairUsedPartID)
        {
            return clsRepairUsedPartDataAccess
                .IsRepairUsedPartExists(RepairUsedPartID);
        }

        public static Task<DataTable> GetRepairUsedPartsAsync(
            int NumberOfRepairUsedPartsEachPage,
            int NumberOfPage)
        {
            return clsRepairUsedPartDataAccess
                .GetRepairUsedPartsAsync(
                    NumberOfRepairUsedPartsEachPage,
                    NumberOfPage);
        }

        public static Task<int> GetRepairUsedPartsNumberOfPagesAsync(
            int RepairUsedPartsEachPage)
        {
            return clsRepairUsedPartDataAccess
                .GetRepairUsedPartsNumberOfPagesAsync(
                    RepairUsedPartsEachPage);
        }

    }
}
