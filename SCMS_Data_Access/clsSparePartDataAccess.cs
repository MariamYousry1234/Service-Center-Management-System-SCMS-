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
    public class clsSparePartDataAccess
    {

        public static int? AddNewSparePart(
                 string PartName,
                 float SellingPrice,
                 int Quantity,
                 byte MinimumStockLevel,
                 int PartCategoryID,
                 int PartBrandID,
                 int CreatedByUserID)
        {
            int? PartID = null;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("SP_AddNewSparePart", Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "PartName",
                            PartName);

                        Command.Parameters.AddWithValue(
                            "SellingPrice",
                            SellingPrice);

                        Command.Parameters.AddWithValue(
                            "Quantity",
                            Quantity);

                        Command.Parameters.AddWithValue(
                            "MinimumStockLevel",
                            MinimumStockLevel);

                    
                        Command.Parameters.AddWithValue(
                            "PartCategoryID",
                            PartCategoryID);

                        Command.Parameters.AddWithValue(
                            "PartBrandID",
                            PartBrandID);

                        Command.Parameters.AddWithValue(
                            "CreatedByUserID",
                            CreatedByUserID);

                        SqlParameter PartIDParameter =
                            new SqlParameter(
                                "PartID",
                                SqlDbType.Int)
                            {
                                Direction =
                                    ParameterDirection.Output
                            };

                        Command.Parameters.Add(
                            PartIDParameter);

                        Connection.Open();
                        Command.ExecuteNonQuery();

                        PartID =
                            (int)Command.Parameters["PartID"].Value;
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

            return PartID;
        }

        public static bool FindSparePart(
            int PartID,
            ref string PartName,
            ref float SellingPrice,
            ref int Quantity,
            ref byte MinimumStockLevel,
            ref bool IsActive,
            ref int PartCategoryID,
            ref int PartBrandID,
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
                            "SP_FindSparePart",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "PartID",
                            PartID);

                        Connection.Open();

                        using (SqlDataReader Data =
                            Command.ExecuteReader())
                        {
                            if (Data.Read())
                            {
                                PartName =
                                    (string)Data["PartName"];

                                SellingPrice =
                                    Convert.ToSingle(Data["SellingPrice"]);

                                Quantity =
                                    (int)Data["Quantity"];

                                MinimumStockLevel =
                                    (byte)Data["MinimumStockLevel"];

                                IsActive =
                                    (bool)Data["IsActive"];

                                PartCategoryID =
                                    (int)Data["PartCategoryID"];

                                PartBrandID =
                                    (int)Data["PartBrandID"];

                                CreatedByUserID =
                                    (int)Data["CreatedByUserID"];

                                CreatedDate =
                                    (DateTime)Data["CreatedDate"];

                                LastUpdatedUserID =
                                    Data["LastUpdatedUserID"] == DBNull.Value
                                    ? (int?)null
                                    : (int)Data["LastUpdatedUserID"];

                                LastUpdatedDate =
                                    Data["LastUpdatedDate"] == DBNull.Value
                                    ? (DateTime?)null
                                    : (DateTime)Data["LastUpdatedDate"];

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
        public static bool FindSparePart(
         ref int PartID,
          string PartName,
         ref float SellingPrice,
         ref int Quantity,
         ref byte MinimumStockLevel,
         ref bool IsActive,
         ref int PartCategoryID,
         ref int PartBrandID,
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
                            "SP_FindSparePartByName",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "PartName",
                            PartName);

                        Connection.Open();

                        using (SqlDataReader Data =
                            Command.ExecuteReader())
                        {
                            if (Data.Read())
                            {
                                PartID =
                                    (int)Data["PartID"];

                                SellingPrice =
                                    Convert.ToSingle(Data["SellingPrice"]);

                                Quantity =
                                    (int)Data["Quantity"];

                                MinimumStockLevel =
                                    (byte)Data["MinimumStockLevel"];

                                IsActive =
                                    (bool)Data["IsActive"];

                                PartCategoryID =
                                    (int)Data["PartCategoryID"];

                                PartBrandID =
                                    (int)Data["PartBrandID"];

                                CreatedByUserID =
                                    (int)Data["CreatedByUserID"];

                                CreatedDate =
                                    (DateTime)Data["CreatedDate"];

                                LastUpdatedUserID =
                                    Data["LastUpdatedUserID"] == DBNull.Value
                                    ? (int?)null
                                    : (int)Data["LastUpdatedUserID"];

                                LastUpdatedDate =
                                    Data["LastUpdatedDate"] == DBNull.Value
                                    ? (DateTime?)null
                                    : (DateTime)Data["LastUpdatedDate"];

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


        public static bool UpdateSparePart(
            int PartID,
            string PartName,
            float SellingPrice,
            int Quantity,
            byte MinimumStockLevel,
            int PartCategoryID,
            int PartBrandID,
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
                            "SP_UpdateSparePart",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "PartID",
                            PartID);

                        Command.Parameters.AddWithValue(
                            "PartName",
                            PartName);

                        Command.Parameters.AddWithValue(
                            "SellingPrice",
                            SellingPrice);



                        Command.Parameters.AddWithValue(
                            "Quantity",
                            Quantity);

                        Command.Parameters.AddWithValue(
                            "MinimumStockLevel",
                            MinimumStockLevel);

                

                        Command.Parameters.AddWithValue(
                            "PartCategoryID",
                            PartCategoryID);

                        Command.Parameters.AddWithValue(
                            "PartBrandID",
                            PartBrandID);

                        Command.Parameters.AddWithValue(
                            "LastUpdatedUserID",
                            (object)LastUpdatedUserID ?? DBNull.Value);

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

        public static bool DeleteSparePart(
            int PartID)
        {
            bool IsDeleted = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_DeleteSparePart",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "PartID",
                            PartID);

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

        public static bool IsSparePartExists(
            int PartID)
        {
            bool IsExists = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_IsSparePartExists",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "PartID",
                            PartID);

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

        public static bool IsSparePartExists(
          string PartName)
        {
            bool IsExists = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_IsSparePartExistsByPartName",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "PartName",
                            PartName);

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
        public static bool DeactivateSparePart(
            int PartID)
        {
            bool IsDeactivated = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_DeactivateSparePart",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "PartID",
                            PartID);

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

                        IsDeactivated =
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

            return IsDeactivated;
        }

        public static bool ActivateSparePart(
            int PartID)
        {
            bool IsActivated = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_ActivateSparePart",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "PartID",
                            PartID);

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

                        IsActivated =
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

            return IsActivated;
        }

        public static async Task<DataTable> GetSparePartsAsync(
            int NumberOfSparePartsEachPage,
            int NumberOfPage)
        {
            DataTable SparePartsData = new DataTable();

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_GetSpareParts",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "NumberOfSparePartsEachPage",
                            NumberOfSparePartsEachPage);

                        Command.Parameters.AddWithValue(
                            "NumberOfPage",
                            NumberOfPage);

                        await Connection.OpenAsync();

                        using (SqlDataReader Data =
                            await Command.ExecuteReaderAsync())
                        {
                            SparePartsData.Load(Data);
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

            return SparePartsData;
        }

        public static async Task<int> GetSparePartsNumberOfPagesAsync(
            int SparePartsEachPage)
        {
            int NumberOfPages = 0;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_GetSparePartsNumberPages",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "SparePartsEachPage",
                            SparePartsEachPage);

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

        public static bool IsSparePartHasPreviousPuchases(int SparePartID)
        {
            bool HasPreviousPuchases = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_IsSparePartHasPreviousPuchases",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "SparePartID",
                             SparePartID);

                        SqlParameter ReturnValue =
                            new SqlParameter(
                                "ReturnValue",
                                SqlDbType.Int)
                            {
                                Direction =
                                    ParameterDirection.ReturnValue
                            };

                        Command.Parameters.Add(
                            ReturnValue);


                        Connection.Open();

                        Command.ExecuteNonQuery();

                        HasPreviousPuchases = ((int)ReturnValue.Value == 1);
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


            return HasPreviousPuchases;
        }
    }
}
