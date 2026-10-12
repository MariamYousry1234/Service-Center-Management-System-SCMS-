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
    public class clsEmployeeDataAccess
    {
        public static int? AddNewEmployee(

            string FirstName,
           string SecondName,
           string? ThirdName,
           string? LastName,
          byte Gender,
           string PhoneNumber,
           string? Email,
            string Address,
            DateTime HireDate,  
            int CreatedByUserID
         )
        {
            int? EmployeeID = null;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_AddNewEmployee", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                           "FirstName",
                           FirstName);


                        Command.Parameters.AddWithValue(
                          "SecondName",
                          SecondName);


                        Command.Parameters.AddWithValue(
                          "ThirdName",
                          ThirdName ?? (object)DBNull.Value);


                        Command.Parameters.AddWithValue(
                          "LastName",
                          LastName ?? (object)DBNull.Value);

                        Command.Parameters.AddWithValue(
                         "Gender",
                         Gender);

                        Command.Parameters.AddWithValue(
                      "PhoneNumber",
                      PhoneNumber);

                        Command.Parameters.AddWithValue(
                       "Email",
                        Email ?? (object)DBNull.Value);


                        Command.Parameters.AddWithValue(
                      "Address",
                       Address);


                        Command.Parameters.AddWithValue(
                            "HireDate", HireDate);

                        Command.Parameters.AddWithValue(
                            "CreatedByUserID",
                            CreatedByUserID );


                        SqlParameter EmployeeIDParameter =
                            new SqlParameter(
                                "EmployeeID",
                                SqlDbType.Int)
                            {
                                Direction = ParameterDirection.Output
                            };

                        Command.Parameters.Add(EmployeeIDParameter);

                        Connection.Open();

                        Command.ExecuteNonQuery();

                        EmployeeID =
                            (int)Command.Parameters["EmployeeID"].Value;
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

            return EmployeeID;
        }



        public static bool FindEmployee(
            int EmployeeID,
            ref string FirstName,
           ref string SecondName,
           ref string? ThirdName,
           ref string? LastName,
          ref byte Gender,
          ref string PhoneNumber,
          ref string? Email,
          ref string Address,
            ref DateTime HireDate,
            ref bool IsActive,
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
                        new SqlCommand("SP_FindEmployee", Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "EmployeeID", EmployeeID);

                        Connection.Open();

                        using (SqlDataReader Data =
                            Command.ExecuteReader())
                        {
                            if (Data.Read())
                            {
                                FirstName = (string)Data["FirstName"];


                                SecondName = (string)Data["SecondName"];

                                ThirdName = Data["ThirdName"] == DBNull.Value
                                     ? null
                                   : (string)Data["ThirdName"];

                                LastName = Data["LastName"] == DBNull.Value
                                   ? null
                                    : (string)Data["LastName"];

                                Gender = Convert.ToByte(Data["Gender"]);

                                PhoneNumber = (string)Data["PhoneNumber"];

                                Email = Data["Email"] == DBNull.Value ? null : (string)Data["Email"];

                                Address = (string)Data["Address"];

                                HireDate =
                                    Convert.ToDateTime(
                                        Data["HireDate"]);

                                IsActive =
                                    (bool)Data["IsActive"];

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


    

        public static bool FindEmployeeByPhoneNumber(
            string PhoneNumber,
            ref int EmployeeID,
             ref string FirstName,
             ref string SecondName,
             ref string? ThirdName,
             ref string? LastName,
              ref byte Gender,
             ref string? Email,
             ref string Address,
            ref DateTime HireDate,
            ref bool IsActive,
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
                        new SqlCommand(
                            "SP_FindEmployeeByPhoneNumber",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "PhoneNumber",
                            PhoneNumber);

                        Connection.Open();

                        using (SqlDataReader Data =
                            Command.ExecuteReader())
                        {
                            if (Data.Read())
                            {
                                EmployeeID =
                                    (int)Data["EmployeeID"];
                                FirstName = (string)Data["FirstName"];


                                SecondName = (string)Data["SecondName"];

                                ThirdName = Data["ThirdName"] == DBNull.Value
                                     ? null
                                   : (string)Data["ThirdName"];

                                LastName = Data["LastName"] == DBNull.Value
                                   ? null
                                    : (string)Data["LastName"];

                                Gender = Convert.ToByte(Data["Gender"]);


                                Email = Data["Email"] == DBNull.Value ? null :
                                    (string)Data["Email"];

                                Address = (string)Data["Address"];


                                HireDate =
                                    Convert.ToDateTime(
                                        Data["HireDate"]);

                                IsActive =
                                    (bool)Data["IsActive"];

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


        public static bool UpdateEmployee(
            int EmployeeID,
            string FirstName,
           string SecondName,
           string? ThirdName,
           string? LastName,
           byte Gender,
           string PhoneNumber,
           string? Email,
            string Address,
            DateTime HireDate,
            int? LastUpdatedUserID)
        {
            bool IsUpdated = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_UpdateEmployee",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "EmployeeID", EmployeeID);

                        Command.Parameters.AddWithValue(
                             "FirstName",
                             FirstName);


                        Command.Parameters.AddWithValue(
                          "SecondName",
                          SecondName);


                        Command.Parameters.AddWithValue(
                          "ThirdName",
                          ThirdName ?? (object)DBNull.Value);


                        Command.Parameters.AddWithValue(
                          "LastName",
                          LastName ?? (object)DBNull.Value);

                        Command.Parameters.AddWithValue(
                         "Gender",
                         Gender);

                        Command.Parameters.AddWithValue(
                      "PhoneNumber",
                      PhoneNumber);

                        Command.Parameters.AddWithValue(
                       "Email",
                        Email ?? (object)DBNull.Value);


                        Command.Parameters.AddWithValue(
                      "Address",
                       Address);

                        Command.Parameters.AddWithValue(
                            "HireDate", HireDate);
          

                        Command.Parameters.AddWithValue(
                            "LastUpdatedUserID",
                            LastUpdatedUserID ?? (object)DBNull.Value);

                      
                        SqlParameter OutputParameter =
                            new SqlParameter(
                                "ReturnValue",
                                SqlDbType.Int)
                            {
                                Direction =
                                    ParameterDirection.ReturnValue
                            };

                        Command.Parameters.Add(OutputParameter);

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


        public static bool DeleteEmployee(int EmployeeID)
        {
            bool IsDeleted = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_DeleteEmployee",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "EmployeeID",
                            EmployeeID);

                        SqlParameter OutputParameter =
                            new SqlParameter(
                                "ReturnValue",
                                SqlDbType.Int)
                            {
                                Direction =
                                    ParameterDirection.ReturnValue
                            };

                        Command.Parameters.Add(OutputParameter);

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


        public static bool IsEmployeeExists(int EmployeeID)
        {
            bool IsExists = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_IsEmployeeExists",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "EmployeeID",
                            EmployeeID);

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


        public static async Task<DataTable> GetEmployeesAsync(
            int NumberOfEmployeesEachPage,
            int NumberOfPage)
        {
            DataTable EmployeesData =
                new DataTable();

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(
                        clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_GetEmployees",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "NumberOfEmployeesEachPage",
                            NumberOfEmployeesEachPage);

                        Command.Parameters.AddWithValue(
                            "NumberOfPage",
                            NumberOfPage);

                        await Connection.OpenAsync();

                        using (SqlDataReader Data =
                             await Command.ExecuteReaderAsync())
                        {
                            EmployeesData.Load(Data);
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

            return EmployeesData;
        }


        public static async Task<int> GetEmployeesNumberOfPagesAsync(
            int EmployeesEachPage)
        {
            int NumberOfPages = 0;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(
                        clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_GetEmployeesNumberPages",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "EmployeesEachPage",
                            EmployeesEachPage);

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


       
        public static bool DeactivateEmployee(int EmployeeID)
        {
            bool IsDeactivate = false;
            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_DeactivateEmployee",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "EmployeeID",
                            EmployeeID);


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

        public static bool ActivateEmployee(int EmployeeID)
        {
            bool IsActivate = false;
            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_ActivateEmployee",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "EmployeeID",
                            EmployeeID);


                        Connection.Open();


                        IsActivate = (int)Command.ExecuteNonQuery() > 0;

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

            return IsActivate;
        }
        public static bool IsEmployeeAlreadyCustomer(int EmployeeID)
        {
            bool IsCustomer = false;
            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_IsEmployeeAlreadyCustomer",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "EmployeeID",
                            EmployeeID);


                        Connection.Open();


                        IsCustomer = Command.ExecuteScalar() != null;

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

            return IsCustomer;
        }

        public static int? ConvertEmployeeToCustomer(int EmployeeID, string? Notes,
            int CreatedByUserID)
        {
            int? CustomerID = null;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_ConvertEmployeeToCustomer",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "EmployeeID",
                            EmployeeID);


                        Command.Parameters.AddWithValue(
                            "Notes",
                            Notes ?? (object)DBNull.Value);


                        Command.Parameters.AddWithValue(
                            "CreatedByUserID",
                            CreatedByUserID);

                        SqlParameter OutputParameter =
                              new SqlParameter(
                                  "CustomerID",
                                  SqlDbType.Int)
                              {
                                  Direction = ParameterDirection.Output
                              };

                        Command.Parameters.Add(OutputParameter);

                        Connection.Open();

                        Command.ExecuteNonQuery();

                        CustomerID = (int)OutputParameter.Value;

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

            return CustomerID;
        }
    }
}