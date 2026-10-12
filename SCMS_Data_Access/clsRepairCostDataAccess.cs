using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedLib;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace SCMS_Data_Access
{
    public class clsRepairCostDataAccess
    {
            public static int? AddNewRepairCost(
                int RepairOrderID,
                float? AdditionalServices,
                float? TaxAmount,
                float? DiscountAmount,
                int CreatedByUserID,
                ref float TotalRepairCost)
            {
                int? RepairCostID = null;

                try
                {
                    using (SqlConnection Connection =
                        new SqlConnection(clsSettings.ConnectionString))
                    {
                        using (SqlCommand Command =
                            new SqlCommand("SP_AddNewRepairCost", Connection))
                        {
                            Command.CommandType =
                                CommandType.StoredProcedure;

                            Command.Parameters.AddWithValue(
                                "RepairOrderID",
                                RepairOrderID);

                            Command.Parameters.AddWithValue(
                                "AdditionalServices",
                                (object)AdditionalServices ?? DBNull.Value);

                            Command.Parameters.AddWithValue(
                                "TaxAmount",
                                (object)TaxAmount?? DBNull.Value);

                            Command.Parameters.AddWithValue(
                                "DiscountAmount",
                                (object) DiscountAmount ?? DBNull.Value);

                            Command.Parameters.AddWithValue(
                                "CreatedByUserID",
                                CreatedByUserID);


                            SqlParameter RepairCostIDParameter =
                                new SqlParameter(
                                    "RepairCostID",
                                    SqlDbType.Int)
                                {
                                    Direction =
                                        ParameterDirection.Output
                                };

                            Command.Parameters.Add(
                                RepairCostIDParameter);


                        SqlParameter RepairCost =
                            new SqlParameter(
                                "TotalRepairCost",
                                SqlDbType.Money)
                            {
                                Direction =
                                    ParameterDirection.Output
                            };

                        Command.Parameters.Add(
                            RepairCost);

                        Connection.Open();
                         Command.ExecuteNonQuery();

                            RepairCostID =
                              RepairCostIDParameter.Value == DBNull.Value ?
                              null : 
                              (int?)RepairCostIDParameter.Value;

                           TotalRepairCost =
                                 RepairCost.Value == DBNull.Value
                                 ? 0
                                : Convert.ToSingle(RepairCost.Value);
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

                return RepairCostID;
            }


            public static bool FindRepairCost(
                int RepairCostID,
                ref int RepairOrderID,
                ref float PartsCost,
                ref float LaborCost,
                ref float? AdditionalServices,
                ref float? TaxAmount,
                ref float? DiscountAmount,
                ref float TotalRepairCost,
                ref int CreatedByUserID,
                ref DateTime CreatedDate)
            {
                bool IsFound = false;

                try
                {
                    using (SqlConnection Connection =
                        new SqlConnection(clsSettings.ConnectionString))
                    {
                        using (SqlCommand Command =
                            new SqlCommand(
                                "SP_FindRepairCost",
                                Connection))
                        {
                            Command.CommandType =
                                CommandType.StoredProcedure;

                            Command.Parameters.AddWithValue(
                                "RepairCostID",
                                RepairCostID);

                            Connection.Open();

                            using (SqlDataReader Data =
                                Command.ExecuteReader())
                            {
                                if (Data.Read())
                                {
                                    RepairOrderID =
                                        (int)Data["RepairOrderID"];

                                    PartsCost =
                                        Convert.ToSingle(Data["PartsCost"]);

                                    LaborCost =
                                          Convert.ToSingle(Data["LaborCost"]);

                                    AdditionalServices =
                                       Data["AdditionalServices"] ==DBNull.Value ? null:
                                       (float?)Convert.ToSingle(Data["AdditionalServices"]);

                                    TaxAmount =
                                        Data["TaxAmount"] == DBNull.Value ? null :
                                       (float?)Convert.ToSingle(Data["TaxAmount"]);

                                DiscountAmount =
                                      Data["DiscountAmount"] == DBNull.Value ? null:
                                       (float?)Convert.ToSingle(Data["DiscountAmount"]);

                                TotalRepairCost =
                                          Convert.ToSingle(Data["TotalRepairCost"]);

                                    CreatedByUserID =
                                        (int)Data["CreatedByUserID"];

                                    CreatedDate =
                                        (DateTime)Data["CreatedDate"];

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


            public static bool FindRepairCost(
               ref int RepairCostID,
                 int RepairOrderID,
                ref float PartsCost,
                ref float LaborCost,
                ref float? AdditionalServices,
                ref float? TaxAmount,
                ref float? DiscountAmount,
                ref float TotalRepairCost,
                ref int CreatedByUserID,
                ref DateTime CreatedDate)
            {
                bool IsFound = false;

                try
                {
                    using (SqlConnection Connection =
                        new SqlConnection(clsSettings.ConnectionString))
                    {
                        using (SqlCommand Command =
                            new SqlCommand(
                                "SP_FindRepairCostByRepairOrderID",
                                Connection))
                        {
                            Command.CommandType =
                                CommandType.StoredProcedure;

                            Command.Parameters.AddWithValue(
                                "RepairOrderID",
                                RepairOrderID);

                            Connection.Open();

                            using (SqlDataReader Data =
                                Command.ExecuteReader())
                            {
                                if (Data.Read())
                                {
                                    RepairCostID =
                                        (int)Data["RepairCostID"];

                                    PartsCost =
                                        Convert.ToSingle(Data["PartsCost"]);

                                    LaborCost =
                                         Convert.ToSingle(Data["LaborCost"]);

                                AdditionalServices =
                                 Data["AdditionalServices"] == DBNull.Value ? null :
                                (float?)Convert.ToSingle(Data["AdditionalServices"]);

                                TaxAmount =
                                    Data["TaxAmount"] == DBNull.Value ? null :
                                   (float?)Convert.ToSingle(Data["TaxAmount"]);

                                DiscountAmount =
                                      Data["DiscountAmount"] == DBNull.Value ? null :
                                        (float?)Convert.ToSingle(Data["DiscountAmount"]);


                                TotalRepairCost =
                                         Convert.ToSingle(Data["TotalRepairCost"]);

                                    CreatedByUserID =
                                        (int)Data["CreatedByUserID"];

                                    CreatedDate =
                                        (DateTime)Data["CreatedDate"];

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


            public static bool UpdateRepairCost(
                int RepairCostID,
                float? AdditionalServices,
                float? TaxAmount,
                float? DiscountAmount,
                ref float TotalRepairCost)
            {
                bool IsUpdated = false;

                try
                {
                    using (SqlConnection Connection =
                        new SqlConnection(clsSettings.ConnectionString))
                    {
                        using (SqlCommand Command =
                            new SqlCommand(
                                "SP_UpdateRepairCost",
                                Connection))
                        {
                            Command.CommandType =
                                CommandType.StoredProcedure;

                            Command.Parameters.AddWithValue(
                                "RepairCostID",
                                RepairCostID);


                         Command.Parameters.AddWithValue(
                            "AdditionalServices",
                            (object)AdditionalServices ?? DBNull.Value);

                         Command.Parameters.AddWithValue(
                            "TaxAmount",
                            (object)TaxAmount ?? DBNull.Value);

                         Command.Parameters.AddWithValue(
                            "DiscountAmount",
                            (object)DiscountAmount ?? DBNull.Value);


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

                        SqlParameter RepairCost =
                           new SqlParameter(
                               "TotalRepairCost",
                               SqlDbType.Money)
                           {
                               Direction =
                                   ParameterDirection.Output
                           };

                        Command.Parameters.Add(
                            RepairCost);


                        Connection.Open();
                            Command.ExecuteNonQuery();

                            IsUpdated =
                                ((int)Command.Parameters["ReturnValue"].Value > 0);


                        TotalRepairCost =
                              RepairCost.Value == DBNull.Value
                              ? 0
                             : Convert.ToSingle(RepairCost.Value);
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


            public static bool DeleteRepairCost(
                int RepairCostID)
            {
                bool IsDeleted = false;

                try
                {
                    using (SqlConnection Connection =
                        new SqlConnection(clsSettings.ConnectionString))
                    {
                        using (SqlCommand Command =
                            new SqlCommand(
                                "SP_DeleteRepairCost",
                                Connection))
                        {
                            Command.CommandType =
                                CommandType.StoredProcedure;

                            Command.Parameters.AddWithValue(
                                "RepairCostID",
                                RepairCostID);


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


            public static bool IsRepairCostExists(
                int RepairCostID)
            {
                bool IsExists = false;

                try
                {
                    using (SqlConnection Connection =
                        new SqlConnection(clsSettings.ConnectionString))
                    {
                        using (SqlCommand Command =
                            new SqlCommand(
                                "SP_IsRepairCostExists",
                                Connection))
                        {
                            Command.CommandType =
                                CommandType.StoredProcedure;

                            Command.Parameters.AddWithValue(
                                "RepairCostID",
                                RepairCostID);

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


            public static bool IsRepairCostExistsByRepairOrderID(
                int RepairOrderID)
            {
                bool IsExists = false;

                try
                {
                    using (SqlConnection Connection =
                        new SqlConnection(clsSettings.ConnectionString))
                    {
                        using (SqlCommand Command =
                            new SqlCommand(
                                "SP_IsRepairCostExistsByRepairOrderID",
                                Connection))
                        {
                            Command.CommandType =
                                CommandType.StoredProcedure;

                            Command.Parameters.AddWithValue(
                                "RepairOrderID",
                                RepairOrderID);

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


            public static async Task<DataTable> GetRepairCostsAsync()
            {
                DataTable RepairCostsData =
                    new DataTable();

                try
                {
                    using (SqlConnection Connection =
                        new SqlConnection(clsSettings.ConnectionString))
                    {
                        using (SqlCommand Command =
                            new SqlCommand(
                                "SP_GetRepairCosts",
                                Connection))
                        {
                            Command.CommandType =
                                CommandType.StoredProcedure;

                            await Connection.OpenAsync();

                            using (SqlDataReader Data =
                                await Command.ExecuteReaderAsync())
                            {
                                RepairCostsData.Load(Data);
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

                return RepairCostsData;
            }


            public static async Task<int> GetRepairCostsNumberOfPagesAsync(
                int RepairCostsEachPage)
            {
                int NumberOfPages = 0;

                try
                {
                    using (SqlConnection Connection =
                        new SqlConnection(clsSettings.ConnectionString))
                    {
                        using (SqlCommand Command =
                            new SqlCommand(
                                "SP_GetRepairCostsNumberPages",
                                Connection))
                        {
                            Command.CommandType =
                                CommandType.StoredProcedure;

                            Command.Parameters.AddWithValue(
                                "RepairCostsEachPage",
                                RepairCostsEachPage);


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
