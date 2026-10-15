using SCMS_Data_Access;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SCMS_Business_Logic
{
    public  class clsDevice
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        public enum enColor
        { 
           Black =1,
          White =2,
          Silver =3,
          Gray =4,
          Blue=5, 
          Red =6,
          Green =7,
          Yellow=8,
          Orange=9,
          Purple =10,
          Pink=11,
          Gold =12,
          Brown =13,
          Beige =14,
          Bronze=15,
         NavyBlue =16,
          DarkGray =17,
         LightGray =18,
          Other=19
     }
        public int DeviceID { set; get; }
        public int CustomerID { set; get; }

        public clsCustomer CustomerInfo;

        public int DeviceTypeID { set; get; }

        public clsDeviceType DeviceTypeInfo;

        public int BrandID { set; get; }

        public clsBrand BrandInfo;

        public int ModelID { set; get; }

        public clsModel ModelInfo;

        public string SerialNumber { set; get; }

        public enColor Color { set; get; }

        public string txtColor
        {
            get
            {
                return _GetStringColor();
            }
        }
        
        public int CreatedByUserID { set; get; }

        public clsUser CreatedUserInfo;

       
        public DateTime CreatedDate { set; get; }

        public int? LastUpdatedUserID { set; get; }

        public clsUser? LastUpdatedUserInfo;

        public DateTime? LastUpdatedDate { set; get; }

        public bool HasRepairOrders
        {
            get
            {
                return clsRepairOrder.IsDeviceHasRepairOrders(this.DeviceID);
            }
        }
        public clsDevice()
        {

             CustomerInfo = new clsCustomer();

            DeviceTypeInfo = new clsDeviceType();

            BrandInfo = new clsBrand();

            ModelInfo = new clsModel();

            CreatedUserInfo = new clsUser();



            LastUpdatedUserInfo = new clsUser();

   

        Mode = enMode.AddNew;
        }

        private clsDevice(
            int DeviceID,
            int CustomerID,
            int DeviceTypeID,
            int BrandID,
            int ModelID,
            string SerialNumber,
            enColor Color,
          
            int CreatedByUserID,
            DateTime CreatedDate,
            int? LastUpdatedUserID,
            DateTime? LastUpdatedDate)
        {
            this.DeviceID = DeviceID;
            this.CustomerID = CustomerID;
            this.DeviceTypeID = DeviceTypeID;
            this.BrandID = BrandID;
            this.ModelID = ModelID;
            this.SerialNumber = SerialNumber;
            this.Color = Color;
            
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;
            this.LastUpdatedUserID = LastUpdatedUserID;
            this.LastUpdatedDate = LastUpdatedDate;


            this.CustomerInfo = clsCustomer.FindCustomer(CustomerID);
            this.DeviceTypeInfo = clsDeviceType.FindDeviceType(DeviceTypeID);
            this.BrandInfo = clsBrand.FindBrand(BrandID);
            this.ModelInfo = clsModel.FindModel(ModelID);
            this.CreatedUserInfo = clsUser.FindUser(CreatedByUserID);

            if (LastUpdatedUserID != null)
                this.LastUpdatedUserInfo = clsUser.FindUser((int)LastUpdatedUserID);


            Mode = enMode.Update;
        }

        private bool AddNewDevice()
        {
            int? DeviceID = clsDeviceDataAccess.AddNewDevice(
                this.CustomerID,
                this.DeviceTypeID,
                this.BrandID,
                this.ModelID,
                this.SerialNumber,
                (byte)this.Color,
                this.CreatedByUserID);

            if (DeviceID != null)
            {
                this.DeviceID = (int)DeviceID;
                return true;
            }

            return false;
        }

        private bool UpdateDevice()
        {
            return clsDeviceDataAccess.UpdateDevice(
                this.DeviceID,
                this.CustomerID,
                this.DeviceTypeID,
                this.BrandID,
                this.ModelID,
                this.SerialNumber,
                (byte)this.Color,
               
                this.LastUpdatedUserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        if (AddNewDevice())
                        {
                            Mode = enMode.Update;
                            return true;
                        }

                        return false;
                    }

                case enMode.Update:
                    {
                        return UpdateDevice();
                    }
            }

            return false;
        }

        public static clsDevice FindDevice(int DeviceID)
        {
            int CustomerID = 0;
            int DeviceTypeID = 0;
            int BrandID = 0;
            int ModelID = 0;

            string SerialNumber = "";

            byte Color = 0;

          
            int CreatedByUserID = 0;
            DateTime CreatedDate = DateTime.MinValue;

            int? LastUpdatedUserID = null;
            DateTime? LastUpdatedDate = null;

            if (clsDeviceDataAccess.FindDevice(
                DeviceID,
                ref CustomerID,
                ref DeviceTypeID,
                ref BrandID,
                ref ModelID,
                ref SerialNumber,
                ref Color,
               
                ref CreatedByUserID,
                ref CreatedDate,
                ref LastUpdatedUserID,
                ref LastUpdatedDate))
            {
                return new clsDevice(
                    DeviceID,
                    CustomerID,
                    DeviceTypeID,
                    BrandID,
                    ModelID,
                    SerialNumber,
                    (enColor)Color,
                 
                    CreatedByUserID,
                    CreatedDate,
                    LastUpdatedUserID,
                    LastUpdatedDate);
            }

            return null;
        }

        public static clsDevice FindDevice(string SerialNumber)
        {
            int CustomerID = 0;
            int DeviceTypeID = 0;
            int BrandID = 0;
            int ModelID = 0;

            int DeviceID = 0;

            byte Color = 0;

            int CreatedByUserID = 0;
            DateTime CreatedDate = DateTime.MinValue;

            int? LastUpdatedUserID = null;
            DateTime? LastUpdatedDate = null;

            if (clsDeviceDataAccess.FindDevice(
                ref DeviceID,
                ref CustomerID,
                ref DeviceTypeID,
                ref BrandID,
                ref ModelID,
                 SerialNumber,
                ref Color,
             
                ref CreatedByUserID,
                ref CreatedDate,
                ref LastUpdatedUserID,
                ref LastUpdatedDate))
            {
                return new clsDevice(
                    DeviceID,
                    CustomerID,
                    DeviceTypeID,
                    BrandID,
                    ModelID,
                    SerialNumber,
                    (enColor)Color,
             
                    CreatedByUserID,
                    CreatedDate,
                    LastUpdatedUserID,
                    LastUpdatedDate);
            }

            return null;
        }

        private string _GetStringColor()
        {
            switch (Color)
            {
                case enColor.Black:
                    return "Black";

                case enColor.White:
                    return "White";

                case enColor.Silver:
                    return "Silver";

                case enColor.Gray:
                    return "Gray";

                case enColor.Blue:
                    return "Blue";

                case enColor.Red:
                    return "Red";

                case enColor.Green:
                    return "Green";

                case enColor.Yellow:
                    return "Yellow";

                case enColor.Orange:
                    return "Orange";

                case enColor.Purple:
                    return "Purple";

                case enColor.Pink:
                    return "Pink";

                case enColor.Gold:
                    return "Gold";

                case enColor.Brown:
                    return "Brown";

                case enColor.Beige:
                    return "Beige";

                case enColor.Bronze:
                    return "Bronze";

                case enColor.NavyBlue:
                    return "Navy Blue";

                case enColor.DarkGray:
                    return "Dark Gray";

                case enColor.LightGray:
                    return "Light Gray";

                case enColor.Other:
                    return "Other";

                default:
                    return "Unknown";
            }
        }
        public static bool DeleteDevice(int DeviceID)
        {
            return clsDeviceDataAccess.DeleteDevice(DeviceID);
        }

        public static bool IsDeviceExists(int DeviceID)
        {
            return clsDeviceDataAccess.IsDeviceExists(DeviceID);
        }
        public static int? GetDeviceIDBySerialNnumber(string SerialNumber)
        {
            return clsDeviceDataAccess.GetDeviceIDBySerialNnumber(SerialNumber);
        }
        public static Task<DataTable> GetDevicesAsync(
          int NumberOfDevicesEachPage,
          int NumberOfPage)
        {
            return clsDeviceDataAccess.GetDevicesAsync(
                NumberOfDevicesEachPage,
                NumberOfPage);
        }

        public static Task<int> GetDevicesNumberOfPagesAsync(
            int DevicesEachPage)
        {
            return clsDeviceDataAccess.GetDevicesNumberOfPagesAsync(
                DevicesEachPage);
        }

        public static Task<DataTable> GetDevicesForCustomer(int CustomerID)
        {
            return clsDeviceDataAccess.GetDevicesForCustomer(CustomerID);
        }

        public static bool IsCustomerHasDevices(int CustomerID)
        {
            return clsDeviceDataAccess.IsCustomerHasDevices(CustomerID);
        }
        public Task<DataTable> GetAllRepairOrdersForDeviceAsync()
        {
            return clsRepairOrder.GetAllRepairOrdersForDeviceAsync(this.DeviceID);
        }


    }
}
