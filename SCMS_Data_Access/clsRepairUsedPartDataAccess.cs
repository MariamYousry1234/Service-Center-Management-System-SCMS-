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
    public class clsRepairUsedPartDataAccess
    {
        public static int? AddNewRepairUsedPart(
           int RepairOrderID,
           int UsedPartID,
           int Quantity,
           float PartPrice)
        {
            int? RepairUsedPartID = null;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_AddNewRepairUsedPart",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "RepairOrderID",
                            RepairOrderID);

                        Command.Parameters.AddWithValue(
                            "UsedPartID",
                            UsedPartID);

                        Command.Parameters.AddWithValue(
                            "Quantity",
                            Quantity);

                        Command.Parameters.AddWithValue(
                            "PartPrice",
                            PartPrice);

                        SqlParameter RepairUsedPartIDParameter =
                            new SqlParameter(
                                "RepairUsedPartID",
                                SqlDbType.Int)
                            {
                                Direction =
                                    ParameterDirection.Output
                            };

                        Command.Parameters.Add(
                            RepairUsedPartIDParameter);

                        Connection.Open();
                        Command.ExecuteNonQuery();

                        RepairUsedPartID =
                            (int)Command.Parameters[
                                "RepairUsedPartID"].Value;
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

            return RepairUsedPartID;
        }

        public static bool FindRepairUsedPart(
            int RepairUsedPartID,
            ref int RepairOrderID,
            ref int UsedPartID,
            ref int Quantity,
            ref float PartPrice,
            ref float TotalPrice,
            ref DateTime UsedDate)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_FindRepairUsedPart",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "RepairUsedPartID",
                            RepairUsedPartID);

                        Connection.Open();

                        using (SqlDataReader Data =
                            Command.ExecuteReader())
                        {
                            if (Data.Read())
                            {
                                RepairOrderID =
                                    (int)Data["RepairOrderID"];

                                UsedPartID =
                                    (int)Data["UsedPartID"];

                                Quantity =
                                    (int)Data["Quantity"];

                                PartPrice =
                                    Convert.ToSingle(
                                        Data["PartPrice"]);

                                TotalPrice =
                                    Convert.ToSingle(
                                        Data["TotalPrice"]);
                             
                                UsedDate =
                                   (DateTime)Data["UsedDate"];

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

        public static bool UpdateRepairUsedPart(
            int RepairUsedPartID,
            int RepairOrderID,
            int UsedPartID,
            int Quantity,
            float PartPrice)
        {
            bool IsUpdated = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_UpdateRepairUsedPart",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "RepairUsedPartID",
                            RepairUsedPartID);

                        Command.Parameters.AddWithValue(
                            "RepairOrderID",
                            RepairOrderID);

                        Command.Parameters.AddWithValue(
                            "UsedPartID",
                            UsedPartID);

                        Command.Parameters.AddWithValue(
                            "Quantity",
                            Quantity);

                        Command.Parameters.AddWithValue(
                            "PartPrice",
                            PartPrice);

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
                            ((int)Command.Parameters[
                                "ReturnValue"].Value > 0);
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

        public static bool DeleteRepairUsedPart(
            int RepairUsedPartID)
        {
            bool IsDeleted = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_DeleteRepairUsedPart",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "RepairUsedPartID",
                            RepairUsedPartID);

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
                            ((int)Command.Parameters[
                                "ReturnValue"].Value > 0);
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

        public static bool IsRepairUsedPartExists(
            int RepairUsedPartID)
        {
            bool IsExists = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_IsRepairUsedPartExists",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "RepairUsedPartID",
                            RepairUsedPartID);

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

        public static async Task<DataTable> GetRepairUsedPartsAsync(
            int NumberOfRepairUsedPartsEachPage,
            int NumberOfPage)
        {
            DataTable RepairUsedPartsData =
                new DataTable();

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_GetRepairUsedParts",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "NumberOfRepairUsedPartsEachPage",
                            NumberOfRepairUsedPartsEachPage);

                        Command.Parameters.AddWithValue(
                            "NumberOfPage",
                            NumberOfPage);

                        await Connection.OpenAsync();

                        using (SqlDataReader Data =
                            await Command.ExecuteReaderAsync())
                        {
                            RepairUsedPartsData.Load(Data);
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

            return RepairUsedPartsData;
        }

        public static async Task<int>
            GetRepairUsedPartsNumberOfPagesAsync(
                int RepairUsedPartsEachPage)
        {
            int NumberOfPages = 0;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_GetRepairUsedPartsNumberPages",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "RepairUsedPartsEachPage",
                            RepairUsedPartsEachPage);

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
