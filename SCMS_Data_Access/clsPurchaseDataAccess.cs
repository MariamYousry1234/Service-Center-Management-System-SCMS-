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
    public class clsPurchaseDataAccess
    {
        public static int? AddNewPurchase(
            int PartID,
            DateTime PurchaseDate,
            int Quantity,
            float PurchasePrice,
            int SupplierID,
            int CreatedByUserID)
        {
            int? PurchaseID = null;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_AddNewPurchase",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "PartID",
                            PartID);

                        Command.Parameters.AddWithValue(
                            "PurchaseDate",
                            PurchaseDate);

                        Command.Parameters.AddWithValue(
                            "Quantity",
                            Quantity);

                        Command.Parameters.AddWithValue(
                            "PurchasePrice",
                            PurchasePrice);

                        Command.Parameters.AddWithValue(
                            "SupplierID",
                            SupplierID);

                        Command.Parameters.AddWithValue(
                            "CreatedByUserID",
                            CreatedByUserID);

                        SqlParameter PurchaseIDParameter =
                            new SqlParameter(
                                "PurchaseID",
                                SqlDbType.Int)
                            {
                                Direction =
                                    ParameterDirection.Output
                            };

                        Command.Parameters.Add(
                            PurchaseIDParameter);

                        Connection.Open();
                        Command.ExecuteNonQuery();

                        PurchaseID =
                            (int)Command.Parameters["PurchaseID"].Value;
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

            return PurchaseID;
        }

       
        public static bool FindPurchase(
            int PurchaseID,
            ref int PartID,
            ref DateTime PurchaseDate,
            ref int Quantity,
            ref float PurchasePrice,
            ref int SupplierID,
            ref float TotalPrice,
            ref int CreatedByUserID,
            ref DateTime? LastUpdatedDate,
            ref int? LastUpdatedUserID,
            ref bool IsCancelled)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_FindPurchase",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "PurchaseID",
                            PurchaseID);

                        Connection.Open();

                        using (SqlDataReader Data =
                            Command.ExecuteReader())
                        {
                            if (Data.Read())
                            {
                                PartID =
                                    (int)Data["PartID"];

                                PurchaseDate =
                                    (DateTime)Data["PurchaseDate"];

                                Quantity =
                                    (int)Data["Quantity"];

                                PurchasePrice =
                                    Convert.ToSingle(
                                        Data["PurchasePrice"]);

                                SupplierID =
                                    (int)Data["SupplierID"];

                                TotalPrice =
                                    Convert.ToSingle(
                                        Data["TotalPrice"]);

                                CreatedByUserID =
                                    (int)Data["CreatedByUserID"];

                                LastUpdatedDate =
                                    Data["LastUpdatedDate"] == DBNull.Value
                                    ? null
                                    : (DateTime?)Data["LastUpdatedDate"];

                                LastUpdatedUserID =
                                    Data["LastUpdatedUserID"] == DBNull.Value
                                    ? null
                                    : (int?)Data["LastUpdatedUserID"];

                                IsCancelled = (bool)Data["IsCancelled"];
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

        public static bool UpdatePurchase(
            int PurchaseID,
            int PartID,
            DateTime PurchaseDate,
            int Quantity,
            float PurchasePrice,
            int SupplierID,
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
                        new SqlCommand(
                            "SP_UpdatePurchase",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "PurchaseID",
                            PurchaseID);

                        Command.Parameters.AddWithValue(
                            "PartID",
                            PartID);

                        Command.Parameters.AddWithValue(
                            "PurchaseDate",
                            PurchaseDate);

                        Command.Parameters.AddWithValue(
                            "Quantity",
                            Quantity);

                        Command.Parameters.AddWithValue(
                            "PurchasePrice",
                            PurchasePrice);

                        Command.Parameters.AddWithValue(
                            "SupplierID",
                            SupplierID);

                        Command.Parameters.AddWithValue(
                            "LastUpdatedUserID",
                            (object)LastUpdatedUserID ??
                            DBNull.Value);

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

        public static bool DeletePurchase(
            int PurchaseID)
        {
            bool IsDeleted = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_DeletePurchase",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "PurchaseID",
                            PurchaseID);

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

        public static bool IsPurchaseExists(
            int PurchaseID)
        {
            bool IsExists = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_IsPurchaseExists",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "PurchaseID",
                            PurchaseID);

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

        public static async Task<DataTable> GetPurchasesAsync(
            int NumberOfPurchasesEachPage,
            int NumberOfPage)
        {
            DataTable PurchasesData = new DataTable();

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_GetPurchases",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "NumberOfPurchasesEachPage",
                            NumberOfPurchasesEachPage);

                        Command.Parameters.AddWithValue(
                            "NumberOfPage",
                            NumberOfPage);

                        await Connection.OpenAsync();

                        using (SqlDataReader Data =
                            await Command.ExecuteReaderAsync())
                        {
                            PurchasesData.Load(Data);
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

            return PurchasesData;
        }

        public static async Task<int> GetPurchasesNumberOfPagesAsync(
            int PurchasesEachPage)
        {
            int NumberOfPages = 0;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_GetPurchasesNumberPages",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "PurchasesEachPage",
                            PurchasesEachPage);

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

        public static bool CancelPurchase(int PurchaseID,int CancelledByUserID)
        {
            bool IsCancelled = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_CancelPurchase",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "PurchaseID",
                            PurchaseID);

                        Command.Parameters.AddWithValue(
                            "CancelledByUserID",
                            CancelledByUserID);



                        Connection.Open();

                       IsCancelled = Command.ExecuteNonQuery()>0;

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

            return IsCancelled;
        }

        public static async Task<DataTable> GetAllPurchaseOperationsForPartAsync(int PartID)
        {
            DataTable AllOperations = new DataTable();

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_GetPuchaseTrackingForPart",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "PartID",
                            PartID);


                        await Connection.OpenAsync();

                        using (SqlDataReader Data = await Command.ExecuteReaderAsync())
                        {
                            AllOperations.Load(Data);
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

            return AllOperations;
        }
    }
}
