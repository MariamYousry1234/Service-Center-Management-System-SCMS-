using SCMS_Data_Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SCMS_Business_Logic
{
    public class clsRepairCost
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;

        public int RepairCostID { get; private set; }

        public int RepairOrderID { set; get; }

        public clsRepairOrder RepairOrderInfo;
        public float PartsCost { get;  private set; }

        public float LaborCost { get; private set; }

        public float? AdditionalServices { set; get; }

        public float? TaxAmount { set; get; }

        public float? DiscountAmount { set; get; }

        public float TotalRepairCost { get; private set; }

        public int CreatedByUserID { set; get; }
  
        public clsUser CreatedUserInfo;

        public DateTime CreatedDate { get; private set; }

        public clsRepairCost()
        {
            RepairCostID = -1;
            RepairOrderID = -1;

            PartsCost = 0;
            LaborCost = 0;
            AdditionalServices = 0;
            TaxAmount = 0;
            DiscountAmount = 0;
            TotalRepairCost = 0;

            CreatedByUserID = -1;
            CreatedUserInfo = null;

            Mode = enMode.AddNew;
        }


        private clsRepairCost(
            int RepairCostID,
            int RepairOrderID,
            float PartsCost,
            float LaborCost,
            float? AdditionalServices,
            float? TaxAmount,
            float? DiscountAmount,
            float TotalRepairCost,
            int CreatedByUserID,
            DateTime CreatedDate)
        {
            this.RepairCostID = RepairCostID;
            this.RepairOrderID = RepairOrderID;

            this.PartsCost = PartsCost;
            this.LaborCost = LaborCost;
            this.AdditionalServices = AdditionalServices;
            this.TaxAmount = TaxAmount;
            this.DiscountAmount = DiscountAmount;
            this.TotalRepairCost = TotalRepairCost;

            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;

            CreatedUserInfo = clsUser.FindUser(CreatedByUserID);
            RepairOrderInfo = clsRepairOrder.Find(RepairOrderID);

            Mode = enMode.Update;
        }


        private bool AddNewRepairCost()
        {
            float TotalRepairCost = 0;

            int? RepairCostID =
                clsRepairCostDataAccess.AddNewRepairCost(
                    this.RepairOrderID,
                    this.AdditionalServices,
                    this.TaxAmount,
                    this.DiscountAmount,
                    this.CreatedByUserID,
                    ref TotalRepairCost);

            if (RepairCostID != null)
            {
                this.RepairCostID = RepairCostID.Value;
                this.TotalRepairCost = TotalRepairCost;

                return true;
            }

            return false;
        }


        private bool UpdateRepairCost()
        {
            float TotalRepairCost = 0;

            if ( clsRepairCostDataAccess.UpdateRepairCost(
                this.RepairCostID,
                this.AdditionalServices,
                this.TaxAmount,
                this.DiscountAmount,
                ref TotalRepairCost))
            {
                this.TotalRepairCost = TotalRepairCost;
                return true;
            }

            return false;
        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (AddNewRepairCost())
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                    return false;


                case enMode.Update:

                    return UpdateRepairCost();
            }

            return false;
        }


        public static clsRepairCost FindRepairCost(int RepairCostID)
        {
            int RepairOrderID = -1;

            float PartsCost = 0;
            float LaborCost = 0;
            float? AdditionalServices = 0;
            float? TaxAmount = 0;
            float? DiscountAmount = 0;
            float TotalRepairCost = 0;

            int CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.MinValue;


            if (clsRepairCostDataAccess.FindRepairCost(
                RepairCostID,
                ref RepairOrderID,
                ref PartsCost,
                ref LaborCost,
                ref AdditionalServices,
                ref TaxAmount,
                ref DiscountAmount,
                ref TotalRepairCost,
                ref CreatedByUserID,
                ref CreatedDate))
            {
                return new clsRepairCost(
                    RepairCostID,
                    RepairOrderID,
                    PartsCost,
                    LaborCost,
                    AdditionalServices,
                    TaxAmount,
                    DiscountAmount,
                    TotalRepairCost,
                    CreatedByUserID,
                    CreatedDate);
            }

            return null;
        }


        public static clsRepairCost FindRepairCostByRepairOrderID(
            int RepairOrderID)
        {
            int RepairCostID = -1;

            float PartsCost = 0;
            float LaborCost = 0;
            float? AdditionalServices = 0;
            float? TaxAmount = 0;
            float? DiscountAmount = 0;
            float TotalRepairCost = 0;

            int CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.MinValue;


            if (clsRepairCostDataAccess.FindRepairCost(
                 ref RepairCostID,
                 RepairOrderID,
                ref PartsCost,
                ref LaborCost,
                ref AdditionalServices,
                ref TaxAmount,
                ref DiscountAmount,
                ref TotalRepairCost,
                ref CreatedByUserID,
                ref CreatedDate))
            {
                return new clsRepairCost(
                    RepairCostID,
                    RepairOrderID,
                    PartsCost,
                    LaborCost,
                    AdditionalServices,
                    TaxAmount,
                    DiscountAmount,
                    TotalRepairCost,
                    CreatedByUserID,
                    CreatedDate);
            }

            return null;
        }


        public static bool IsRepairCostExists(int RepairCostID)
        {
            return clsRepairCostDataAccess.IsRepairCostExists(
                RepairCostID);
        }


        public static bool IsRepairCostExistsByRepairOrderID(
            int RepairOrderID)
        {
            return clsRepairCostDataAccess.IsRepairCostExists(
                RepairOrderID);
        }

        public static bool DeleteRepairCost(int RepairCostID)
        {
            return clsRepairCostDataAccess.DeleteRepairCost(
                RepairCostID);
        }


        public static Task<DataTable> GetRepairCostsAsync()
        {
            return clsRepairCostDataAccess.GetRepairCostsAsync();
        }


        public static Task<int> GetRepairCostsNumberOfPagesAsync(
            int RepairCostsEachPage)
        {
            return clsRepairCostDataAccess.GetRepairCostsNumberOfPagesAsync(
                RepairCostsEachPage);
        }


    }
}
