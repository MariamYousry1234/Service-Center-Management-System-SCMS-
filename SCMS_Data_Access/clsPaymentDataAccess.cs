using SharedLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCMS_Data_Access
{
    public class clsPaymentDataAccess
    {
        public static int? AddNewPayment(
           int InvoiceID,
           float TotalPaid,
           int CreatedByUserID,
           ref float Remaining
           )
        {
            int? PaymentID = null;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_AddNewPayment", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("InvoiceID", InvoiceID);
                        Command.Parameters.AddWithValue("TotalPaid", TotalPaid);
                        Command.Parameters.AddWithValue("CreatedByUserID", CreatedByUserID);

                        SqlParameter PaymentIDParameter =
                            new SqlParameter("PaymentID", SqlDbType.Int)
                            {
                                Direction = ParameterDirection.Output
                            };

                        Command.Parameters.Add(PaymentIDParameter);


                        SqlParameter RemainingAmount =
                            new SqlParameter("Remaining", SqlDbType.Money)
                            {
                                Direction = ParameterDirection.Output
                            };


                        Command.Parameters.Add(RemainingAmount);


                        Connection.Open();
                        Command.ExecuteNonQuery();

                        PaymentID =
                           Command.Parameters["PaymentID"].Value== DBNull.Value ?
                           null : 
                           (int?)Command.Parameters["PaymentID"].Value;

                        if(PaymentID != null)
                             Remaining = Convert.ToSingle(RemainingAmount.Value == DBNull.Value? 0
                                 : RemainingAmount.Value);

                    }
                }
            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog(
                    clsSettings.ApplicationName,
                    e.Message,
                    EventLogEntryType.Error);
            }

            return PaymentID;
        }

        public static bool FindPayment(
    int PaymentID,
    ref int InvoiceID,
    ref float TotalPaid,
    ref float Remaining,
    ref DateTime DatePaid,
    ref int CreatedByUserID,
    ref int? LastUpdatedUserID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_FindPayment", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("PaymentID", PaymentID);

                        Connection.Open();

                        using (SqlDataReader Data = Command.ExecuteReader())
                        {
                            if (Data.Read())
                            {
                                InvoiceID = (int)Data["InvoiceID"];
                                TotalPaid = Convert.ToSingle(Data["TotalPaid"]);
                                Remaining = Convert.ToSingle(Data["Remaining"]);
                                DatePaid = (DateTime)Data["DatePaid"];
                                CreatedByUserID = (int)Data["CreatedByUserID"];
                                LastUpdatedUserID =Data["LastUpdatedUserID"]==DBNull.Value?
                                    null:
                                    (int?)Data["LastUpdatedUserID"];

                                IsFound = true;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog(
                    clsSettings.ApplicationName,
                    e.Message,
                    EventLogEntryType.Error);
            }

            return IsFound;
        }

        public static bool UpdatePayment(
         int PaymentID,
         int InvoiceID,
         float TotalPaid,
         int? LastUpdatedUserID,
         ref float Remaining)
         {
            bool IsUpdated = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_UpdatePayment", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("PaymentID", PaymentID);
            
                        Command.Parameters.AddWithValue("TotalPaid", TotalPaid);

                        Command.Parameters.AddWithValue("InvoiceID", InvoiceID);

                        Command.Parameters.AddWithValue("LastUpdatedUserID ", 
                           (object)LastUpdatedUserID?? DBNull.Value);

                        SqlParameter ReturnValue =
                            new SqlParameter("ReturnValue", SqlDbType.Int)
                            {
                                Direction = ParameterDirection.ReturnValue
                            };

                        Command.Parameters.Add(ReturnValue);


                        SqlParameter RemainingAmount =
                            new SqlParameter("Remaining", SqlDbType.Money)
                            {
                                Direction = ParameterDirection.Output
                            };

                        Command.Parameters.Add(RemainingAmount);


                        Connection.Open();
                        Command.ExecuteNonQuery();

                        IsUpdated =
                            ((int)Command.Parameters["ReturnValue"].Value > 0);

                        if(IsUpdated)
                            Remaining = Convert.ToSingle(RemainingAmount.Value == DBNull.Value ? 0
                                 : RemainingAmount.Value);
                    }
                }
            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog(
                    clsSettings.ApplicationName,
                    e.Message,
                    EventLogEntryType.Error);
            }

            return IsUpdated;
        }

        public static bool DeletePayment(int PaymentID,int DeletedByUserID)
        {
            bool IsDeleted = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_DeletePayment", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("PaymentID", PaymentID);
                        Command.Parameters.AddWithValue("DeletedByUserID", DeletedByUserID);

                        SqlParameter ReturnValue =
                            new SqlParameter("ReturnValue", SqlDbType.Int)
                            {
                                Direction = ParameterDirection.ReturnValue
                            };

                        Command.Parameters.Add(ReturnValue);

                        Connection.Open();
                        Command.ExecuteNonQuery();

                        IsDeleted =
                            ((int)Command.Parameters["ReturnValue"].Value > 0);
                    }
                }
            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog(
                    clsSettings.ApplicationName,
                    e.Message,
                    EventLogEntryType.Error);
            }

            return IsDeleted;
        }

        public static bool IsPaymentExists(int PaymentID)
        {
            bool IsExists = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_IsPaymentExists", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("PaymentID", PaymentID);

                        Connection.Open();

                        IsExists = (Command.ExecuteScalar() != null);
                    }
                }
            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog(
                    clsSettings.ApplicationName,
                    e.Message,
                    EventLogEntryType.Error);
            }

            return IsExists;
        }

        public static async Task<DataTable> GetPaymentsAsync(
        int NumberOfPaymentsEachPage,
        int NumberOfPage)
        {
            DataTable Payments = new DataTable();

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_GetPayments", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "NumberOfPaymentsEachPage",
                            NumberOfPaymentsEachPage);

                        Command.Parameters.AddWithValue(
                            "NumberOfPage",
                            NumberOfPage);

                        await Connection.OpenAsync();

                        using (SqlDataReader Reader =
                            await Command.ExecuteReaderAsync())
                        {
                            Payments.Load(Reader);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog(
                    clsSettings.ApplicationName,
                    e.Message,
                    EventLogEntryType.Error);
            }

            return Payments;
        }

        public static async Task<int> GetPaymentsNumberOfPagesAsync(
      int PaymentsEachPage)
        {
            int NumberOfPages = 0;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_GetPaymentsNumberPages", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "PaymentsEachPage",
                            PaymentsEachPage);

                        SqlParameter ReturnValue =
                            new SqlParameter("NumberOfPages", SqlDbType.Int)
                            {
                                Direction = ParameterDirection.ReturnValue
                            };

                        Command.Parameters.Add(ReturnValue);

                        await Connection.OpenAsync();
                        await Command.ExecuteNonQueryAsync();

                        NumberOfPages = (int)ReturnValue.Value;
                    }
                }
            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog(
                    clsSettings.ApplicationName,
                    e.Message,
                    EventLogEntryType.Error);
            }

            return NumberOfPages;
        }

        public static async Task<DataTable> GetAllPaymentsForCustomer(int CustomerID)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_GetAllPaymentsForCustomer", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "CustomerID",
                            CustomerID);



                        await Connection.OpenAsync();
                      
                        using (SqlDataReader Reader=await Command.ExecuteReaderAsync())
                        {
                            dt.Load(Reader);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog(
                    clsSettings.ApplicationName,
                    e.Message,
                    EventLogEntryType.Error);
            }

            return dt;
        }

        public static bool IsCustomerHasPayments(int CustomerID)
        {
            bool HasPayments = false;
            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_IsCustomerHasPayments", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "CustomerID",
                            CustomerID);



                         Connection.Open();

                        HasPayments = Command.ExecuteScalar() != null;
                    }
                }
            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog(
                    clsSettings.ApplicationName,
                    e.Message,
                    EventLogEntryType.Error);
            }

            return HasPayments;
        }
    }
}
