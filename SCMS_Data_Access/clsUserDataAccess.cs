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
    public  class clsUserDataAccess
    {
        public static int? AddNewUser(
    int EmployeeID,
    string Username,
    string Password,
    int? Permissions)
        {
            int? UserID = null;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_AddNewUser", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("EmployeeID", EmployeeID);
                        Command.Parameters.AddWithValue("Username", Username);
                        Command.Parameters.AddWithValue("Password", Password);

                        Command.Parameters.AddWithValue(
                            "Permissions",
                            Permissions ?? (object)DBNull.Value);

          

                        SqlParameter UserIDParameter =
                            new SqlParameter("UserID", SqlDbType.Int)
                            {
                                Direction = ParameterDirection.Output
                            };

                        Command.Parameters.Add(UserIDParameter);

                        Connection.Open();

                        Command.ExecuteNonQuery();

                        UserID = (int)UserIDParameter.Value;
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

            return UserID;
        }

        public static bool FindUser(
    int UserID,
    ref int EmployeeID,
    ref string Username,
    ref string Password,
    ref int? Permissions,
    ref bool IsActive,
    ref DateTime CreatedDate)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_FindUser", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("UserID", UserID);

                        Connection.Open();

                        SqlDataReader Data =
                            Command.ExecuteReader();

                        if (Data.Read())
                        {
                            EmployeeID = (int)Data["EmployeeID"];
                            Username = (string)Data["Username"];
                            Password = (string)Data["Password"];

                            Permissions =
                                Data["Permissions"] == DBNull.Value
                                ? null
                                : (int?)Data["Permissions"];

                            IsActive = (bool)Data["IsActive"];

                            CreatedDate =
                                Convert.ToDateTime(Data["CreatedDate"]);

                            IsFound = true;
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


        public static bool FindUserByUsername(
    string Username,
    ref int UserID,
    ref int EmployeeID,
    ref string Password,
    ref int? Permissions,
    ref bool IsActive,
    ref DateTime CreatedDate)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_FindUserByUsername", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "Username",
                            Username);

                        Connection.Open();

                        using (SqlDataReader Data =
                            Command.ExecuteReader())
                        {
                            if (Data.Read())
                            {
                                UserID = (int)Data["UserID"];

                                EmployeeID =
                                    (int)Data["EmployeeID"];

                                Password =
                                    (string)Data["Password"];

                                Permissions =
                                    Data["Permissions"] == DBNull.Value
                                    ? null
                                    : (int?)Data["Permissions"];

                                IsActive =
                                    (bool)Data["IsActive"];

                                CreatedDate =
                                    Convert.ToDateTime(
                                        Data["CreatedDate"]);

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

        public static bool FindByUsernameAndPassword(
    string Username,
    ref int UserID,
    ref int EmployeeID,
    string Password,
    ref int? Permissions,
    ref bool IsActive,
    ref DateTime CreatedDate)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_FindUserByUsernameAndPassword", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "Username",
                            Username);

                        Command.Parameters.AddWithValue(
                       "Password",
                         Password);
                        Connection.Open();

                        using (SqlDataReader Data =
                            Command.ExecuteReader())
                        {
                            if (Data.Read())
                            {
                                UserID = (int)Data["UserID"];

                                EmployeeID =
                                    (int)Data["EmployeeID"];

                                Permissions =
                                    Data["Permissions"] == DBNull.Value
                                    ? null
                                    : (int?)Data["Permissions"];

                                IsActive =
                                    (bool)Data["IsActive"];

                                CreatedDate =
                                    Convert.ToDateTime(
                                        Data["CreatedDate"]);

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

        public static bool UpdateUser(
    int UserID,
    int EmployeeID,
    string Username,
    int? Permissions
   )
        {
            bool IsUpdated = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_UpdateUser", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("UserID", UserID);
                        Command.Parameters.AddWithValue("EmployeeID", EmployeeID);
                        Command.Parameters.AddWithValue("Username", Username);
 

                        Command.Parameters.AddWithValue(
                            "Permissions",
                            Permissions ?? (object)DBNull.Value);


                        SqlParameter ReturnValue =
                            new SqlParameter("ReturnValue", SqlDbType.Int)
                            {
                                Direction = ParameterDirection.ReturnValue
                            };

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


        public static bool IsUserExists(int UserID)
        {
            bool IsExists = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_IsUserExists", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "UserID",
                            UserID);

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

        public static bool IsUsernameExists(string Username)
        {
            bool IsExists = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_IsUsernameExists", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "Username",
                            Username);

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

        public static bool DeleteUser(int UserID)
        {
            bool IsDeleted = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_DeleteUser", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "UserID",
                            UserID);

                        SqlParameter ReturnValue =
                            new SqlParameter("ReturnValue", SqlDbType.Int)
                            {
                                Direction = ParameterDirection.ReturnValue
                            };

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

        public static bool IsEmployeeAlreadyAUser(int EmployeeID)
        {
            bool IsUser = false;


            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_IsEmployeeAlreadyAUser", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;


                        Command.Parameters.AddWithValue(
                            "EmployeeID",
                            EmployeeID);


                        Connection.Open();


                        IsUser =
                            Command.ExecuteScalar() != null;
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


            return IsUser;
        }
     
            
        public static async Task<DataTable> GetUsersAsync(
    int NumberOfUsersEachPage,
    int NumberOfPage)
        {
            DataTable UsersData = new DataTable();

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_GetUsers", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "NumberOfUsersEachPage",
                            NumberOfUsersEachPage);

                        Command.Parameters.AddWithValue(
                            "NumberOfPage",
                            NumberOfPage);

                        await Connection.OpenAsync();

                        using (SqlDataReader Data =
                             await Command.ExecuteReaderAsync())
                        {
                            UsersData.Load(Data);
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

            return UsersData;
        }


        public static async Task<int> GetUsersNumberOfPagesAsync(int UsersEachPage)
        {
            int NumberOfPages = 0;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_GetUsersNumberPages", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "UsersEachPage",
                            UsersEachPage);

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

        public static async Task<DataTable> GetAccountsForAnEmployee(int EmployeeID)
        {
            DataTable AllAcounts = new DataTable();

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_GetAccountsForAnEmployee", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "EmployeeID",
                             EmployeeID);

  
                        await Connection.OpenAsync();

                        using(SqlDataReader Reader= await Command.ExecuteReaderAsync())
                        {
                            AllAcounts.Load(Reader);
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
            return AllAcounts;
        }

        public static bool DeactivateUser(int UserID)
        {
            bool IsDeactivate = false;
            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_DeactivateUser",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "UserID",
                            UserID);


                        Connection.Open();


                        IsDeactivate = (int)Command.ExecuteNonQuery() > 0;

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

            return IsDeactivate;
        }

        public static bool ActivateUser(int UserID)
        {
            bool IsDeactivate = false;
            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_ActivateUser",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "UserID",
                            UserID);


                        Connection.Open();


                        IsDeactivate = (int)Command.ExecuteNonQuery() > 0;

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

            return IsDeactivate;
        }

        public static bool UpdatePassword(int UserID,string NewPassword)
        {
            bool IsUpdated = false;
            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_UpdatePassword",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "UserID",
                            UserID);

                        Command.Parameters.AddWithValue(
                          "NewPassword",
                          NewPassword);

                        Connection.Open();


                        IsUpdated = ((int)Command.ExecuteNonQuery()) > 0;

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
    }
}
