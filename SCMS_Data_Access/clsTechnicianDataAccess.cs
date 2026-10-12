using SharedLib;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading.Tasks;

namespace SCMS_Data_Access
{
    public class clsTechnicianDataAccess
    {
        public static int? AddNewTechnician(
            int EmployeeID,
            byte  Specialization,
            int CreatedByUserID)
        {
            int? TechnicianID = null;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_AddNewTechnician", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("EmployeeID", EmployeeID);
                        Command.Parameters.AddWithValue("Specialization", Specialization);
                        Command.Parameters.AddWithValue("CreatedByUserID", CreatedByUserID);

                        SqlParameter TechnicianIDParameter =
                            new SqlParameter("TechnicianID", SqlDbType.Int)
                            {
                                Direction = ParameterDirection.Output
                            };

                        Command.Parameters.Add(TechnicianIDParameter);

                        Connection.Open();
                        Command.ExecuteNonQuery();

                        TechnicianID =
                            (int)Command.Parameters["TechnicianID"].Value;
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

            return TechnicianID;
        }

    
        public static bool FindTechnician(
            int TechnicianID,
            ref int EmployeeID,
            ref byte Specialization,
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
                        new SqlCommand("SP_FindTechnician", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("TechnicianID", TechnicianID);

                        Connection.Open();

                        using (SqlDataReader Data = Command.ExecuteReader())
                        {

                            if (Data.Read())
                            {
                                EmployeeID = (int)Data["EmployeeID"];
                                Specialization = (byte)Data["Specialization"];
                                CreatedByUserID = (int)Data["CreatedByUserID"];
                                CreatedDate = (DateTime)Data["CreatedDate"];

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

        public static bool FindTechnicianByEmployeeID(
            ref int TechnicianID,
            int EmployeeID,
            ref byte Specialization,
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
                        new SqlCommand("SP_FindTechnicianByEmployeeID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("EmployeeID", EmployeeID);

                        Connection.Open();

                        using (SqlDataReader Data = Command.ExecuteReader())
                        {
                            if (Data.Read())
                            {
                                TechnicianID = (int)Data["TechnicianID"];
                                Specialization = (byte)Data["Specialization"];
                                CreatedByUserID = (int)Data["CreatedByUserID"];
                                CreatedDate = (DateTime)Data["CreatedDate"];

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

        public static bool FindTechnicianByPhoneNumber(
            string PhoneNumber,
           ref int TechnicianID,
           ref int EmployeeID,
           ref byte Specialization,
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
                        new SqlCommand("SP_FindTechnicianByPhoneNumber", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("PhoneNumber", PhoneNumber);

                        Connection.Open();

                        using (SqlDataReader Data = Command.ExecuteReader())
                        {
                            if (Data.Read())
                            {
                                TechnicianID = (int)Data["TechnicianID"];
                                EmployeeID = (int)Data["EmployeeID"];
                                Specialization = (byte)Data["Specialization"];
                                CreatedByUserID = (int)Data["CreatedByUserID"];
                                CreatedDate = (DateTime)Data["CreatedDate"];

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


        public static bool UpdateTechnician(
            int TechnicianID,
            int EmployeeID,
            byte Specialization,
            int? LastUpdatedUserID)
        {
            bool IsUpdated = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_UpdateTechnician", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("TechnicianID", TechnicianID);
                        Command.Parameters.AddWithValue("EmployeeID", EmployeeID);
                        Command.Parameters.AddWithValue("Specialization", Specialization);

                        Command.Parameters.AddWithValue(
                            "LastUpdatedUserID",
                            LastUpdatedUserID ?? (object)DBNull.Value);

                        SqlParameter ReturnValue =
                            new SqlParameter("ReturnValue", SqlDbType.Int)
                            {
                                Direction = ParameterDirection.ReturnValue
                            };

                        Command.Parameters.Add(ReturnValue);

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

       
        public static bool DeleteTechnician(int TechnicianID)
        {
            bool IsDeleted = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_DeleteTechnician", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("TechnicianID", TechnicianID);

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

       
        public static bool IsTechnicianExists(int TechnicianID)
        {
            bool IsExists = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_IsTechnicianExists", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("TechnicianID", TechnicianID);

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

       
    

       
        public static async Task<DataTable> GetTechniciansAsync(
            int NumberOfTechniciansEachPage,
            int NumberOfPage)
        {
            DataTable Technicians = new DataTable();

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_GetTechnicians", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "NumberOfTechniciansEachPage",
                            NumberOfTechniciansEachPage);

                        Command.Parameters.AddWithValue(
                            "NumberOfPage",
                            NumberOfPage);

                        await Connection.OpenAsync();

                        using (SqlDataReader Reader= await Command.ExecuteReaderAsync())
                        {
                            Technicians.Load(Reader );
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

            return Technicians;
        }

       
        public static async Task<int> GetTechniciansNumberOfPagesAsync(
            int TechniciansEachPage)
        {
            int NumberOfPages = 0;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_GetTechniciansNumberPages", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "TechniciansEachPage",
                            TechniciansEachPage);

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

        public static int? GetTechnicianIDByEmployeeID(int EmployeeID)
        {
            int? TechnicianID = null;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_GetTechnicianIDByEmployeeID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("EmployeeID", EmployeeID);

                        Connection.Open();

                        object Result = Command.ExecuteScalar();
                        TechnicianID = (Result != null) ? (int?)Result : null;
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

            return TechnicianID;
        }
    }
}