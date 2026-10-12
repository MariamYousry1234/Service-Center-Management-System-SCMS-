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
    public class clsDeliveryDataAccess
    {
        public static int? AddNewDelivery(
    int RepairOrderID,
    int DeliveredByUserID,
    string? DeliveryNotes,
     DateTime? WarrantyEndDate ,
      string? AfterRepairImagePath)
        {
            int? DeliveryID = null;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_AddNewDelivery",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "RepairOrderID",
                            RepairOrderID);

                        Command.Parameters.AddWithValue(
                            "DeliveredByUserID",
                            DeliveredByUserID);

                        Command.Parameters.AddWithValue(
                            "DeliveryNotes",
                            (object)DeliveryNotes ?? DBNull.Value);


                        Command.Parameters.AddWithValue(
                            "WarrantyEndDate",
                            (object)WarrantyEndDate ?? DBNull.Value);

                        Command.Parameters.AddWithValue(
                            "AfterRepairImagePath",
                            (object)AfterRepairImagePath ?? DBNull.Value);

                        SqlParameter DeliveryIDParameter =
                            new SqlParameter(
                                "DeliveryID",
                                SqlDbType.Int)
                            {
                                Direction =
                                    ParameterDirection.Output
                            };

                        Command.Parameters.Add(
                            DeliveryIDParameter);

                        Connection.Open();
                        Command.ExecuteNonQuery();

                        object Result = Command.Parameters["DeliveryID"].Value;

                        DeliveryID =
                            Result == DBNull.Value?null: (int?)Result;
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

            return DeliveryID;
        }

        public static bool FindDelivery(
    int DeliveryID,
    ref int RepairOrderID,
    ref DateTime DeliveryDate,
    ref int DeliveredByUserID,
    ref string? DeliveryNotes,
    ref DateTime? WarrantyEndDate,
    ref string? AfterRepairImagePath)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_FindDelivery",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "DeliveryID",
                            DeliveryID);

                        Connection.Open();

                        using (SqlDataReader Data =
                            Command.ExecuteReader())
                        {
                            if (Data.Read())
                            {
                                RepairOrderID =
                                    (int)Data["RepairOrderID"];

                                DeliveryDate =
                                    (DateTime)Data["DeliveryDate"];

                                DeliveredByUserID =
                                    (int)Data["DeliveryByUserID"];

                                DeliveryNotes =
                                    Data["DeliveryNotes"] == DBNull.Value ?
                                    null :
                                    Data["DeliveryNotes"].ToString();

                                WarrantyEndDate=
                                        Data["WarrantyEndDate"] == DBNull.Value ?
                                    null :
                                   (DateTime?)Data["WarrantyEndDate"];



                                AfterRepairImagePath =
                                    Data["AfterRepairImagePath"] == DBNull.Value ?
                                    null :
                                    Data["AfterRepairImagePath"].ToString();

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

        public static bool FindDeliveryByRepairOrderID(
    int RepairOrderID,
    ref int DeliveryID,
    ref DateTime DeliveryDate,
    ref int DeliveredByUserID,
    ref string? DeliveryNotes,
    ref DateTime? WarrantyEndDate,
    ref string? AfterRepairImagePath)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_FindDeliveryByRepairOrderID",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "RepairOrderID",
                            RepairOrderID);

                        Connection.Open();

                        using (SqlDataReader Data =
                            Command.ExecuteReader())
                        {
                            if (Data.Read())
                            {
                                DeliveryID =
                                    (int)Data["DeliveryID"];

                                DeliveryDate =
                                    (DateTime)Data["DeliveryDate"];

                                DeliveredByUserID =
                                    (int)Data["DeliveryByUserID"];

                                DeliveryNotes =
                                    Data["DeliveryNotes"] == DBNull.Value
                                    ? null
                                    : Data["DeliveryNotes"].ToString();


                                WarrantyEndDate =
                                        Data["WarrantyEndDate"] == DBNull.Value ?
                                    null :
                                   (DateTime?)Data["WarrantyEndDate"];

                                AfterRepairImagePath =
                                    Data["AfterRepairImagePath"] == DBNull.Value
                                    ? null
                                    : Data["AfterRepairImagePath"].ToString();

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

        public static bool UpdateDelivery(
        int DeliveryID,
        int RepairOrderID ,
        string? DeliveryNotes,
        DateTime? WarrantyEndDate,
        string? AfterRepairImagePath)
        {
            bool IsUpdated = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_UpdateDelivery",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "RepairOrderID",
                            RepairOrderID);

                        Command.Parameters.AddWithValue(
                          "DeliveryID",
                          DeliveryID);

                        Command.Parameters.AddWithValue(
                            "DeliveryNotes",
                            (object)DeliveryNotes ?? DBNull.Value);


                        Command.Parameters.AddWithValue(
                                "WarrantyEndDate",
                                (object)WarrantyEndDate ?? DBNull.Value);

                        Command.Parameters.AddWithValue(
                            "AfterRepairImagePath",
                            (object)AfterRepairImagePath ?? DBNull.Value);

                        SqlParameter OutputParameter =
                            new SqlParameter(
                                "ReturnValue",
                                SqlDbType.Int)
                            {
                                Direction =
                                    ParameterDirection.ReturnValue
                            };

                        Command.Parameters.Add(
                            OutputParameter);

                        Connection.Open();
                        Command.ExecuteNonQuery();

                        IsUpdated =
                            ((int)OutputParameter.Value > 0);
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


        public static bool DeleteDelivery(
        int DeliveryID)
        {
            bool IsDeleted = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_DeleteDelivery",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "DeliveryID",
                            DeliveryID);

                        SqlParameter OutputParameter =
                            new SqlParameter(
                                "ReturnValue",
                                SqlDbType.Int)
                            {
                                Direction =
                                    ParameterDirection.ReturnValue
                            };

                        Command.Parameters.Add(
                            OutputParameter);

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

        public static bool IsDeliveryExists(
         int DeliveryID)
        {
            bool IsExists = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_IsDeliveryExists",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "DeliveryID",
                            DeliveryID);

                        Connection.Open();

                        IsExists =
                            (Command.ExecuteScalar() != null);
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

        public static bool IsDeliveryExistsByRepairOrderID(
       int RepairOrderID)
        {
            bool IsExists = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_IsDeliveryExistsByRepairOrderID",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "RepairOrderID",
                            RepairOrderID);

                        Connection.Open();

                        IsExists =
                            (Command.ExecuteScalar() != null);
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
        public static async Task<DataTable> GetDeliveriesAsync(
    int NumberOfDeliveriesEachPage,
    int NumberOfPage)
        {
            DataTable DeliveriesData = new DataTable();

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_GetDeliveries",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "NumberOfDeliveriesEachPage",
                            NumberOfDeliveriesEachPage);

                        Command.Parameters.AddWithValue(
                            "NumberOfPage",
                            NumberOfPage);

                        await Connection.OpenAsync();

                        using (SqlDataReader Data =
                            await Command.ExecuteReaderAsync())
                        {
                            DeliveriesData.Load(Data);
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

            return DeliveriesData;
        }

        public static async Task<int> GetDeliveriesNumberOfPagesAsync(
           int DeliveriesEachPage)
        {
            int NumberOfPages = 0;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_GetDeliveriesNumberPages",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "DeliveriesEachPage",
                            DeliveriesEachPage);

                        SqlParameter NumberOfPagesParameter =
                            new SqlParameter(
                                "NumberOfPages",
                                SqlDbType.Int)
                            {
                                Direction =
                                    ParameterDirection.ReturnValue
                            };

                        Command.Parameters.Add(
                            NumberOfPagesParameter);

                        await Connection.OpenAsync();

                        await Command.ExecuteNonQueryAsync();

                        NumberOfPages =
                            (int)NumberOfPagesParameter.Value;
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

    }
}
