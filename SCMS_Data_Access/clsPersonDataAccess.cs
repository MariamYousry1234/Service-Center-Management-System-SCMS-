using SharedLib;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading.Tasks;

namespace SCMS_Data_Access
{
    public class clsPersonDataAccess
    {

        public static int? AddNewPerson(string FirstName, string SecondName,
            string? ThirdName, string? LastName, byte Gender, string PhoneNumber, string? Email,
            string Address)
        {
            int? PersonID = null;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_AddNewPerson", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("FirstName", FirstName);
                        Command.Parameters.AddWithValue("SecondName", SecondName);
                        Command.Parameters.AddWithValue("ThirdName", ThirdName ?? (object)DBNull.Value);
                        Command.Parameters.AddWithValue("LastName", LastName ?? (object)DBNull.Value);
                        Command.Parameters.AddWithValue("Gender", Gender);
                        Command.Parameters.AddWithValue("PhoneNumber", PhoneNumber);
                        Command.Parameters.AddWithValue("Email", Email ?? (object)DBNull.Value);
                        Command.Parameters.AddWithValue("Address", Address);

                        SqlParameter PersonIDParameter = new SqlParameter("PersonID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        Command.Parameters.Add(PersonIDParameter);

                        Connection.Open();
                        Command.ExecuteNonQuery();

                        PersonID = (int)Command.Parameters["PersonID"].Value;
                    }
                }
            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog
                    (clsSettings.ApplicationName, e.Message,
                    EventLogEntryType.Error);
            }


