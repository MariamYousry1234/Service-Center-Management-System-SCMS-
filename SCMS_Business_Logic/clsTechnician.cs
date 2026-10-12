using SCMS_Data_Access;
using System;
using System.Data;
using System.Threading.Tasks;

namespace SCMS_Business_Logic
{
    public class clsTechnician
    {
        public enum enMode
        {
            AddNew = 1,
            Update = 2
        }

        public enum enSpecialization
        {
            Hardware =1,
            Software =2,
            Networking =3,
            DataRecovery=4,
            PrinterMaintenance=5,
            MotherboardRepair=6, 
            GeneralMaintenance=7
        }

        public enMode Mode = enMode.AddNew;

        public int TechnicianID { get; set; }

        public int EmployeeID { get; set; }

        public clsEmployee EmployeeInfo;
        public enSpecialization Specialization { get; set; }

        public string txtSpecialization
        {
            get
            {
                return _GetTechnicianSpecialization();
                
            }
        }
        public int CreatedByUserID { get; set; }

        public clsUser CreatedByUserInfo;

        public DateTime CreatedDate { get; set; }

        public int? LastUpdatedUserID { get; set; }

        public clsUser? LastUpdatedUserInfo;

        public DateTime? LastUpdatedDate { get; set; }

        public clsTechnician()
        {
            this.LastUpdatedUserID = null;
            this.LastUpdatedUserInfo = null;
            this.LastUpdatedDate = null;

            EmployeeInfo = new clsEmployee();
            Mode = enMode.AddNew;
        }

        private clsTechnician(
            int TechnicianID,
            int EmployeeID,
            enSpecialization Specialization,
            int CreatedByUserID,
            DateTime CreatedDate,
            int? LastUpdatedUserID,
            DateTime? LastUpdatedDate)
        {
            this.TechnicianID = TechnicianID;
            this.EmployeeID = EmployeeID;
            this.Specialization = Specialization;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;
            this.LastUpdatedUserID = LastUpdatedUserID;
            this.LastUpdatedDate = LastUpdatedDate;

            this.EmployeeInfo = clsEmployee.FindEmployee(EmployeeID);
            this.CreatedByUserInfo = clsUser.FindUser(CreatedByUserID);

            if (LastUpdatedUserID.HasValue)
                this.LastUpdatedUserInfo = clsUser.FindUser(LastUpdatedUserID.Value);

            Mode = enMode.Update;
        }

        private bool AddNewTechnician()
        {
            clsEmployee Employee = clsEmployee.FindEmployee(this.EmployeeID);

            if (Employee == null || !Employee.IsActive )
                return false;
            
            int? TechnicianID =
                clsTechnicianDataAccess.AddNewTechnician(
                    this.EmployeeID,
                   (byte) this.Specialization,
                    this.CreatedByUserID);

            if (TechnicianID != null)
            {
                this.TechnicianID = TechnicianID.Value;
                return true;
            }

            return false;
        }

        private bool UpdateTechnician()
        {
            return clsTechnicianDataAccess.UpdateTechnician(
                this.TechnicianID,
                this.EmployeeID,
               (byte) this.Specialization,
                this.LastUpdatedUserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (AddNewTechnician())
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                    return false;

                case enMode.Update:
                    return UpdateTechnician();
            }

            return false;
        }

        private string _GetTechnicianSpecialization()
        {
            switch(Specialization)
            {
                case enSpecialization.Hardware:
                    return "Hardware";

                case enSpecialization.Software:
                    return "Software";

                case enSpecialization.Networking:
                    return "Networking";

                case enSpecialization.PrinterMaintenance:
                    return "Printer Maintenance";


                case enSpecialization.DataRecovery:
                    return "Data Recovery";

                case enSpecialization.GeneralMaintenance:
                    return "General Maintenance";

                case enSpecialization.MotherboardRepair:
                    return "Motherboard Repair";

                default:
                    return "Un Known";
            }
        }
        public static clsTechnician FindTechnician(int TechnicianID)
        {
            int EmployeeID = 0;
            byte Specialization = 0;

            int CreatedByUserID = 0;
            DateTime CreatedDate = DateTime.MinValue;

            int? LastUpdatedUserID = null;
            DateTime? LastUpdatedDate = null;

            if (clsTechnicianDataAccess.FindTechnician(
                TechnicianID,
                ref EmployeeID,
                ref Specialization,
                ref CreatedByUserID,
                ref CreatedDate,
                ref LastUpdatedUserID,
                ref LastUpdatedDate))
            {
                return new clsTechnician(
                    TechnicianID,
                    EmployeeID,
                    (enSpecialization)Specialization,
                    CreatedByUserID,
                    CreatedDate,
                    LastUpdatedUserID,
                    LastUpdatedDate);
            }

            return null;
        }

