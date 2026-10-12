using SharedLib;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading.Tasks;

namespace SCMS_Data_Access
{
    public class clsDeviceTypeDataAccess
    {
        public static int? AddNewDeviceType(string DeviceTypeName)
        {
            int? DeviceTypeID = null;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_AddNewDeviceType", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "DeviceTypeName", DeviceTypeName);

                        SqlParameter DeviceTypeIDParameter =
                            new SqlParameter("DeviceTypeID", SqlDbType.Int)
                            {
                                Direction = ParameterDirection.Output
                            };

                        Command.Parameters.Add(DeviceTypeIDParameter);

                        Connection.Open();
                        Command.ExecuteNonQuery();

                        DeviceTypeID =
                            (int)Command.Parameters["DeviceTypeID"].Value;
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

            return DeviceTypeID;
        }


        public static bool FindDeviceType(
            int DeviceTypeID,
            ref string DeviceTypeName)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_FindDeviceType", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "DeviceTypeID", DeviceTypeID);

                        Connection.Open();
                        using (SqlDataReader Data = Command.ExecuteReader())
                        {
                            if (Data.Read())
                            {
                                DeviceTypeName =
                                    (string)Data["DeviceTypeName"];

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


        public static bool FindDeviceType(
           ref  int DeviceTypeID,
             string DeviceTypeName)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_FindDeviceTypeByName", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "DeviceTypeName", DeviceTypeName);

                        Connection.Open();
                        using (SqlDataReader Data = Command.ExecuteReader())
                        {
                            if (Data.Read())
                            {
                                DeviceTypeID =
                                    (int)Data["DeviceTypeID"];

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
        public static bool UpdateDeviceType(
            int DeviceTypeID,
            string DeviceTypeName)
        {
            bool IsUpdated = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_UpdateDeviceType", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "DeviceTypeID", DeviceTypeID);

                        Command.Parameters.AddWithValue(
                            "DeviceTypeName", DeviceTypeName);

                        SqlParameter OutputParameter =
                            new SqlParameter("ReturnValue", SqlDbType.Int)
                            {
                                Direction = ParameterDirection.ReturnValue
                            };

                        Command.Parameters.Add(OutputParameter);

                        Connection.Open();
                        Command.ExecuteNonQuery();

                        IsUpdated =
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

            return IsUpdated;
        }


        public static bool DeleteDeviceType(int DeviceTypeID)
        {
            bool IsDeleted = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_DeleteDeviceType", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "DeviceTypeID", DeviceTypeID);

                        SqlParameter OutputParameter =
                            new SqlParameter("ReturnValue", SqlDbType.Int)
                            {
                                Direction = ParameterDirection.ReturnValue
                            };

                        Command.Parameters.Add(OutputParameter);

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


        public static bool IsDeviceTypeExists(int DeviceTypeID)
        {
            bool IsExists = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_IsDeviceTypeExists", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "DeviceTypeID", DeviceTypeID);

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

        public static int? GetDeviceTypeIDByName(string DeviceTypeName)
        {
            int?  DeviceTypeID = null;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_GetDeviceTypeIDByName", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "DeviceTypeName", DeviceTypeName);

                        Connection.Open();

                        object Result = Command.ExecuteScalar();
                        DeviceTypeID = (Result != null)?(int?) Result:null;
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

            return DeviceTypeID;
        }
        public static async Task<DataTable> GetDeviceTypesAsync(
            int NumberOfDeviceTypesEachPage,
            int NumberOfPage)
        {
            DataTable DeviceTypesData = new DataTable();

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_GetDeviceTypes", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "NumberOfDeviceTypesEachPage",
                            NumberOfDeviceTypesEachPage);

                        Command.Parameters.AddWithValue(
                            "NumberOfPage",
                            NumberOfPage);

                        await Connection.OpenAsync();

                        using (SqlDataReader Data =
                            await Command.ExecuteReaderAsync())
                        {
                            DeviceTypesData.Load(Data);
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

            return DeviceTypesData;
        }


        public static async Task<DataTable> GetAllDeviceTypeNamesAsync()
        {
            DataTable DeviceTypesNames = new DataTable();

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_GetAllDeviceTypeNames", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        await Connection.OpenAsync();

                
                        DeviceTypesNames.Load(await Command.ExecuteReaderAsync());
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

            return DeviceTypesNames;
        }


        public static async Task<int> GetDeviceTypesNumberOfPagesAsync(
            int DeviceTypesEachPage)
        {
            int NumberOfPages = 0;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_GetDeviceTypesNumberPages",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "DeviceTypesEachPage",
                            DeviceTypesEachPage);

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