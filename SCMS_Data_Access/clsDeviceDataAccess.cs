using SharedLib;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCMS_Data_Access
{
    public  class clsDeviceDataAccess
    {
        public static int? AddNewDevice(
         int CustomerID,
         int DeviceTypeID,
         int BrandID,
         int ModelID,
         string SerialNumber,
         byte Color,
         int CreatedByUserID)
        {
            int? DeviceID = null;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_AddNewDevice", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("CustomerID", CustomerID);
                        Command.Parameters.AddWithValue("DeviceTypeID", DeviceTypeID);
                        Command.Parameters.AddWithValue("BrandID", BrandID);
                        Command.Parameters.AddWithValue("ModelID", ModelID);
                        Command.Parameters.AddWithValue("SerialNumber", SerialNumber);
                        Command.Parameters.AddWithValue("Color", Color);
                    
                        Command.Parameters.AddWithValue("CreatedByUserID",
                            CreatedByUserID);

                        SqlParameter DeviceIDParameter =
                            new SqlParameter("DeviceID", SqlDbType.Int);

                        DeviceIDParameter.Direction =
                            ParameterDirection.Output;

                        Command.Parameters.Add(DeviceIDParameter);

                        Connection.Open();
                        Command.ExecuteNonQuery();

                        DeviceID = (int)Command.Parameters["DeviceID"].Value;
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

            return DeviceID;
        }

        public static bool FindDevice(
            int DeviceID,
            ref int CustomerID,
            ref int DeviceTypeID,
            ref int BrandID,
            ref int ModelID,
            ref string SerialNumber,
            ref byte Color,
          
            ref int CreatedByUserID,
            ref DateTime CreatedDate,
            ref int? LastUpdatedUserID,
            ref DateTime? LastUpdatedDate)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_FindDevice", Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("DeviceID",
                            DeviceID);

                        Connection.Open();

                        using (SqlDataReader Data =
                            Command.ExecuteReader())
                        {

                            if (Data.Read())
                            {
                                CustomerID = (int)Data["CustomerID"];
                                DeviceTypeID = (int)Data["DeviceTypeID"];
                                BrandID = (int)Data["BrandID"];
                                ModelID = (int)Data["ModelID"];
                                SerialNumber = (string)Data["SerialNumber"];
                                Color = Convert.ToByte(Data["Color"]);



                                CreatedByUserID =
                                    (int)Data["CreatedByUserID"];

                                CreatedDate =
                                    (DateTime)Data["CreatedDate"];

                                LastUpdatedUserID =
                                    Data["LastUpdatedUserID"] == DBNull.Value
                                    ? null
                                    : (int?)Data["LastUpdatedUserID"];

                                LastUpdatedDate =
                                    Data["LastUpdatedDate"] == DBNull.Value
                                    ? null
                                    : (DateTime?)Data["LastUpdatedDate"];

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

        public static bool FindDevice(
          ref int DeviceID,
          ref int CustomerID,
          ref int DeviceTypeID,
          ref int BrandID,
          ref int ModelID,
           string SerialNumber,
          ref byte Color,
        
          ref int CreatedByUserID,
          ref DateTime CreatedDate,
          ref int? LastUpdatedUserID,
          ref DateTime? LastUpdatedDate)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_FindDeviceBySerialNumber", Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("SerialNumber",
                            SerialNumber);

                        Connection.Open();

                        using (SqlDataReader Data =
                            Command.ExecuteReader())
                        {
                            if (Data.Read())
                            {
                                DeviceID = (int)Data["DeviceID"];
                                CustomerID = (int)Data["CustomerID"];
                                DeviceTypeID = (int)Data["DeviceTypeID"];
                                BrandID = (int)Data["BrandID"];
                                ModelID = (int)Data["ModelID"];

                                Color = Convert.ToByte(Data["Color"]);


                                CreatedByUserID =
                                    (int)Data["CreatedByUserID"];

                                CreatedDate =
                                    (DateTime)Data["CreatedDate"];

                                LastUpdatedUserID =
                                    Data["LastUpdatedUserID"] == DBNull.Value
                                    ? null
                                    : (int?)Data["LastUpdatedUserID"];

                                LastUpdatedDate =
                                    Data["LastUpdatedDate"] == DBNull.Value
                                    ? null
                                    : (DateTime?)Data["LastUpdatedDate"];

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

        public static bool UpdateDevice(
            int DeviceID,
            int CustomerID,
            int DeviceTypeID,
            int BrandID,
            int ModelID,
            string SerialNumber,
            byte Color,
          
            int? LastUpdatedUserID)
        {
            bool IsUpdated = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_UpdateDevice", Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("DeviceID", DeviceID);
                        Command.Parameters.AddWithValue("CustomerID", CustomerID);
                        Command.Parameters.AddWithValue("DeviceTypeID", DeviceTypeID);
                        Command.Parameters.AddWithValue("BrandID", BrandID);
                        Command.Parameters.AddWithValue("ModelID", ModelID);
                        Command.Parameters.AddWithValue("SerialNumber", SerialNumber);
                        Command.Parameters.AddWithValue("Color", Color);


                        Command.Parameters.AddWithValue(
                            "LastUpdatedUserID",
                            LastUpdatedUserID ?? (object)DBNull.Value);

                        SqlParameter ReturnValue =
                            new SqlParameter("ReturnValue",
                            SqlDbType.Int);

                        ReturnValue.Direction =
                            ParameterDirection.ReturnValue;

                        Command.Parameters.Add(ReturnValue);

                        Connection.Open();
                        Command.ExecuteNonQuery();

                        IsUpdated =
                            ((int)ReturnValue.Value > 0);
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

        public static bool DeleteDevice(int DeviceID)
        {
            bool IsDeleted = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_DeleteDevice", Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "DeviceID",
                            DeviceID);

                        SqlParameter ReturnValue =
                            new SqlParameter("ReturnValue",
                            SqlDbType.Int);

                        ReturnValue.Direction =
                            ParameterDirection.ReturnValue;

                        Command.Parameters.Add(ReturnValue);

                        Connection.Open();
                        Command.ExecuteNonQuery();

                        IsDeleted =
                            ((int)ReturnValue.Value > 0);
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

        public static bool IsDeviceExists(int DeviceID)
        {
            bool IsExists = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_IsDeviceExists", Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "DeviceID",
                            DeviceID);

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

        public static int? GetDeviceIDBySerialNnumber(string SerialNumber)
        {
            int? DeviceID = null;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_GetDeviceIDBySerialNumber", Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "SerialNumber",
                            SerialNumber);

                        Connection.Open();

                        object Result = Command.ExecuteScalar();
                        DeviceID =
                            (Result != null) ? (int?)Result : null;
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

            return DeviceID;
        }
        public static async Task<DataTable> GetDevicesAsync(
           int NumberOfDevicesEachPage,
          int NumberOfPage)
        {
            DataTable DevicesData = new DataTable();

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_GetDevices", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "NumberOfDevicesEachPage",
                            NumberOfDevicesEachPage);

                        Command.Parameters.AddWithValue(
                            "NumberOfPage",
                            NumberOfPage);

                        await Connection.OpenAsync();

                        using (SqlDataReader Data =
                            await Command.ExecuteReaderAsync())
                        {
                            DevicesData.Load(Data);
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

            return DevicesData;
        }


        public static async Task<int> GetDevicesNumberOfPagesAsync(
            int DevicesEachPage)
        {
            int NumberOfPages = 0;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_GetDevicesNumberPages",
                        Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "DevicesEachPage",
                            DevicesEachPage);

                        SqlParameter NumberOfPagesParameter =
                            new SqlParameter(
                                "NumberOfPages",
                                SqlDbType.Int)
                            {
                                Direction = ParameterDirection.ReturnValue
                            };

                        Command.Parameters.Add(NumberOfPagesParameter);

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

        public static async  Task<DataTable> GetDevicesForCustomer(int CustomerID)
        {
            DataTable AllDevices = new DataTable();

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_GetDevicesForCustomer", Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("CustomerID",
                            CustomerID);

                       await Connection.OpenAsync();

                      AllDevices.Load(await Command.ExecuteReaderAsync());

                       
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

            return AllDevices;
        }

        public static bool IsCustomerHasDevices(int CustomerID)
        {
            bool HasDevices = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_IsCustomerHasDevices", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("CustomerID", CustomerID);

                        Connection.Open();

                        HasDevices = Command.ExecuteScalar() != null;
                    }
                }
            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog
                    (clsSettings.ApplicationName, e.Message,
                    EventLogEntryType.Error);
            }

            return HasDevices;
        }

    }
}
