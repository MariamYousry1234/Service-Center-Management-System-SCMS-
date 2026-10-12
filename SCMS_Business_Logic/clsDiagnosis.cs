using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCMS_Data_Access;

namespace SCMS_Business_Logic
{
    public  class clsDiagnosis
    {
      
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;

        public enum enStatus { Approval=1,Rejected=2}
        
        public int DiagnosisID { set; get; }

        public int RepairOrderID { set; get; }

       // public clsRepairOrder RepairOrderInfo;

        public string DetectedProblems { set; get; }

        public string? RequireParts { set; get; }

        public float LaborCost { set; get; }

        public DateTime EstimatedCompletionDate { set; get; }

        public string? TechnicianNotes { set; get; }

        public float EstimatedCost { set; get; }

        public DateTime CreatedDate { get; private set; }

        public enStatus? Status { get; private set; }

        public DateTime? ApprovalDate { get; private set; }

        public int CreatedByUserID { set; get; }

        public clsUser CreatedUserInfo;


        public clsDiagnosis()
        {
            DiagnosisID = -1;
            RepairOrderID = -1;
            DetectedProblems = "";
            RequireParts = "";
            LaborCost = 0;
            EstimatedCompletionDate = DateTime.Now;
            TechnicianNotes = null;
            EstimatedCost = 0;
            Status = null;
            ApprovalDate = null;
            CreatedByUserID = -1;

            //RepairOrderInfo = null;
            CreatedUserInfo = null;

            Mode = enMode.AddNew;
        }

        private clsDiagnosis(
            int DiagnosisID,
            int RepairOrderID,
            string DetectedProblems,
            string? RequireParts,
            float LaborCost,
            DateTime EstimatedCompletionDate,
            string? TechnicianNotes,
            float EstimatedCost,
            DateTime CreatedDate,
            enStatus? Status,
            DateTime? ApprovalDate,
            int CreatedByUserID
           )
        {
            this.DiagnosisID = DiagnosisID;
            this.RepairOrderID = RepairOrderID;
            this.DetectedProblems = DetectedProblems;
            this.RequireParts = RequireParts;
            this.LaborCost = LaborCost;
            this.EstimatedCompletionDate = EstimatedCompletionDate;
            this.TechnicianNotes = TechnicianNotes;
            this.EstimatedCost = EstimatedCost;
            this.CreatedDate = CreatedDate;
            this.Status = Status;
            this.ApprovalDate = ApprovalDate;
            this.CreatedByUserID = CreatedByUserID;

            CreatedUserInfo = 
                clsUser.FindUser(CreatedByUserID);
           
           // RepairOrderInfo =
               // clsRepairOrder.Find(RepairOrderID);

            Mode = enMode.Update;
        }

        private bool AddNewDiagnosis()
        {
            int? DiagnosisID =
                clsDiagnosisDataAccess.AddNewDiagnosis(
                    this.RepairOrderID,
                    this.DetectedProblems,
                    this.RequireParts,
                    this.LaborCost,
                    this.EstimatedCompletionDate,
                    this.TechnicianNotes,
                    this.EstimatedCost,
                    this.CreatedByUserID);

            if (DiagnosisID != null)
            {
                this.DiagnosisID = DiagnosisID.Value;
                return true;
            }

            return false;
        }

        private bool UpdateDiagnosis()
        {
            return clsDiagnosisDataAccess.UpdateDiagnosis(
                this.DiagnosisID,
                this.RepairOrderID,
                this.DetectedProblems,
                this.RequireParts,
                this.LaborCost,
                this.EstimatedCompletionDate,
                this.TechnicianNotes,
                this.EstimatedCost);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (AddNewDiagnosis())
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                    return false;

                case enMode.Update:

                    return UpdateDiagnosis();
            }

            return false;
        }

