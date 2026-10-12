using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCMS_Data_Access;

namespace SCMS_Business_Logic
{
    public class clsDeviceType
    {
        public enum enMode { AddNew = 1, Update = 2 }

        public enMode Mode = enMode.AddNew;

        public int DeviceTypeID { set; get; }

        public string DeviceTypeName { set; get; }


        public clsDeviceType()
        {
            this.DeviceTypeName = "";
            this.Mode = enMode.AddNew;
        }


        private clsDeviceType(int DeviceTypeID, string DeviceTypeName)
        {
            this.DeviceTypeID = DeviceTypeID;
            this.DeviceTypeName = DeviceTypeName;

            this.Mode = enMode.Update;
        }


        private bool AddNewDeviceType()
        {
            int? DeviceTypeID = clsDeviceTypeDataAccess.AddNewDeviceType(
                this.DeviceTypeName);

            if (DeviceTypeID != null)
            {
                this.DeviceTypeID = (int)DeviceTypeID;
                return true;
            }

            return false;
        }


        private bool UpdateDeviceType()
        {
            return clsDeviceTypeDataAccess.UpdateDeviceType(
                this.DeviceTypeID,
                this.DeviceTypeName);
        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        if (AddNewDeviceType())
                        {
                            Mode = enMode.Update;
                            return true;
                        }

                        return false;
                    }

                case enMode.Update:
                    {
                        return UpdateDeviceType();
                    }
            }

            return false;
        }


        public static clsDeviceType FindDeviceType(int DeviceTypeID)
        {
            string DeviceTypeName = "";

            if (clsDeviceTypeDataAccess.FindDeviceType(
                DeviceTypeID,
                ref DeviceTypeName))
            {
                return new clsDeviceType(
                    DeviceTypeID,
                    DeviceTypeName);
            }

            return null;
        }

        public static clsDeviceType FindDeviceType(string DeviceTypeName)
        {
            int DeviceTypeID = 0;

            if (clsDeviceTypeDataAccess.FindDeviceType(
                ref DeviceTypeID,
                 DeviceTypeName))
            {
                return new clsDeviceType(
                    DeviceTypeID,
                    DeviceTypeName);
            }

            return null;
        }
        public static bool IsDeviceTypeExists(int DeviceTypeID)
        {
            return clsDeviceTypeDataAccess.IsDeviceTypeExists(DeviceTypeID);
        }

        public static int? GetDeviceTypeIDByName(string DeviceTypeName)
        {
            return clsDeviceTypeDataAccess.GetDeviceTypeIDByName(DeviceTypeName);
        }
        public static bool DeleteDeviceType(int DeviceTypeID)
        {
            return clsDeviceTypeDataAccess.DeleteDeviceType(DeviceTypeID);
        }


        public static Task<DataTable> GetDeviceTypesAsync(
            int NumberOfDeviceTypesEachPage,
            int NumberOfPage)
        {
            return clsDeviceTypeDataAccess.GetDeviceTypesAsync(
                NumberOfDeviceTypesEachPage,
                NumberOfPage);
        }

        public static Task <int> GetDeviceTypesNumberOfPagesAsync(
            int DeviceTypesEachPage)
        {
            return clsDeviceTypeDataAccess.GetDeviceTypesNumberOfPagesAsync(
                DeviceTypesEachPage);
        }

        public static Task<DataTable> GetAllDeviceTypeNamesAsync()
        {
            return clsDeviceTypeDataAccess.GetAllDeviceTypeNamesAsync();
        }
     }
}