        public static clsTechnician FindTechnicianByEmployeeID(int EmployeeID)
        {
            int TechnicianID = 0;
            byte Specialization = 0;

            int CreatedByUserID = 0;
            DateTime CreatedDate = DateTime.MinValue;

            int? LastUpdatedUserID = null;
            DateTime? LastUpdatedDate = null;

            if (clsTechnicianDataAccess.FindTechnicianByEmployeeID(
                ref TechnicianID,
                 EmployeeID,
                ref Specialization,
                ref CreatedByUserID,
                ref CreatedDate,
                ref LastUpdatedUserID,
                ref LastUpdatedDate))
            {
                return new clsTechnician(
                    TechnicianID,
                    EmployeeID,
                    (enSpecialization)Specialization,
                    CreatedByUserID,
                    CreatedDate,
                    LastUpdatedUserID,
                    LastUpdatedDate);
            }

            return null;
        }

        public static clsTechnician FindTechnicianByPhoneNumber(string PhoneNumber)
        {
            int TechnicianID = 0,EmployeeID=0;
            byte Specialization = 0;

            int CreatedByUserID = 0;
            DateTime CreatedDate = DateTime.MinValue;

            int? LastUpdatedUserID = null;
            DateTime? LastUpdatedDate = null;

            if (clsTechnicianDataAccess.FindTechnicianByPhoneNumber(
                PhoneNumber,
                ref TechnicianID,
                ref EmployeeID,
                ref Specialization,
                ref CreatedByUserID,
                ref CreatedDate,
                ref LastUpdatedUserID,
                ref LastUpdatedDate))
            {
                return new clsTechnician(
                    TechnicianID,
                    EmployeeID,
                    (enSpecialization)Specialization,
                    CreatedByUserID,
                    CreatedDate,
                    LastUpdatedUserID,
                    LastUpdatedDate);
            }

            return null;
        }
        public static bool DeleteTechnician(int TechnicianID)
        {
            return clsTechnicianDataAccess.DeleteTechnician(TechnicianID);
        }

        public static bool IsTechnicianExists(int TechnicianID)
        {
            return clsTechnicianDataAccess.IsTechnicianExists(TechnicianID);
        }

        public static Task<DataTable> GetTechniciansAsync(
            int NumberOfTechniciansEachPage,
            int NumberOfPage)
        {
            return clsTechnicianDataAccess.GetTechniciansAsync(
                NumberOfTechniciansEachPage,
                NumberOfPage);
        }

        public static Task<int> GetTechniciansNumberOfPagesAsync(
            int TechniciansEachPage)
        {
            return clsTechnicianDataAccess.GetTechniciansNumberOfPagesAsync(
                TechniciansEachPage);
        }

        public static int? GetTechnicianIDByEmployeeID(int EmployeeID)
        {
            return clsTechnicianDataAccess.GetTechnicianIDByEmployeeID(EmployeeID);
        }

        public Task<DataTable> GetAllAssignedRepairOrdersAsync()
        {
            return clsRepairOrder.GetAllAssignedROrdersForTechnicianAsync(this.TechnicianID);
        }

        public Task<DataTable> GetAllCompletedOrdersAsync()
        {
            return clsRepairOrder.GetAllCompletedOrdersForTechnicianAsync(this.TechnicianID);
        }

        public Task<DataTable> GetAllCurrentWorkloadOrdersAsync()
        {
            return clsRepairOrder.GetAllCurrentWorkloadOrdersForTechnicianAsync(this.TechnicianID);
        }
        
    }
}