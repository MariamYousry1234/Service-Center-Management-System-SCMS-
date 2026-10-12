using SharedLib;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading.Tasks;

namespace SCMS_Data_Access
{
    public class clsCustomerDataAccess
    {
        public static int? AddNewCustomer(

           string FirstName,
           string SecondName,
           string? ThirdName,
           string? LastName,
          byte Gender, 
         string PhoneNumber,
          string? Email,
            string Address,
          string? Notes,
          int CreatedByUserID
            )
        {
            int? CustomerID = null;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_AddNewCustomer", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                          "FirstName",
                          FirstName );


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
                            "Notes",
                            Notes ?? (object)DBNull.Value);

                        Command.Parameters.AddWithValue(
                            "CreatedByUserID",
                            CreatedByUserID);


                     
                        SqlParameter CustomerIDParameter =
                            new SqlParameter("CustomerID", SqlDbType.Int)
                            {
                                Direction = ParameterDirection.Output
                            };

                        Command.Parameters.Add(CustomerIDParameter);

                        Connection.Open();
                        Command.ExecuteNonQuery();

                        CustomerID =
                            (int)Command.Parameters["CustomerID"].Value;
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


        public static bool FindCustomer(
            int CustomerID,
            ref string FirstName,
           ref string SecondName,
           ref string? ThirdName,
           ref string? LastName,
          ref byte Gender,
          ref string PhoneNumber,
          ref string? Email,
          ref string Address,
          ref string? Notes,
          ref int CreatedByUserID,
          ref DateTime CreatedDate,
         ref int? LastUpdatedUserID,
           ref DateTime? LastUpdatedDate
          )
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_FindCustomer", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "CustomerID",
                            CustomerID);

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

                                Notes =
                                    Data["Notes"] == DBNull.Value
                                    ? null
                                    : (string)Data["Notes"];

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


        

        public static bool FindCustomerByPhoneNumber(
    string PhoneNumber,
    ref int CustomerID,
    ref string FirstName,
     ref string SecondName,
    ref string? ThirdName,
    ref string? LastName,
     ref byte Gender,
     ref string? Email,
      ref string Address,
    ref string? Notes,
    ref int CreatedByUserID,
    ref DateTime CreatedDate,
    ref int? LastUpdatedUserID,
    ref DateTime? LastUpdatedDate
   
            )
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_FindCustomerByPhoneNumber",
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
                                CustomerID =
                                    (int)Data["CustomerID"];


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

                                Notes =
                                    Data["Notes"] == DBNull.Value
                                    ? null
                                    : (string)Data["Notes"];

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


        public static bool UpdateCustomer(
        int CustomerID,
          string FirstName,
          string SecondName,
          string? ThirdName,
          string? LastName,
          byte Gender,
         string PhoneNumber,
         string? Email,
           string Address,
        string? Notes,
        int? LastUpdatedUserID
      )
        {
            bool IsUpdated = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_UpdateCustomer", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "CustomerID",
                            CustomerID);

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
                            "Notes",
                            Notes ?? (object)DBNull.Value);

                        Command.Parameters.AddWithValue(
                            "LastUpdatedUserID",
                            LastUpdatedUserID ?? (object)DBNull.Value);

            

                        SqlParameter OutputParameter =
                            new SqlParameter(
                                "ReturnValue",
                                SqlDbType.Int)
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


        public static bool DeleteCustomer(int CustomerID)
        {
            bool IsDeleted = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_DeleteCustomer",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "CustomerID",
                            CustomerID);

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


        public static bool IsCustomerExists(int CustomerID)
        {
            bool IsExists = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_IsCustomerExists",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "CustomerID",
                            CustomerID);

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


        public static async Task<DataTable> GetCustomersAsync(
            int NumberOfCustomersEachPage,
            int NumberOfPage)
        {
            DataTable CustomersData = new DataTable();

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_GetCustomers",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "NumberOfCustomersEachPage",
                            NumberOfCustomersEachPage);

                        Command.Parameters.AddWithValue(
                            "NumberOfPage",
                            NumberOfPage);

                        await Connection.OpenAsync();

                        using (SqlDataReader Data =
                            await Command.ExecuteReaderAsync())
                        {
                            CustomersData.Load(Data);
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

            return CustomersData;
        }


        public static async Task<int> GetCustomersNumberOfPagesAsync(
            int CustomersEachPage)
        {
            int NumberOfPages = 0;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_GetCustomersNumberPages",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "CustomersEachPage",
                            CustomersEachPage);

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
      

        public static bool IsCustomerAlreadyEmployee(int CustomerID)
        {
            bool IsEmployee = false;
            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_IsCustomerAlreadyEmployee",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "CustomerID",
                            CustomerID);


                        Connection.Open();


                        IsEmployee = Command.ExecuteScalar() != null;

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

            return IsEmployee;
        }

        public static int? ConvertCustomerToEmployee(int CustomerID,DateTime HireDate,
            int CreatedByUserID)
        {
            int? EmployeeID = null;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_ConvertCustomerToEmployee",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "CustomerID",
                            CustomerID);


                        Command.Parameters.AddWithValue(
                            "HireDate",
                            HireDate);


                        Command.Parameters.AddWithValue(
                            "CreatedByUserID",
                            CreatedByUserID);

                        SqlParameter OutputParameter =
                              new SqlParameter(
                                  "EmployeeID",
                                  SqlDbType.Int)
                              {
                                  Direction = ParameterDirection.Output
                              };

                        Command.Parameters.Add(OutputParameter);

                        Connection.Open();

                        Command.ExecuteNonQuery();

                        EmployeeID = (int)OutputParameter.Value;

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
    }
}