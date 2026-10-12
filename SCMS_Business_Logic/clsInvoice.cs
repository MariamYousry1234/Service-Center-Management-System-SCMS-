using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SCMS_Data_Access;

namespace SCMS_Business_Logic
{
    public class clsInvoice
    {
        public enum enMode
        {
            AddNew = 1,
            Update = 2
        }
        enMode _Mode;

        public enum enPaymentStatus
        {
            Pending=1,
           PartiallyPaid=2,
           Paid=3
        }
        public int InvoiceID { get; private set; }

        public int RepairCostID { set; get; }

        public clsRepairCost RepairCostInfo;

        public DateTime IssueDate { get; private set; }

        public int CreatedByUserID { set; get; }

        public clsUser CreatedUserInfo;

        public enPaymentStatus PaymentStatus { get; private set; }

        public string txtPaymentSatus
        {
            get
            {
                switch (PaymentStatus)
                {
                    case enPaymentStatus.Pending:
                        return "Pending";

                    case enPaymentStatus.PartiallyPaid:
                        return "Partially Paid";

                    case enPaymentStatus.Paid:
                        return "Paid";

                    default:
                        return "Un Known";
                }
            }
        }
        public int? LastUpdatedUserID { set; get; }

        public clsUser LastUpdatedUserInfo;
        public clsInvoice()
        {
            InvoiceID = -1;
            RepairCostID = -1;
            IssueDate = DateTime.Now;
            CreatedByUserID = -1;
            LastUpdatedUserID = -1;

            RepairCostInfo = null;
            CreatedUserInfo = null;
            LastUpdatedUserInfo = null;

            _Mode = enMode.AddNew;
        }

        private clsInvoice(
            int InvoiceID,
            int RepairCostID,
            DateTime IssueDate,
            int CreatedByUserID,
            enPaymentStatus PaymentStatus,
            int? LastUpdatedUserID)
        {
            this.InvoiceID = InvoiceID;
            this.RepairCostID = RepairCostID;
            this.IssueDate = IssueDate;
            this.CreatedByUserID = CreatedByUserID;
            this.PaymentStatus = PaymentStatus;
            this.LastUpdatedUserID = LastUpdatedUserID;

            RepairCostInfo = clsRepairCost.FindRepairCost(RepairCostID);
            CreatedUserInfo = clsUser.FindUser(CreatedByUserID);

            if (LastUpdatedUserID != null)
                LastUpdatedUserInfo= clsUser.FindUser(LastUpdatedUserID.Value);
            _Mode = enMode.Update;
        }

        private bool _AddNewInvoice()
        {
            int? InvoiceID = clsInvoiceDataAccess.AddNewInvoice(
                RepairCostID,
                CreatedByUserID);

            if(InvoiceID != null)
            {
                this.InvoiceID = InvoiceID.Value;
                return true;
            }

            return false ;
        }

        private bool _UpdateInvoice()
        {
            return clsInvoiceDataAccess.UpdateInvoice(
                InvoiceID,
                RepairCostID,
                this.LastUpdatedUserID
                );
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:

                    if (_AddNewInvoice())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }

                    return false;

                case enMode.Update:

                    return _UpdateInvoice();
            }

            return false;
        }

        public static clsInvoice Find(int InvoiceID)
        {
            int RepairCostID = -1;
            DateTime IssueDate = DateTime.MinValue;
            int CreatedByUserID = -1;
            byte PaymentStatus = 0;
            int? LastUpdatedUserID = -1;

            bool IsFound = clsInvoiceDataAccess.FindInvoice(
                InvoiceID,
                ref RepairCostID,
                ref IssueDate,
                ref CreatedByUserID,
                ref PaymentStatus, 
                ref LastUpdatedUserID);

            if (IsFound)
            {
                return new clsInvoice(
                    InvoiceID,
                    RepairCostID,
                    IssueDate,
                    CreatedByUserID,
                    (enPaymentStatus)PaymentStatus,
                    LastUpdatedUserID);
            }

            return null;
        }

        public static clsInvoice FindByRepairOrderID(int RepairOrderID)
        {
            int InvoiceID = -1;
            int RepairCostID = -1;
            DateTime IssueDate = DateTime.MinValue;
            int CreatedByUserID = -1;
            byte PaymentStatus = 0;
            int? LastUpdatedUserID = -1;

            bool IsFound = clsInvoiceDataAccess.FindInvoice(
                RepairOrderID,
                ref InvoiceID,
                ref RepairCostID,
                ref IssueDate,
                ref CreatedByUserID,
                ref PaymentStatus,
                ref LastUpdatedUserID);

            if (IsFound)
            {
                return new clsInvoice(
                    InvoiceID,
                    RepairCostID,
                    IssueDate,
                    CreatedByUserID,
                    (enPaymentStatus)PaymentStatus,
                    LastUpdatedUserID);
            }

            return null;
        }

        public static bool Delete(int InvoiceID)
        {
            return clsInvoiceDataAccess.DeleteInvoice(InvoiceID);
        }

        public static bool IsInvoiceExists(int InvoiceID)
        {
            return clsInvoiceDataAccess.IsInvoiceExists(InvoiceID);
        }

        public static bool IsInvoiceExistsByRepairCostID(int RepairCostID)
        {
            return clsInvoiceDataAccess.IsInvoiceExistsByRepairCostID(
                RepairCostID);
        }

        public static Task<DataTable> GetInvoicesAsync(int NumberOfInvoicesEachPage,
            int NumberOfPage)
        {
            return clsInvoiceDataAccess.GetInvoicesAsync(NumberOfInvoicesEachPage,
             NumberOfPage);
        }

        public static Task<int> GetInvoicesNumberOfPagesAsync(
            int InvoicesEachPage)
        {
            return clsInvoiceDataAccess.GetInvoicesNumberOfPagesAsync(
                InvoicesEachPage);
        }
        public static Task<DataTable> GetAllInvoicesAwaitingPaymentAsync()
        {
            return clsInvoiceDataAccess.GetAllInvoicesAwaitingPaymentAsync();
        }

    }
}
