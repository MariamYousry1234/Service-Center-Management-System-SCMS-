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
    public class clsPartBrandDataAccess
    {
        public static int? AddNewPartBrand(
           string PartBrandName)
        {
            int? PartBrandID = null;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_AddNewPartBrand", Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "PartBrandName",
                            PartBrandName);

                        SqlParameter PartBrandIDParameter =
                            new SqlParameter(
                                "PartBrandID",
                                SqlDbType.Int)
                            {
                                Direction =
                                    ParameterDirection.Output
                            };

                        Command.Parameters.Add(
                            PartBrandIDParameter);

                        Connection.Open();
                        Command.ExecuteNonQuery();

                        PartBrandID =
                            (int)Command.Parameters["PartBrandID"].Value;
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

            return PartBrandID;
        }
       
        public static bool FindPartBrand(
            int PartBrandID,
            ref string PartBrandName)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_FindPartBrand",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "PartBrandID",
                            PartBrandID);

                        Connection.Open();

                        using (SqlDataReader Data =
                            Command.ExecuteReader())
                        {
                            if (Data.Read())
                            {
                                PartBrandName =
                                    (string)Data["PartBrandName"];

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

        public static bool FindPartBrand(
          ref int PartBrandID,
          string PartBrandName)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_FindPartBrandByName",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "PartBrandName",
                            PartBrandName);

                        Connection.Open();

                        using (SqlDataReader Data =
                            Command.ExecuteReader())
                        {
                            if (Data.Read())
                            {
                                PartBrandID =
                                    (int)Data["PartBrandID"];

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

        public static bool UpdatePartBrand(
            int PartBrandID,
            string PartBrandName)
        {
            bool IsUpdated = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_UpdatePartBrand",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "PartBrandID",
                            PartBrandID);

                        Command.Parameters.AddWithValue(
                            "PartBrandName",
                            PartBrandName);

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
        
        public static bool DeletePartBrand(
            int PartBrandID)
        {
            bool IsDeleted = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_DeletePartBrand",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "PartBrandID",
                            PartBrandID);

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
        
        public static bool IsPartBrandExists(
            int PartBrandID)
        {
            bool IsExists = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_IsPartBrandExists",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "PartBrandID",
                            PartBrandID);

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
       
        public static async Task<DataTable> GetPartBrandsAsync()
        {
            DataTable PartBrandsData = new DataTable();

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_GetPartBrands",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

               
                        await Connection.OpenAsync();

                        using (SqlDataReader Data =
                            await Command.ExecuteReaderAsync())
                        {
                            PartBrandsData.Load(Data);
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

            return PartBrandsData;
        }
        
        public static async Task<int> GetPartBrandsNumberOfPagesAsync(
            int PartBrandsEachPage)
        {
            int NumberOfPages = 0;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_GetPartBrandsNumberPages",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "PartBrandsEachPage",
                            PartBrandsEachPage);

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


        public static int? GetPartBrandIDByName(string PartBrandName)
        {
            int? BrandID = null;
            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_GetPartBrandIDByName",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                         "PartBrandName",
                             PartBrandName);

                     
                        Connection.Open();

                        object Result = Command.ExecuteScalar();
                        BrandID = Result == null ? null :
                           (int?)Result;


              
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
            return BrandID;
        }
    }
}
