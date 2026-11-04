using SCMS_Data_Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SCMS_Business_Logic
{
    public class clsRepairOrder
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode;
        public enum enPriority { Low = 1, Medium = 2, Urgent = 3 }
        public enum enStatus
        {
            WaitingForDiagnosis = 1,
            WaitingForCustomerApproval = 2,
            Approval = 3,
            UnderRepair = 4,
            RepairCostDetermined = 5,
            InvoiceIssuing = 6,
            ReadyForDelivery = 7,
            Delivered = 8,
            Cancelled = 9,
            Rejected = 10
        }
        public int RepairOrderID { get; private set; }

        public DateTime DateReceived { get; private set; }

        public string? ProblemDescription { set; get; }

        public enPriority Priority { set; get; }

        public string txtPriority
        {
            get
            {
                switch (Priority)
                {
                    case enPriority.Low:
                        return "Low";

                    case enPriority.Medium:
                        return "Medium";

                    case enPriority.Urgent:
                        return "Urgent";
                    default:
                        return "Un Known";
                }
            }
        }
        public enStatus Status { get; private set; }

        public string txtStatus
        {
            get
            {
                return _GetStringStatus();
            }
        }


        public string? Notes { set; get; }

        public int AssignedTechnicianID { set; get; }

        public clsTechnician AssignedTechnicianInfo;

        public int DeviceID { set; get; }

        public clsDevice DeviceInfo;

        public int CreatedByUserID { set; get; }

        public clsUser CreatedUserInfo;

        public int? LastUpdatedUserID { set; get; }

        public clsUser? LastUpdatedUserInfo;

        public DateTime? LastUpdatedDate { get; private set; }

        public string? BeforeRepairImagePath { set; get; }

       
        public clsDiagnosis? DiagnosisInfo;

        public bool HasRepairCost
        {
            get
            {

                return _HasRepairCost();

            }
        }

        public bool HasInvoice
        {
            get
            {
                return _HasInvoice();
            }
        }

        public float TotalUsedPartsPrice
        {
            get
            {
                return _GetTotalPriceForAllUsedParts();
            }
        }

        public bool HasPayments
        {
            get
            {
                return _IsRepairOrderHasPayments();
            }
        }

        public float? PaymentRemaining
        {
            get
            {
                return _GetPaymentRemainingForRepairOrder();
            }
        }

        public clsDelivery? DeliveryInfo;

        public bool IsDelivered
        {
            get
            {
                return DeliveryInfo != null;
            }
        }

        public DateTime? RepairCompletionDate { get; private set; }

        public clsRepairOrder()
        {
            AssignedTechnicianInfo = new clsTechnician();
            DeviceInfo = new clsDevice();
            CreatedUserInfo = new clsUser();
            LastUpdatedUserInfo = null;
            DiagnosisInfo = null;
            DeliveryInfo = null;
     
            _Mode = enMode.AddNew;
        }

        private clsRepairOrder(int RepairOrderID,
        DateTime DateReceived,
        string? ProblemDescription,
        byte Priority,
        byte Status,
        string? Notes,
        int AssignedTechnicianID,
       int DeviceID,
       int CreatedByUserID,
       int? LastUpdatedUserID,
       DateTime? LastUpdatedDate,
       string? BeforeRepairImagePath,
       DateTime? RepairCompletionDate
   )
        {
            this.RepairOrderID = RepairOrderID;
            this.DateReceived = DateReceived;
            this.ProblemDescription = ProblemDescription;
            this.Priority = (enPriority)Priority;
            this.Status = (enStatus)Status;
            this.Notes = Notes;
            this.AssignedTechnicianID = AssignedTechnicianID;
            this.DeviceID = DeviceID;
            this.CreatedByUserID = CreatedByUserID;
            this.LastUpdatedUserID = LastUpdatedUserID;
            this.LastUpdatedDate = LastUpdatedDate;
            this.BeforeRepairImagePath = BeforeRepairImagePath;
            this.RepairCompletionDate = RepairCompletionDate;

            AssignedTechnicianInfo = clsTechnician.FindTechnician(AssignedTechnicianID);

            DeviceInfo = clsDevice.FindDevice(DeviceID);
            CreatedUserInfo = clsUser.FindUser(CreatedByUserID);

            if (LastUpdatedUserID != null)
                LastUpdatedUserInfo = clsUser.FindUser(LastUpdatedUserID.Value);


            this.DiagnosisInfo = clsDiagnosis.FindDiagnosisByRepairOrder(RepairOrderID);
            this.DeliveryInfo = clsDelivery.FindDeliveryByRepairOrderID(RepairOrderID);
          
            _Mode = enMode.Update;
        }
        public static bool IsRepairOrderExists(int RepairOrder)
        {
            return clsRepairOrderDataAccess.IsRepairOrderExists(RepairOrder);
        }

        private bool _AddNewRepairOrder()
        {

            int? RepairOrderID = clsRepairOrderDataAccess.AddNewRepairOrder(this.ProblemDescription,
               (byte)this.Priority, this.Notes, this.AssignedTechnicianID, this.DeviceID,
                this.CreatedByUserID, this.BeforeRepairImagePath);


            if (RepairOrderID != null)
            {
                this.RepairOrderID = RepairOrderID.Value;
                return true;
            }

            return false;
        }

        private bool _UpdateRepairOrder()
        {
            return clsRepairOrderDataAccess.UpdateRepairOrder(this.RepairOrderID, this.ProblemDescription,
                  (byte)this.Priority,
                  this.Notes, this.LastUpdatedUserID, this.BeforeRepairImagePath);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewRepairOrder())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
                    }
                    break;

                case enMode.Update:
                    return _UpdateRepairOrder();
            }
            return false;
        }

        public static clsRepairOrder? Find(int RepairOrderID)
        {
            DateTime DateReceived = DateTime.Now;
            string? ProblemDescription = null;
            byte Priority = 0;
            byte Status = 0;

            string? Notes = null;
            int AssignedTechnicianID = 0;

            int DeviceID = 0;
            int CreatedByUserID = 0;
            int? LastUpdatedUserID = null;
            DateTime? LastUpdatedDate = null;
            string? BeforeRepairImagePath = null;
            DateTime? RepairCompletionDate = DateTime.MinValue;

            if (clsRepairOrderDataAccess.FindRepairOrder(
                RepairOrderID,
                ref DateReceived,
                ref ProblemDescription,
                ref Priority,
                ref Status,
                ref Notes,
                ref AssignedTechnicianID,
                ref DeviceID,
                ref CreatedByUserID,
                ref LastUpdatedUserID,
                ref LastUpdatedDate,
                ref BeforeRepairImagePath,
                ref RepairCompletionDate
              ))
            {
                return new clsRepairOrder(
                    RepairOrderID,
                    DateReceived,
                    ProblemDescription,
                    Priority,
                    Status,
                    Notes,
                    AssignedTechnicianID,
                    DeviceID,
                    CreatedByUserID,
                    LastUpdatedUserID,
                    LastUpdatedDate,
                    BeforeRepairImagePath,
                    RepairCompletionDate
                );
            }

            return null;
        }

        private string _GetStringStatus()
        {
            switch (Status)
            {
                case enStatus.WaitingForDiagnosis:
                    return "Waiting For Diagnosis";

                case enStatus.WaitingForCustomerApproval:
                    return "Waiting For Customer Approval";

                case enStatus.Approval:
                    return "Approved";

                case enStatus.UnderRepair:
                    return "Under Repair";

                case enStatus.RepairCostDetermined:
                    return "Repair Cost Determined";

                case enStatus.InvoiceIssuing:
                    return "Invoice Issuing";


                case enStatus.ReadyForDelivery:
                    return "Ready For Delivery";

                case enStatus.Delivered:
                    return "Delivered";

                case enStatus.Cancelled:
                    return "Cancelled";

                case enStatus.Rejected:
                    return "Rejected";

                default:
                    return "Unknown";
            }
        }
        public static Task<DataTable> GetRepairOrdersAsync(int NumberOfRepairOrdersEachPage,
          int NumberOfPage)
        {
            return clsRepairOrderDataAccess.GetRepairOrdersAsync(NumberOfRepairOrdersEachPage, NumberOfPage);
        }

        public static Task<int> GetRepairOrdersNumberPages(int RepairOrdersEachPage)
        {
            return clsRepairOrderDataAccess.GetRepairOrdersNumberPages(RepairOrdersEachPage);
        }

        public bool Cancel(int CancelByUserID)
        {
            return clsRepairOrderDataAccess.CancelRepairOrder(this.RepairOrderID, CancelByUserID);
        }

        public static Task<DataTable> GetAllRepairOrdersForCustomerAsync(int CustomerID)
        {
            return clsRepairOrderDataAccess.GetAllRepairOrdersForCustomerAsync(CustomerID);
        }


        public static Task<DataTable> GetAllAssignedROrdersForTechnicianAsync(int TechnicianID)
        {
            return clsRepairOrderDataAccess.GetAllAssignedROrdersForTechnicianAsync(TechnicianID);
        }

        public static Task<DataTable> GetAllCompletedOrdersForTechnicianAsync(int TechnicianID)
        {
            return clsRepairOrderDataAccess.GetAllCompletedOrdersForTechnicianAsync(TechnicianID);
        }

        public static Task<DataTable> GetAllCurrentWorkloadOrdersForTechnicianAsync(int TechnicianID)
        {
            return clsRepairOrderDataAccess.GetAllCurrentWorkloadOrdersForTechnicianAsync(TechnicianID);
        }

        public Task<DataTable> GetHistoryAsync()
        {
            return clsRepairOrderDataAccess.GetRepairOrderHistoryAsync(this.RepairOrderID);
        }

        private bool _HasRepairCost()
        {
            return clsRepairOrderDataAccess.IsRepairOrderHasRepairCost(this.RepairOrderID);
        }

        private bool _HasInvoice()
        {
            return clsRepairOrderDataAccess.IsRepairOrderHasInvoice(this.RepairOrderID);
        }


        public Task<DataTable> GetAllUsedParts()
        {
            return clsRepairOrderDataAccess.GetAllUsedPartsForRepairOrder(this.RepairOrderID);
        }

        private float _GetTotalPriceForAllUsedParts()
        {
            return clsRepairOrderDataAccess.GetTotalPriceForAllUsedParts(this.RepairOrderID);
        }

        private bool _IsRepairOrderHasPayments()
        {
            return clsRepairOrderDataAccess.IsRepairOrderHasPayments(this.RepairOrderID);
        }


        public Task<DataTable> GetAllPayments()
        {
            return clsRepairOrderDataAccess.GetAllPaymentsForRepiarOrder(this.RepairOrderID);
        }

        private float? _GetPaymentRemainingForRepairOrder()
        {

            return clsRepairOrderDataAccess.GetPaymentRemainingForRepairOrder(this.RepairOrderID);
        }

        public static Task<DataTable> GetAllRepairOrdersReadyForInvoicingAsync()
        {
            return clsRepairOrderDataAccess.GetAllRepairOrdersReadyForInvoicingAsync();
        }
        public static  Task<DataTable> GetAllRepairOrdersReadyForDeliveryAsync()
        {
            return clsRepairOrderDataAccess.GetAllRepairOrdersReadyForDeliveryAsync();
        }


        public static bool IsCustomerHasRepairOrders(int CustomerID)
        {
            return clsRepairOrderDataAccess.IsCustomerHasRepairOrders(CustomerID);
        }


        public static Task<DataTable> GetAllRepairOrdersForDeviceAsync(int DeviceID)
        {
            return clsRepairOrderDataAccess.GetAllRepairOrdersForDeviceAsync(DeviceID);
        }

        public static bool IsDeviceHasRepairOrders(int DeviceID)
        {
            return clsRepairOrderDataAccess.IsDeviceHasRepairOrders(DeviceID);
        }

        public static bool IsTechnicianHasAssignedRepairs(int TechnicianID)
        {
            return clsRepairOrderDataAccess.IsTechnicianHasAssignedRepairs(TechnicianID);
        }
        public static bool IsTechnicianHasCurrentWorklodRepairs(int TechnicianID)
        {
            return clsRepairOrderDataAccess.IsTechnicianHasCurrentWorklodRepairs(TechnicianID);
        }
        public static bool IsTechnicianHasCompletedRepairs(int TechnicianID)
        {
            return clsRepairOrderDataAccess.IsTechnicianHasCompletedRepairs(TechnicianID);
        }

     }
}
