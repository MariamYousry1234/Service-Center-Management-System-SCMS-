using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCMS_Data_Access;

namespace SCMS_Business_Logic
{
    public class clsModel
    {
        public enum enMode { AddNew = 1, Update = 2 }

        public enMode Mode = enMode.AddNew;

        public int ModelID { set; get; }

        public int BrandID { set; get; }

        public clsBrand BrandInfo;

        public string ModelName { set; get; }


        public clsModel()
        {
            this.ModelName = "";
         
            this.BrandInfo = null;

            this.Mode = enMode.AddNew;
        }


        private clsModel(
            int ModelID,
            int BrandID,
            string ModelName
           )
        {
            this.ModelID = ModelID;
            this.BrandID = BrandID;
            this.ModelName = ModelName;
       
            this.BrandInfo = clsBrand.FindBrand(BrandID);

            this.Mode = enMode.Update;
        }


        private bool AddNewModel()
        {
            int? ModelID = clsModelDataAccess.AddNewModel(
                this.BrandID,
                this.ModelName);

            if (ModelID != null)
            {
                this.ModelID = (int)ModelID;
                return true;
            }

            return false;
        }


        private bool UpdateModel()
        {
            return clsModelDataAccess.UpdateModel(
                this.ModelID,
                this.BrandID,
                this.ModelName);
        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        if (AddNewModel())
                        {
                            Mode = enMode.Update;
                            return true;
                        }

                        return false;
                    }

                case enMode.Update:
                    {
                        return UpdateModel();
                    }
            }

            return false;
        }


        public static clsModel FindModel(int ModelID)
        {
            int BrandID = 0;
            string ModelName = "";
          

            if (clsModelDataAccess.FindModel(
                ModelID,
                ref BrandID,
                ref ModelName
               ))
            {
                return new clsModel(
                    ModelID,
                    BrandID,
                    ModelName
                   );
            }

            return null;
        }

        public static clsModel FindModel(int BrandID,string ModelName)
        {
            
            int ModelID = 0;


            if (clsModelDataAccess.FindModel(
                ref ModelID,
                 BrandID,
                 ModelName
               ))
            {
                return new clsModel(
                    ModelID,
                    BrandID,
                    ModelName
                   );
            }

            return null;
        }
        public static bool IsModelExists(int ModelID)
        {
            return clsModelDataAccess.IsModelExists(ModelID);
        }


        public static bool DeleteModel(int ModelID)
        {
            return clsModelDataAccess.DeleteModel(ModelID);
        }



        public static Task<DataTable> GetModelsAsync(
            int NumberOfModelsEachPage,
            int NumberOfPage)
        {
            return clsModelDataAccess.GetModelsAsync(
                NumberOfModelsEachPage,
                NumberOfPage);
        }


        public static Task<int> GetModelsNumberOfPagesAsync(
            int ModelsEachPage)
        {
            return clsModelDataAccess.GetModelsNumberOfPagesAsync(
                ModelsEachPage);
        }

        public static Task<DataTable> GetModelsForBrandAsync(int BrandID)
        {
            return clsModelDataAccess.GetModelsForBrandAsync(BrandID);
        }

       
     }
}