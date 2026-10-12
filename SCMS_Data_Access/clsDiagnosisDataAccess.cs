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
    public  class clsDiagnosisDataAccess
    {
        public static int? AddNewDiagnosis(
         int RepairOrderID,
         string DetectedProblems,
         string? RequireParts,
         float LaborCost,
         DateTime EstimatedCompletionDate,
         string? TechnicianNotes,
         float EstimatedCost,
         int CreatedByUserID)
        {
            int? DiagnosisID = null;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_AddNewDiagnosis",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "RepairOrderID",
                            RepairOrderID);

                        Command.Parameters.AddWithValue(
                            "DetectedProblems",
                            DetectedProblems);

                        Command.Parameters.AddWithValue(
                            "RequireParts",
                            (object)RequireParts ??
                            DBNull.Value);

                        Command.Parameters.AddWithValue(
                            "LaborCost",
                            LaborCost);

                        Command.Parameters.AddWithValue(
                            "EstimatedCompletionDate",
                            EstimatedCompletionDate);

                        Command.Parameters.AddWithValue(
                            "TechnicianNotes",
                            (object)TechnicianNotes ??
                            DBNull.Value);

                        Command.Parameters.AddWithValue(
                            "EstimatedCost",
                            EstimatedCost);

                        Command.Parameters.AddWithValue(
                         "CreatedByUserID",
                         CreatedByUserID);

                        SqlParameter DiagnosisIDParameter =
                            new SqlParameter(
                                "DiagnosisID",
                                SqlDbType.Int)
                            {
                                Direction =
                                    ParameterDirection.Output
                            };

                        Command.Parameters.Add(
                            DiagnosisIDParameter);

                        Connection.Open();
                        Command.ExecuteNonQuery();



                        DiagnosisID = DiagnosisIDParameter.Value != DBNull.Value
                            ? (int?)DiagnosisIDParameter.Value
                                : null;
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

            return DiagnosisID;
        }

        public static bool FindDiagnosis(
            int DiagnosisID,
            ref int RepairOrderID,
            ref string DetectedProblems,
            ref string? RequireParts,
            ref float LaborCost,
            ref DateTime EstimatedCompletionDate,
            ref string? TechnicianNotes,
            ref float EstimatedCost,
            ref DateTime CreatedDate,
            ref byte? Status,
            ref DateTime? ApprovalDate,
            ref int CreatedByUserID
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
                            "SP_FindDiagnosis",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "DiagnosisID",
                            DiagnosisID);

                        Connection.Open();

                        using (SqlDataReader Data =
                            Command.ExecuteReader())
                        {
                            if (Data.Read())
                            {
                                RepairOrderID =
                                    (int)Data["RepairOrderID"];

                                DetectedProblems =
                                    (string)Data["DetectedProblems"];

                                RequireParts = Data["RequireParts"] ==
                                    DBNull.Value
                                    ? null
                                    : (string)Data["RequireParts"];


                                LaborCost =
                                    Convert.ToSingle(
                                        Data["LaborCost"]);

                                EstimatedCompletionDate =
                                    (DateTime)
                                    Data["EstimatedCompletionDate"];

                                TechnicianNotes =
                                    Data["TechnicianNotes"] ==
                                    DBNull.Value
                                    ? null
                                    : (string)Data["TechnicianNotes"];

                                EstimatedCost =
                                    Convert.ToSingle(
                                        Data["EstimatedCost"]);

                                CreatedDate =
                                    (DateTime)Data["CreatedDate"];

                                Status = Data["Status"] ==
                                    DBNull.Value
                                    ? null
                                    : (byte?)Data["Status"];


                                ApprovalDate = Data["ApprovalDate"] ==
                                    DBNull.Value
                                    ? null
                                    : (DateTime?)Data["ApprovalDate"];

                                CreatedByUserID =
                                   (int)Data["CreatedByUserID"];

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


        public static bool FindDiagnosis(
           ref int DiagnosisID,
             int RepairOrderID,
           ref string DetectedProblems,
           ref string? RequireParts,
           ref float LaborCost,
           ref DateTime EstimatedCompletionDate,
           ref string? TechnicianNotes,
           ref float EstimatedCost,
           ref DateTime CreatedDate,
           ref byte? Status,
            ref DateTime? ApprovalDate,
           ref int CreatedByUserID
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
                            "SP_FindDiagnosisByRepairOrderID",
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
                                DiagnosisID =
                                    (int)Data["DiagnosisID"];

                                DetectedProblems =
                                    (string)Data["DetectedProblems"];

                                RequireParts = Data["RequireParts"] ==
                                    DBNull.Value
                                    ? null
                                    : (string)Data["RequireParts"];
                              

                                LaborCost =
                                    Convert.ToSingle(
                                        Data["LaborCost"]);

                                EstimatedCompletionDate =
                                    (DateTime)
                                    Data["EstimatedCompletionDate"];

                                TechnicianNotes =
                                    Data["TechnicianNotes"] ==
                                    DBNull.Value
                                    ? null
                                    : (string)Data["TechnicianNotes"];

                                EstimatedCost =
                                    Convert.ToSingle(
                                        Data["EstimatedCost"]);

                                CreatedDate =
                                    (DateTime)Data["CreatedDate"];


                                Status = Data["Status"] ==
                                    DBNull.Value
                                    ? null
                                    : (byte?)Data["Status"];


                                ApprovalDate = Data["ApprovalDate"] ==
                                    DBNull.Value
                                    ? null
                                    : (DateTime?)Data["ApprovalDate"];


                                CreatedByUserID =
                                   (int)Data["CreatedByUserID"];


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


        public static bool UpdateDiagnosis(
            int DiagnosisID,
            int RepairOrderID,
            string DetectedProblems,
            string? RequireParts,
            float LaborCost,
            DateTime EstimatedCompletionDate,
            string? TechnicianNotes,
            float EstimatedCost)
        {
            bool IsUpdated = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_UpdateDiagnosis",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "DiagnosisID",
                            DiagnosisID);

                        Command.Parameters.AddWithValue(
                            "RepairOrderID",
                            RepairOrderID);

                        Command.Parameters.AddWithValue(
                            "DetectedProblems",
                            DetectedProblems);

                        Command.Parameters.AddWithValue(
                             "RequireParts",
                             (object)RequireParts ??
                             DBNull.Value);


                        Command.Parameters.AddWithValue(
                            "LaborCost",
                            LaborCost);

                        Command.Parameters.AddWithValue(
                            "EstimatedCompletionDate",
                            EstimatedCompletionDate);

                        Command.Parameters.AddWithValue(
                            "TechnicianNotes",
                            (object)TechnicianNotes ??
                            DBNull.Value);

                        Command.Parameters.AddWithValue(
                            "EstimatedCost",
                            EstimatedCost);

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

        public static bool DeleteDiagnosis(
            int DiagnosisID)
        {
            bool IsDeleted = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_DeleteDiagnosis",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "DiagnosisID",
                            DiagnosisID);

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

        public static bool IsDiagnosisExists(
            int DiagnosisID)
        {
            bool IsExists = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_IsDiagnosisExists",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "DiagnosisID",
                            DiagnosisID);

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

        public static async Task<DataTable> GetDiagnosesAsync(
            int NumberOfDiagnosesEachPage,
            int NumberOfPage)
        {
            DataTable DiagnosesData = new DataTable();

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_GetDiagnoses",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "NumberOfDiagnosesEachPage",
                            NumberOfDiagnosesEachPage);

                        Command.Parameters.AddWithValue(
                            "NumberOfPage",
                            NumberOfPage);

                        await Connection.OpenAsync();

                        using (SqlDataReader Data =
                            await Command.ExecuteReaderAsync())
                        {
                            DiagnosesData.Load(Data);
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

            return DiagnosesData;
        }

        public static async Task<int> GetDiagnosesNumberOfPagesAsync(
            int DiagnosesEachPage)
        {
            int NumberOfPages = 0;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_GetDiagnosesNumberPages",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "DiagnosesEachPage",
                            DiagnosesEachPage);

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

        public static bool UpdateDiagnosisStatus(int DiagnosisID,
            byte Status,DateTime? ApprovalDate,int ChangedByUserID)
        {
            bool IsUpdated = false;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand(
                            "SP_UpdateDiagnosisStatus",
                            Connection))
                    {
                        Command.CommandType =
                            CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue(
                            "DiagnosisID",
                            DiagnosisID);

                        Command.Parameters.AddWithValue(
                            "Status",
                            Status);

                        Command.Parameters.AddWithValue(
                         "CreatedByUserID",
                         ChangedByUserID);

                        Command.Parameters.AddWithValue(
                            "ApprovalDate",
                           (object)ApprovalDate ?? DBNull.Value);




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

                        IsUpdated =(int)ReturnValue.Value >0;
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