            return PersonID;
        }


        public static bool FindPerson(int PersonID, ref string FirstName, ref string SecondName,
             ref string? ThirdName, ref string? LastName, ref byte Gender, ref string PhoneNumber, ref string? Email,
             ref string Address)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_FindPerson", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("PersonID", PersonID);

                        Connection.OpenAsync();
                        using (SqlDataReader Data = Command.ExecuteReader())
                        {

                            if (Data.Read())
                            {
                                FirstName = (string)Data["FirstName"];
                                SecondName = (string)Data["SecondName"];
                                ThirdName = Data["ThirdName"] == DBNull.Value ? null : (string)Data["ThirdName"];
                                LastName = Data["LastName"] == DBNull.Value ? null : (string)Data["LastName"];
                                Gender = Convert.ToByte(Data["Gender"]);
                                PhoneNumber = (string)Data["PhoneNumber"];
                                Email = Data["Email"] == DBNull.Value ? null : (string)Data["Email"];
                                Address = (string)Data["Address"];


                                IsFound = true;
                            }
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

            return IsFound;

        }

        public static bool FindPersonByPhoneNumber(ref int PersonID, ref string FirstName, ref string SecondName,
        ref string? ThirdName, ref string? LastName, ref byte Gender, string PhoneNumber, ref string? Email,
        ref string Address)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_FindPersonByPhoneNumber", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("PhoneNumber", PhoneNumber);

                        Connection.OpenAsync();
                        using (SqlDataReader Data = Command.ExecuteReader())
                        {

                            if (Data.Read())
                            {
                                PersonID = (int)Data["PersonID"];
                                FirstName = (string)Data["FirstName"];
                                SecondName = (string)Data["SecondName"];
                                ThirdName = Data["ThirdName"] == DBNull.Value ? null : (string)Data["ThirdName"];
                                LastName = Data["LastName"] == DBNull.Value ? null : (string)Data["LastName"];
                                Gender = Convert.ToByte(Data["Gender"]);

                                Email = Data["Email"] == DBNull.Value ? null : (string)Data["Email"];
                                Address = (string)Data["Address"];


                                IsFound = true;
                            }

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

            return IsFound;

        }
        public static bool UpdatePerson(int PersonID, string FirstName, string SecondName,
              string? ThirdName, string? LastName, byte Gender, string PhoneNumber, string? Email,
              string Address)
        {
            bool IsUpdated = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_UpdatePerson", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;


                        Command.Parameters.AddWithValue("FirstName", FirstName);
                        Command.Parameters.AddWithValue("SecondName", SecondName);
                        Command.Parameters.AddWithValue("ThirdName", ThirdName ?? (object)DBNull.Value);
                        Command.Parameters.AddWithValue("LastName", LastName ?? (object)DBNull.Value);
                        Command.Parameters.AddWithValue("Gender", Gender);
                        Command.Parameters.AddWithValue("PhoneNumber", PhoneNumber);
                        Command.Parameters.AddWithValue("Email", Email ?? (object)DBNull.Value);
                        Command.Parameters.AddWithValue("Address", Address);

                        Command.Parameters.AddWithValue("PersonID", PersonID);

                        SqlParameter OutputParameter = new SqlParameter("ReturnValue", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };

                        Command.Parameters.Add(OutputParameter);


                        Connection.Open();
                        Command.ExecuteNonQuery();

                        IsUpdated = ((int)Command.Parameters["ReturnValue"].Value > 0);
                    }
                }
            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog
                    (clsSettings.ApplicationName, e.Message,
                    EventLogEntryType.Error);
            }

            return IsUpdated;
        }

        public static bool DeletePerson(int PersonID)
        {
            bool IsDeleted = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_DeletePerson", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("PersonID", PersonID);

                        SqlParameter OutputParameter = new SqlParameter("ReturnValue", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };

                        Command.Parameters.Add(OutputParameter);

                        Connection.Open();
                        Command.ExecuteNonQuery();

                        IsDeleted = ((int)Command.Parameters["ReturnValue"].Value > 0);
                    }
                }
            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog
                   (clsSettings.ApplicationName, e.Message,
                   EventLogEntryType.Error);
            }

            return IsDeleted;
        }

        public static bool IsPersonExists(int PersonID)
        {
            bool IsExists = false;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_IsPersonExists", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("PersonID", PersonID);



                        Connection.Open();
                        IsExists = (Command.ExecuteScalar() != null);

                    }
                }
            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog
                    (clsSettings.ApplicationName, e.Message,
                    EventLogEntryType.Error);
            }

            return IsExists;
        }


        public static async Task<DataTable> GetPersonsAsync(int NumberOfPersonsEachPage, int NumberOfPage)
        {
            DataTable PersonsData = new DataTable();

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetPersons", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;


                        Command.Parameters.AddWithValue("NumberOfPersonEachPage", NumberOfPersonsEachPage);
                        Command.Parameters.AddWithValue("NumberOfPage", NumberOfPage);
                        await Connection.OpenAsync();
                        using (SqlDataReader Data = await Command.ExecuteReaderAsync())
                        {
                            PersonsData.Load(Data);
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

            return PersonsData;
        }

        public static async Task<DataTable> GetAllPersonIDsAsync()
        {
            DataTable AllIDs = new DataTable();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetAllPersonIDs", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;





                        await Connection.OpenAsync();
                        AllIDs.Load(await Command.ExecuteReaderAsync());

                    }
                }
            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog
                    (clsSettings.ApplicationName, e.Message,
                    EventLogEntryType.Error);
            }

            return AllIDs;
        }


        public static async Task<DataTable> GetAllPhoneNumbersAsync()
        {
            DataTable AllPNs = new DataTable();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetAllPhoneNumbers", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;





                        await Connection.OpenAsync();
                        AllPNs.Load(await Command.ExecuteReaderAsync());

                    }
                }
            }
            catch (Exception e)
            {
                clsEventLogger.WriteEntryToEventLog
                    (clsSettings.ApplicationName, e.Message,
                    EventLogEntryType.Error);
            }

            return AllPNs;
        }

        public static async Task<int> GetPersonsNumberOfPagesAsync(int PersonsEachPage)
        {
            int NumberOfPages = 0;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetPersonsNumberPages", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("PersonsEachPage", PersonsEachPage);


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
    }

}
