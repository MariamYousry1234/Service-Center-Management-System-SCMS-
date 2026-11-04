using SharedLib;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCMS_Data_Access
{
    public class clsRepairOrderDataAccess
    {

        public static bool IsRepairOrderExists(int RepairOrderID)
        {
            bool IsExists = false;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_IsRepairOrderExists", Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;


                        Command.Parameters.AddWithValue("@RepairOrderID", RepairOrderID);


                        Connection.Open();

                        IsExists = Command.ExecuteScalar() != null;
                    }

                }


            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog(clsSettings.ApplicationName, e.Message,
                  EventLogEntryType.Error);
            }

            return IsExists;
        }

        public static int? AddNewRepairOrder(string? ProblemDescrition, byte Priority,
            string? Notes, int AssignedTechnicianID,  int DeviceID, int CreatedByUserID,
            string? BeforeRepairImagePath)
        {
            int? RepairOrderID = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_AddNewRepairOrder", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;


                        Command.Parameters.AddWithValue("@ProblemDescription", ProblemDescrition ?? (object)DBNull.Value);
                        Command.Parameters.AddWithValue("@Priority", Priority);
                        Command.Parameters.AddWithValue("@Notes", Notes?? (object)DBNull.Value);
                        Command.Parameters.AddWithValue("@AssignedTechnicianID", AssignedTechnicianID);
                        Command.Parameters.AddWithValue("@DeviceID", DeviceID);
                        Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        Command.Parameters.AddWithValue("@BeforeRepairImagePath", BeforeRepairImagePath ?? (object)DBNull.Value);

                        Command.Parameters.Add("@RepairOrderID", SqlDbType.Int).Direction =
                         ParameterDirection.Output;

                        Connection.Open();


                        Command.ExecuteNonQuery();

                        object Result = Command.Parameters["@RepairOrderID"].Value;
                        RepairOrderID = Result == DBNull.Value?null:(int?)Result;
                    }

                }

            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog(clsSettings.ApplicationName, e.Message,
                       System.Diagnostics.EventLogEntryType.Error);
            }
            return RepairOrderID;
        }

        public static bool UpdateRepairOrder(int RepairOrderID,
         string? ProblemDescrition, byte Priority,
         string? Notes, int? UpdatedByUserID,
         string? BeforeRepairImagePath
          )
        {
            bool IsUpdated = false;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_UpdateRepairOrder", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@RepairOrderID", RepairOrderID);
                        Command.Parameters.AddWithValue("@ProblemDescription", ProblemDescrition ?? (object)DBNull.Value);
                        Command.Parameters.AddWithValue("@Priority", Priority);
                        Command.Parameters.AddWithValue("@Notes", Notes ?? (object)DBNull.Value);
                        Command.Parameters.AddWithValue("@UpdatedUserID", UpdatedByUserID??(object)DBNull.Value);
                        Command.Parameters.AddWithValue("@BeforeRepairImagePath", BeforeRepairImagePath ?? (object)DBNull.Value);
                       
                        Command.Parameters.Add("@UpdatedResult", SqlDbType.Int).Direction =
                         ParameterDirection.ReturnValue;

                        Connection.Open();


                        Command.ExecuteNonQuery();

                        object Result = Command.Parameters["@UpdatedResult"].Value;
                        IsUpdated = ((int)Result == 1);
                    }

                }

            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog(clsSettings.ApplicationName, e.Message,
                       System.Diagnostics.EventLogEntryType.Error);
            }
            return IsUpdated;
        }

        public static bool DeleteRepairOrder(int RepairOrderID)
        {
            bool IsDeleted = false;


            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_DeleteRepairOrder", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@RepairOrderID", RepairOrderID);
           
                        Command.Parameters.Add("@DeletedResult", SqlDbType.Int).Direction =
                         ParameterDirection.ReturnValue;

                        Connection.Open();


                        Command.ExecuteNonQuery();

                        object Result = Command.Parameters["@DeletedResult"].Value;
                        IsDeleted = ((int)Result > 0);
                    }

                }

            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog(clsSettings.ApplicationName, e.Message,
                       System.Diagnostics.EventLogEntryType.Error);
            }

            return IsDeleted;
        }

        public static bool FindRepairOrder(
    int RepairOrderID,
    ref DateTime DateReceived,
    ref string? ProblemDescription,
    ref byte Priority,
    ref byte Status,
    ref string? Notes,
    ref int AssignedTechnicianID,
    ref int DeviceID,
    ref int CreatedByUserID,
    ref int? LastUpdatedUserID,
    ref DateTime? LastUpdatedDate,
    ref string? BeforeRepairImagePath,
    ref DateTime? RepairCompletionDate
  )
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_FindRepairOrder", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "@RepairOrderID", RepairOrderID);

                        Connection.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                           
                            if (Reader.Read())
                            {
                                DateReceived =(DateTime)Reader["DateReceived"];

                                ProblemDescription = Reader["ProblemDescription"] == DBNull.Value
                                    ? null : (string?)Reader["ProblemDescription"];

                                Priority = (byte)Reader["Priority"];
                                Status = (byte)Reader["Status"];


                                Notes = Reader["Notes"] == DBNull.Value
                                    ? null : (string?)Reader["Notes"];

                                AssignedTechnicianID =
                                    (int)Reader["AssignedTechnicianID"];


                                DeviceID =
                                    (int)Reader["DeviceID"];

                                CreatedByUserID =
                                    (int)Reader["CreatedByUserID"];

                                LastUpdatedUserID =
                                    Reader["LastUpdatedUserID"] == DBNull.Value
                                    ? null : (int?)Reader["LastUpdatedUserID"];

                                LastUpdatedDate =
                                    Reader["LastUpdatedDate"] == DBNull.Value
                                    ? null : (DateTime?)Reader["LastUpdatedDate"];


                                BeforeRepairImagePath =
                                            Reader["BeforeRepairImagePath"] == DBNull.Value
                                            ? null : (string?)Reader["BeforeRepairImagePath"];

                                RepairCompletionDate =
                                         Reader["RepairCompletionDate"] == DBNull.Value
                                         ? null : (DateTime?)Reader["RepairCompletionDate"];

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
                    System.Diagnostics.EventLogEntryType.Error);
            }

            return IsFound;
        }

        public static async Task<DataTable> GetRepairOrdersAsync(int NumberOfRepairOrdersEachPage,
            int NumberOfPage)
        {
            DataTable RepairOrders = new DataTable();
            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_GetRepairOrders", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "@NumberOfRepairOrdersEachPage", NumberOfRepairOrdersEachPage);

                        Command.Parameters.AddWithValue(
                          "@NumberOfPage", NumberOfPage);

                        await Connection.OpenAsync();

                        using (SqlDataReader Reader=await Command.ExecuteReaderAsync())
                        {
                            RepairOrders.Load(Reader);
                        }
                       
               
                    }
                }
            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog(
                    clsSettings.ApplicationName,
                    e.Message,
                    System.Diagnostics.EventLogEntryType.Error);
            }
            return RepairOrders;
        }

        public static async Task<int> GetRepairOrdersNumberPages(int RepairOrdersEachPage)
        {
            int NumberOfPages = 0;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetRepairOrdersNumberPages", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("RepairOrdersEachPage", RepairOrdersEachPage);


                        SqlParameter NumberOfPagesParameter = new SqlParameter("NumberOfPages", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };

                        Command.Parameters.Add(NumberOfPagesParameter);

                        await Connection.OpenAsync();
                        await Command.ExecuteNonQueryAsync();

                        NumberOfPages = (int)NumberOfPagesParameter.Value;
                    }
                }
            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog
                    (clsSettings.ApplicationName, e.Message,
                    EventLogEntryType.Error);
            }

            return NumberOfPages;
        }

        public static bool CancelRepairOrder(int RepairOrderID, int UserID)
        {
            bool IsCanceled = false;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_CancelRepairOrder", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("RepairOrderID", RepairOrderID);


                        Command.Parameters.AddWithValue("@LastUpdatedUserID", UserID);
                        SqlParameter ReturnValue = new SqlParameter("Result", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };

                        Command.Parameters.Add(ReturnValue);

                         Connection.Open();
                         Command.ExecuteNonQuery();

                        IsCanceled = ((int)ReturnValue.Value) > 0;
                    }
                }
            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog
                    (clsSettings.ApplicationName, e.Message,
                    EventLogEntryType.Error);
            }

            return IsCanceled;
        }

        public static async Task<DataTable> GetAllRepairOrdersForCustomerAsync(int CustomerID)
        {
            DataTable AllRepairOrders = new DataTable();

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetAllRepairOrdersForCustomer", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("CustomerID", CustomerID);

                        await Connection.OpenAsync();
                        using (SqlDataReader Reader = await Command.ExecuteReaderAsync())
                        {
                            AllRepairOrders.Load(Reader);
                        }
                  
                    }
                }
            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog
                    (clsSettings.ApplicationName, e.Message,
                    EventLogEntryType.Error);
            }

            return AllRepairOrders;
        }


        public static async Task<DataTable> GetAllAssignedROrdersForTechnicianAsync(int TechnicianID)
        {
            DataTable AllRepairOrders = new DataTable();

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetAllAssignedOrdersForTechnician", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("TechnicianID", TechnicianID);

                        await Connection.OpenAsync();
                        using (SqlDataReader Reader = await Command.ExecuteReaderAsync())
                        {
                            AllRepairOrders.Load(Reader);
                        }

                    }
                }
            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog
                    (clsSettings.ApplicationName, e.Message,
                    EventLogEntryType.Error);
            }

            return AllRepairOrders;
        }


        public static async Task<DataTable> GetAllCompletedOrdersForTechnicianAsync(int TechnicianID)
        {
            DataTable AllRepairOrders = new DataTable();

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetAllCompletedOrdersForTechnician", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("TechnicianID", TechnicianID);

                        await Connection.OpenAsync();
                        using (SqlDataReader Reader = await Command.ExecuteReaderAsync())
                        {
                            AllRepairOrders.Load(Reader);
                        }

                    }
                }
            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog
                    (clsSettings.ApplicationName, e.Message,
                    EventLogEntryType.Error);
            }

            return AllRepairOrders;
        }

        public static async Task<DataTable> GetAllCurrentWorkloadOrdersForTechnicianAsync(int TechnicianID)
        {
            DataTable AllRepairOrders = new DataTable();

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetAllCurrentWorkloadOrdersForTechnician", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("TechnicianID", TechnicianID);

                        await Connection.OpenAsync();
                        using (SqlDataReader Reader = await Command.ExecuteReaderAsync())
                        {
                            AllRepairOrders.Load(Reader);
                        }

                    }
                }
            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog
                    (clsSettings.ApplicationName, e.Message,
                    EventLogEntryType.Error);
            }

            return AllRepairOrders;
        }

        public static async Task<DataTable> GetRepairOrderHistoryAsync(int RepairOrderID)
        {
            DataTable AllRepairOrders = new DataTable();

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetRepairOrderHistory", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("RepairOrderID", RepairOrderID);


                        await Connection.OpenAsync();

                        using (SqlDataReader Reader = await Command.ExecuteReaderAsync())
                        {
                            AllRepairOrders.Load(Reader);
                        }

                    }
                }
            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog
                    (clsSettings.ApplicationName, e.Message,
                    EventLogEntryType.Error);
            }

            return AllRepairOrders;
        }

        public static bool IsRepairOrderHasRepairCost(int RepairOrderID)
        {
            bool HasRepairCost = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_IsRepairOrderHasRepairCost", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("RepairOrderID", RepairOrderID);


                         Connection.Open();

                       HasRepairCost = Command.ExecuteScalar() !=null ;
                    }
                }
            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog
                    (clsSettings.ApplicationName, e.Message,
                    EventLogEntryType.Error);
            }

            return HasRepairCost;
        }

        public static bool IsRepairOrderHasInvoice(int RepairOrderID)
        {
            bool HasRepairCost = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_IsRepairOrderHasInvoice", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("RepairOrderID", RepairOrderID);


                        Connection.Open();

                        HasRepairCost = Command.ExecuteScalar() != null;
                    }
                }
            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog
                    (clsSettings.ApplicationName, e.Message,
                    EventLogEntryType.Error);
            }

            return HasRepairCost;
        }

        public static async Task<DataTable> GetAllUsedPartsForRepairOrder(int RepairOrderID)
        {
            DataTable AllParts = new DataTable();

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetAllUsedPartsForRepairOrder", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("RepairOrderID", RepairOrderID);


                       await Connection.OpenAsync();

                     using ( SqlDataReader Data= await Command.ExecuteReaderAsync())
                      {
                            AllParts.Load(Data);
                       }
                    }
                }
            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog
                    (clsSettings.ApplicationName, e.Message,
                    EventLogEntryType.Error);
            }

            return AllParts;
        }

        public static float GetTotalPriceForAllUsedParts(int RepairOrderID)
        {
            float TotalPrice=0;


            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetTotalPriceForAllUsedParts", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("RepairOrderID", RepairOrderID);


                        Connection.Open();

                        TotalPrice = Convert.ToSingle(Command.ExecuteScalar());
                    }
                }
            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog
                    (clsSettings.ApplicationName, e.Message,
                    EventLogEntryType.Error);
            }

            return TotalPrice;
        }


        public static bool IsRepairOrderHasPayments(int RepairOrderID)
        {
            bool HasPayments = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_IsRepairOrderHasPayments", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("RepairOrderID", RepairOrderID);


                        Connection.Open();

                        HasPayments = Command.ExecuteScalar() != null;
                    }
                }
            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog
                    (clsSettings.ApplicationName, e.Message,
                    EventLogEntryType.Error);
            }

            return HasPayments;
        }

        public static async Task<DataTable> GetAllPaymentsForRepiarOrder(int RepairOrderID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetAllPaymentsForRepairOrder", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("RepairOrderID", RepairOrderID);


                        await Connection.OpenAsync();

                        using(SqlDataReader Reader = await Command.ExecuteReaderAsync())
                        {
                            dt.Load(Reader);

                        }
                    }
                }
            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog
                    (clsSettings.ApplicationName, e.Message,
                    EventLogEntryType.Error);
            }

            return dt;
        }

        public static float? GetPaymentRemainingForRepairOrder(int RepairOrderID)
        {
            float? Remaining = null;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetPaymentRemainingForRepairOrder", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("RepairOrderID", RepairOrderID);

                        SqlParameter ReturnValue = new SqlParameter("RepairRemaining", 
                            SqlDbType.Money)
                        {
                            Direction = ParameterDirection.Output
                        };

                        Command.Parameters.Add(ReturnValue);

                        Connection.Open();

                        Command.ExecuteNonQuery();

                        Remaining = ReturnValue.Value != DBNull.Value ?
                           (float?)Convert.ToSingle(ReturnValue.Value) : null;
                    }
                }
            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog
                    (clsSettings.ApplicationName, e.Message,
                    EventLogEntryType.Error);
            }

            return Remaining;
        }

        public static async Task<DataTable> GetAllRepairOrdersReadyForInvoicingAsync()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetAllRepairOrdersReadyForInvoicing", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        await Connection.OpenAsync();

                        using (SqlDataReader Reader = await Command.ExecuteReaderAsync())
                        {
                            dt.Load(Reader);

                        }
                    }
                }
            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog
                    (clsSettings.ApplicationName, e.Message,
                    EventLogEntryType.Error);
            }

            return dt;

        }


        public static async Task<DataTable> GetAllRepairOrdersReadyForDeliveryAsync()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetAllRepairOrdersReadyForDelivery", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        await Connection.OpenAsync();

                        using (SqlDataReader Reader = await Command.ExecuteReaderAsync())
                        {
                            dt.Load(Reader);

                        }
                    }
                }
            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog
                    (clsSettings.ApplicationName, e.Message,
                    EventLogEntryType.Error);
            }

            return dt;

        }

        public static bool IsCustomerHasRepairOrders(int CustomerID)
         {
            bool HasRepairOrders = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_IsCustomerHasRepairOrders", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("CustomerID", CustomerID);

                         Connection.Open();

                        HasRepairOrders = Command.ExecuteScalar() != null;
                    }
                }
            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog
                    (clsSettings.ApplicationName, e.Message,
                    EventLogEntryType.Error);
            }

            return HasRepairOrders;
        }

        public static async Task<DataTable> GetAllRepairOrdersForDeviceAsync(int DeviceID)
        {
            DataTable AllRepairOrders = new DataTable();

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetAllRepairOrdersForDevice", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("DeviceID", DeviceID);

                        await Connection.OpenAsync();

                        using (SqlDataReader Reader=await Command.ExecuteReaderAsync())
                        {
                            AllRepairOrders.Load(Reader);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog
                    (clsSettings.ApplicationName, e.Message,
                    EventLogEntryType.Error);
            }


            return AllRepairOrders;

        }

        public static bool IsDeviceHasRepairOrders(int DeviceID)
        {
            bool HasRepairOrders= false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_IsDeviceHasRepairOrders", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("DeviceID", DeviceID);

                        Connection.Open();

                        HasRepairOrders = Command.ExecuteScalar() != null;
                    }
                }
            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog
                    (clsSettings.ApplicationName, e.Message,
                    EventLogEntryType.Error);
            }

            return HasRepairOrders;
        }



        public static bool IsTechnicianHasAssignedRepairs(int TechnicianID)
        {
            bool HasRepairOrders = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_IsTechnicianHasAssignedRepairs", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("TechnicianID", TechnicianID);

                        Connection.Open();

                        HasRepairOrders = Command.ExecuteScalar() != null;
                    }
                }
            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog
                    (clsSettings.ApplicationName, e.Message,
                    EventLogEntryType.Error);
            }

            return HasRepairOrders;
        }


        public static bool IsTechnicianHasCurrentWorklodRepairs(int TechnicianID)
        {
            bool HasRepairOrders = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_IsTechnicianHasCurrentWorkloadRepairs", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("TechnicianID", TechnicianID);

                        Connection.Open();

                        HasRepairOrders = Command.ExecuteScalar() != null;
                    }
                }
            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog
                    (clsSettings.ApplicationName, e.Message,
                    EventLogEntryType.Error);
            }

            return HasRepairOrders;
        }

        public static bool IsTechnicianHasCompletedRepairs(int TechnicianID)
        {
            bool HasRepairOrders = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_IsTechnicianHasCompletedOrders", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("TechnicianID", TechnicianID);

                        Connection.Open();

                        HasRepairOrders = Command.ExecuteScalar() != null;
                    }
                }
            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog
                    (clsSettings.ApplicationName, e.Message,
                    EventLogEntryType.Error);
            }

            return HasRepairOrders;
        }

    }
}
