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
    public class clsInvoiceDataAccess
    {
            public static int? AddNewInvoice(
                int RepairCostID,
                int CreatedByUserID)
            {
                int? InvoiceID = null;

                try
                {
                    using (SqlConnection Connection =
                        new SqlConnection(clsSettings.ConnectionString))
                    {
                        using (SqlCommand Command =
                            new SqlCommand(
                                "SP_AddNewInvoice",
                                Connection))
                        {
                            Command.CommandType =
                                CommandType.StoredProcedure;

                            Command.Parameters.AddWithValue(
                                "RepairCostID", RepairCostID);

                            Command.Parameters.AddWithValue(
                                "CreatedByUserID", CreatedByUserID);

                            SqlParameter InvoiceIDParameter =
                                new SqlParameter(
                                    "InvoiceID",
                                    SqlDbType.Int);

                            InvoiceIDParameter.Direction =
                                ParameterDirection.Output;

                            Command.Parameters.Add(InvoiceIDParameter);

                            Connection.Open();

                            Command.ExecuteNonQuery();

                            InvoiceID =
                                (int?)InvoiceIDParameter.Value;
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

                return InvoiceID;
            }


            public static bool FindInvoice(
                int InvoiceID,
                ref int RepairCostID,
                ref DateTime IssueDate,
                ref int CreatedByUserID,
                ref byte PaymentStatus,
                ref int? LastUpdatedUserID)
            {
                bool IsFound = false;

                try
                {
                    using (SqlConnection Connection =
                        new SqlConnection(clsSettings.ConnectionString))
                    {
                        using (SqlCommand Command =
                            new SqlCommand(
                                "SP_FindInvoice",
                                Connection))
                        {
                            Command.CommandType =
                                CommandType.StoredProcedure;

                            Command.Parameters.AddWithValue(
                                "InvoiceID", InvoiceID);

                            Connection.Open();

                            using (SqlDataReader Reader =
                                Command.ExecuteReader())
                            {
                                if (Reader.Read())
                                {
                                    IsFound = true;

                                    RepairCostID =
                                        (int)Reader["RepairCostID"];

                                    IssueDate =
                                        (DateTime)Reader["IssueDate"];

                                    CreatedByUserID =
                                        (int)Reader["CreatedByUserID"];

                                 PaymentStatus =
                                    (byte)Reader["PaymentStatus"];

                                LastUpdatedUserID =
                                    Reader["LastUpdatedUserID"] ==DBNull.Value? null:
                                    (int?)Reader["LastUpdatedUserID"];
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


        public static bool FindInvoice(
            int RepairOrderID ,
          ref int InvoiceID,
          ref int RepairCostID,
          ref DateTime IssueDate,
          ref int CreatedByUserID,
          ref byte PaymentStatus,
          ref int? LastUpdatedUserID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_FindInvoiceByRepairOrderID",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "RepairOrderID", RepairOrderID);

                        Connection.Open();

                        using (SqlDataReader Reader =
                            Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                IsFound = true;

                                InvoiceID =
                                    (int)Reader["InvoiceID"];

                                RepairCostID =
                                    (int)Reader["RepairCostID"];

                                IssueDate =
                                    (DateTime)Reader["IssueDate"];

                                CreatedByUserID =
                                    (int)Reader["CreatedByUserID"];

                                PaymentStatus =
                                   (byte)Reader["PaymentStatus"];

                                LastUpdatedUserID =
                                   Reader["LastUpdatedUserID"] == DBNull.Value ? null :
                                   (int?)Reader["LastUpdatedUserID"];
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


        public static bool UpdateInvoice(
                int InvoiceID,
                int RepairCostID,
                int? LastUpdatedUserID
              )
            {
                try
                {
                    using (SqlConnection Connection =
                        new SqlConnection(clsSettings.ConnectionString))
                    {
                        using (SqlCommand Command =
                            new SqlCommand(
                                "SP_UpdateInvoice",
                                Connection))
                        {
                            Command.CommandType =
                                CommandType.StoredProcedure;

                            Command.Parameters.AddWithValue(
                                "InvoiceID", InvoiceID);

                            Command.Parameters.AddWithValue(
                                "RepairCostID", RepairCostID);


                        Command.Parameters.AddWithValue(
                            "LastUpdatedUserID", LastUpdatedUserID);

                        SqlParameter ReturnValue =
                                new SqlParameter(
                                    "ReturnValue",
                                    SqlDbType.Int);

                            ReturnValue.Direction =
                                ParameterDirection.ReturnValue;

                            Command.Parameters.Add(ReturnValue);

                            Connection.Open();

                            Command.ExecuteNonQuery();

                            return (int)ReturnValue.Value > 0;
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

                return false;
            }


            public static bool DeleteInvoice(int InvoiceID)
            {
                try
                {
                    using (SqlConnection Connection =
                        new SqlConnection(clsSettings.ConnectionString))
                    {
                        using (SqlCommand Command =
                            new SqlCommand(
                                "SP_DeleteInvoice",
                                Connection))
                        {
                            Command.CommandType =
                                CommandType.StoredProcedure;

                            Command.Parameters.AddWithValue(
                                "InvoiceID", InvoiceID);

                            SqlParameter ReturnValue =
                                new SqlParameter(
                                    "ReturnValue",
                                    SqlDbType.Int);

                            ReturnValue.Direction =
                                ParameterDirection.ReturnValue;

                            Command.Parameters.Add(ReturnValue);

                            Connection.Open();

                            Command.ExecuteNonQuery();

                            return (int)ReturnValue.Value > 0;
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

                return false;
            }


            public static bool IsInvoiceExists(int InvoiceID)
            {
                try
                {
                    using (SqlConnection Connection =
                        new SqlConnection(clsSettings.ConnectionString))
                    {
                        using (SqlCommand Command =
                            new SqlCommand(
                                "SP_IsInvoiceExists",
                                Connection))
                        {
                            Command.CommandType =
                                CommandType.StoredProcedure;

                            Command.Parameters.AddWithValue(
                                "InvoiceID", InvoiceID);

                            Connection.Open();

                            return Command.ExecuteScalar() != null;
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

                return false;
            }


            public static bool IsInvoiceExistsByRepairCostID(
                int RepairCostID)
            {
                try
                {
                    using (SqlConnection Connection =
                        new SqlConnection(clsSettings.ConnectionString))
                    {
                        using (SqlCommand Command =
                            new SqlCommand(
                                "SP_IsInvoiceExistsByRepairCostID",
                                Connection))
                        {
                            Command.CommandType =
                                CommandType.StoredProcedure;

                            Command.Parameters.AddWithValue(
                                "RepairCostID",
                                RepairCostID);

                            Connection.Open();

                            return Command.ExecuteScalar() != null;
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

                return false;
            }


        public static async Task<DataTable> GetInvoicesAsync(int NumberOfInvoicesEachPage,
            int NumberOfPage)
        {
            DataTable Invoices = new DataTable();

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_GetInvoices",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue(
                         "NumberOfInvoicesEachPage",
                         NumberOfInvoicesEachPage);
  
                        Command.Parameters.AddWithValue(
                            "NumberOfPage",
                            NumberOfPage);
                        await Connection.OpenAsync();

                        using (SqlDataReader Reader =
                            await Command.ExecuteReaderAsync())
                        {
                            Invoices.Load(Reader);
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

            return Invoices;
        }


        public static async Task<int> GetInvoicesNumberOfPagesAsync(
            int InvoicesEachPage)
        {
            int NumberOfPages = 0;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_GetInvoicesNumberPages",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "InvoicesEachPage",
                            InvoicesEachPage);

                        SqlParameter ReturnValue =
                            new SqlParameter(
                                "ReturnValue",
                                SqlDbType.Int);

                        ReturnValue.Direction =
                            ParameterDirection.ReturnValue;

                        Command.Parameters.Add(ReturnValue);

                        await Connection.OpenAsync();

                        await Command.ExecuteNonQueryAsync();

                        NumberOfPages =
                            (int)ReturnValue.Value;
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



        public static async Task<DataTable> GetAllInvoicesAwaitingPaymentAsync()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetAllInvoicesAwaitingPayment", Connection))
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
    }
}