        public static clsDiagnosis FindDiagnosis(int DiagnosisID)
        {
            int RepairOrderID = -1;
            string DetectedProblems = "";
            string? RequireParts = "";
            float LaborCost = 0;
            DateTime EstimatedCompletionDate = DateTime.Now;
            string? TechnicianNotes = null;
            float EstimatedCost = 0;
            DateTime CreatedDate = DateTime.Now;
            byte? Status = null;
            DateTime? ApprovalDate = null;
            int CreatedByUserID = -1;


            if (clsDiagnosisDataAccess.FindDiagnosis(
                DiagnosisID,
                ref RepairOrderID,
                ref DetectedProblems,
                ref RequireParts,
                ref LaborCost,
                ref EstimatedCompletionDate,
                ref TechnicianNotes,
                ref EstimatedCost,
                ref CreatedDate,
                ref Status,
                ref ApprovalDate,
                ref CreatedByUserID
              ))
            {
                return new clsDiagnosis(
                    DiagnosisID,
                    RepairOrderID,
                    DetectedProblems,
                    RequireParts,
                    LaborCost,
                    EstimatedCompletionDate,
                    TechnicianNotes,
                    EstimatedCost,
                    CreatedDate,
                    (enStatus?) Status,
                    ApprovalDate,
                    CreatedByUserID
                   );
            }

            return null;
        }

        public static clsDiagnosis FindDiagnosisByRepairOrder(int RepairOrderID)
        {
            int DiagnosisID = -1;
            string DetectedProblems = "";
            string? RequireParts = "";
            float LaborCost = 0;
            DateTime EstimatedCompletionDate = DateTime.Now;
            string? TechnicianNotes = null;
            float EstimatedCost = 0;
            DateTime CreatedDate = DateTime.Now;
            byte? Status = null;
            DateTime? ApprovalDate = null;
            int CreatedByUserID = -1;

            if (clsDiagnosisDataAccess.FindDiagnosis(
               ref DiagnosisID,
                 RepairOrderID,
                ref DetectedProblems,
                ref RequireParts,
                ref LaborCost,
                ref EstimatedCompletionDate,
                ref TechnicianNotes,
                ref EstimatedCost,
                ref CreatedDate,
                ref Status,
                ref ApprovalDate,
                ref CreatedByUserID
              ))
            {
                return new clsDiagnosis(
                    DiagnosisID,
                    RepairOrderID,
                    DetectedProblems,
                    RequireParts,
                    LaborCost,
                    EstimatedCompletionDate,
                    TechnicianNotes,
                    EstimatedCost,
                    CreatedDate,
                    (enStatus?)Status,
                    ApprovalDate,
                    CreatedByUserID
                   );
            }

            return null;
        }
        public static bool DeleteDiagnosis(int DiagnosisID)
        {
            return clsDiagnosisDataAccess.DeleteDiagnosis(DiagnosisID);
        }

        public static bool IsDiagnosisExists(int DiagnosisID)
        {
            return clsDiagnosisDataAccess.IsDiagnosisExists(DiagnosisID);
        }

        public static Task<DataTable> GetDiagnosesAsync(
            int NumberOfDiagnosesEachPage,
            int NumberOfPage)
        {
            return clsDiagnosisDataAccess.GetDiagnosesAsync(
                NumberOfDiagnosesEachPage,
                NumberOfPage);
        }

        public static Task<int> GetDiagnosesNumberOfPagesAsync(
            int DiagnosesEachPage)
        {
            return clsDiagnosisDataAccess.GetDiagnosesNumberOfPagesAsync(
                DiagnosesEachPage);
        }


        public bool UpdateStatus(enStatus Status,DateTime? ApprovalDate,int ChangedByUserID)
        {
            if( clsDiagnosisDataAccess.UpdateDiagnosisStatus(this.DiagnosisID,
                (byte)Status, ApprovalDate,ChangedByUserID))
            {
                this.Status = Status;
                this.ApprovalDate = ApprovalDate;

                return true;
            }

            return false;
        }
    }
}
