using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCMS_Business_Logic;
using SCMS_Data_Access;

namespace SCMS_Business_Logic
{
    public class clsPayment
    {

        public enum enMode
        {
            AddNew = 1,
            Update = 2
        }

        public enMode Mode = enMode.AddNew;
        public int PaymentID { get; private set; }

        public int InvoiceID { set; get; }

        public clsInvoice InvoiceInfo;

        public float TotalPaid { set; get; }

        public float Remaining { get; private set; }

        public DateTime DatePaid { get; private set; }

        public int CreatedByUserID { set; get; }

        public clsUser CreatedUserInfo;

        public int? LastUpdatedUserID { set; get; }

        public clsUser LastUpdatedUserInfo;

        public clsPayment()
        {
            this.PaymentID = -1;
            this.InvoiceID = -1;
            this.TotalPaid = 0;
            this.Remaining = 0;
            this.DatePaid = DateTime.MinValue;
            this.CreatedByUserID = -1;
            this.LastUpdatedUserID = null;

            this.InvoiceInfo = null;
            this.CreatedUserInfo = null;
            this.LastUpdatedUserInfo = null;
            Mode = enMode.AddNew;
        }


        private clsPayment(
            int PaymentID,
            int InvoiceID,
            float TotalPaid,
            float Remaining,
            DateTime DatePaid,
            int CreatedByUserID,
            int? LastUpdatedUserID)
        {
            this.PaymentID = PaymentID;
            this.InvoiceID = InvoiceID;
            this.TotalPaid = TotalPaid;
            this.Remaining = Remaining;
            this.DatePaid = DatePaid;
            this.CreatedByUserID = CreatedByUserID;
            this.LastUpdatedUserID = LastUpdatedUserID;

            this.InvoiceInfo = clsInvoice.Find(InvoiceID);
            this.CreatedUserInfo = clsUser.FindUser(CreatedByUserID);

            if (LastUpdatedUserID != null)
                this.LastUpdatedUserInfo = clsUser.FindUser(LastUpdatedUserID.Value);
            Mode = enMode.Update;
        }


        private bool AddNewPayment()
        {
            float Remaining = 0;

            int? PaymentID =
                clsPaymentDataAccess.AddNewPayment(
                    this.InvoiceID,
                    this.TotalPaid,
                    this.CreatedByUserID,
                    ref Remaining
                    );

            if (PaymentID.HasValue)
            {
                this.PaymentID = PaymentID.Value;
                this.Remaining = Remaining;
                this.DatePaid = DateTime.Now;

                return true;
            }

            return false;
        }


        private bool UpdatePayment()
        {
            float Remaining = 0;

            bool IsUpdated =
                clsPaymentDataAccess.UpdatePayment(
                    this.PaymentID,
                    this.InvoiceID,
                    this.TotalPaid, 
                    this.LastUpdatedUserID,
                    ref Remaining);

            if (IsUpdated)
                this.Remaining = Remaining;

            return IsUpdated;
        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (AddNewPayment())
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                    return false;


                case enMode.Update:

                    return UpdatePayment();
            }

            return false;
        }


        public static clsPayment FindPayment(int PaymentID)
        {
            int InvoiceID = 0;
            float TotalPaid = 0;
            float Remaining = 0;
            DateTime DatePaid = DateTime.MinValue;
            int CreatedByUserID = 0;
            int? LastUpdatedUserID = null;

            if (clsPaymentDataAccess.FindPayment(
                PaymentID,
                ref InvoiceID,
                ref TotalPaid,
                ref Remaining,
                ref DatePaid,
                ref CreatedByUserID,
                ref LastUpdatedUserID))
            {
                return new clsPayment(
                    PaymentID,
                    InvoiceID,
                    TotalPaid,
                    Remaining,
                    DatePaid,
                    CreatedByUserID,
                    LastUpdatedUserID);
            }

            return null;
        }


        public static bool DeletePayment(int PaymentID,int DeletedByUserID)
        {
            return clsPaymentDataAccess.DeletePayment(PaymentID,DeletedByUserID);
        }


        public static bool IsPaymentExists(int PaymentID)
        {
            return clsPaymentDataAccess.IsPaymentExists(PaymentID);
        }


        public static Task<DataTable> GetPaymentsAsync(
            int NumberOfPaymentsEachPage,
            int NumberOfPage)
        {
            return clsPaymentDataAccess.GetPaymentsAsync(
                NumberOfPaymentsEachPage,
                NumberOfPage);
        }


        public static Task<int> GetPaymentsNumberOfPagesAsync(
            int PaymentsEachPage)
        {
            return clsPaymentDataAccess.GetPaymentsNumberOfPagesAsync(
                PaymentsEachPage);
        }

        public static  Task<DataTable> GetAllPaymentsForCustomer(int CustomerID)
        {
            return clsPaymentDataAccess.GetAllPaymentsForCustomer(CustomerID);
        }

        public static bool IsCustomerHasPayments(int CustomerID)
        {
            return clsPaymentDataAccess.IsCustomerHasPayments(CustomerID);
        }
  }
}
