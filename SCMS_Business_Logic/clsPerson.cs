using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using SCMS_Data_Access;

namespace SCMS_Business_Logic
{
    public class clsPerson
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;

        public enum enGender { Male = 0, Female = 1 }
        public int  PersonID{set;get;}

        public string FirstName { set; get; }

        public string SecondName { set; get; }

        public string? ThirdName { set; get; }

        public string? LastName { set; get; }

        public string FullName
        {
            get {
                return FirstName + " " + SecondName + " " + ThirdName + " " + LastName;
               }
        }
        public enGender Gender { set; get; }

        public string txtGender
        {
            get
            {
               return  Gender == enGender.Male ? "Male" : "Female"; 
            }
        }
        public string PhoneNumber { set; get; }

        public string? Email { set; get; }

        public string Address { set; get; }




        public clsPerson ()
        {
            this.ThirdName = null;
            this.LastName = null;           
            this.Email = null;  
            
            this.Mode = enMode.AddNew;
        }

        private clsPerson(int PersonID,string FirstName,string SecondName,string?ThirdName,
            string?LastName,enGender Gender,string PhoneNumber,string?Email,string Address)
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.Gender = Gender;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.Address = Address;
        

            Mode = enMode.Update;
        }
       
        private bool AddNewPerson()
        {
            int? PersonID = clsPersonDataAccess.AddNewPerson(this.FirstName, this.SecondName,
                 this.ThirdName, this.LastName,(byte)this.Gender, this.PhoneNumber, this.Email, this.Address
                );
            if(PersonID != null)
            {
                this.PersonID = (int)PersonID;
                return true;
            }
            return false;
        }

        private bool UpdatePerson()
        {
            return clsPersonDataAccess.UpdatePerson(this.PersonID, this.FirstName, this.SecondName,
                this.ThirdName, this.LastName,(byte)this.Gender, this.PhoneNumber, this.Email, this.Address
              );

        }
       
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        if(AddNewPerson())
                        {
                            Mode = enMode.Update;
                            return true;
                        }

                        return false;
                    }

                case enMode.Update:
                    {
                        return UpdatePerson();
                    }
            }

            return false;
        }


        public static clsPerson FindPerson(int PersonID)
        {
            string FirstName = "", SecondName = "" ,PhoneNumber = "", Address = "";
            string? ThirdName = null,LastName = null, Email = null;
           
            byte Gender = 0;

            if ( clsPersonDataAccess.FindPerson(PersonID,ref FirstName, ref SecondName, ref ThirdName,
               ref LastName,ref Gender, ref PhoneNumber, ref Email, ref Address))
            {
                return new clsPerson(PersonID, FirstName, SecondName, ThirdName, LastName, 
                    (enGender)Gender,
                    PhoneNumber, Email, Address);
            }

            return null;
        }
        public static clsPerson FindPersonByPhoneNumber(string PhoneNumber)
        {
            int PersonID = 0;
            string FirstName = "", SecondName = "", Address = "";
            string? ThirdName = null, LastName = null, Email = null;

            byte Gender = 0;

            if (clsPersonDataAccess.FindPersonByPhoneNumber(ref PersonID, ref FirstName, ref SecondName, ref ThirdName,
               ref LastName, ref Gender,  PhoneNumber, ref Email, ref Address))
            {
                return new clsPerson(PersonID, FirstName, SecondName, ThirdName, LastName,
                    (enGender)Gender,
                    PhoneNumber, Email, Address);
            }

            return null;
        }


        public static bool IsPersonExists(int PersonID)
        {
            return clsPersonDataAccess.IsPersonExists(PersonID);
        }
        public static bool DeletePerson(int PersonID)
        {
            return clsPersonDataAccess.DeletePerson(PersonID);
        }

        public static Task<DataTable> GetPersonsAsync(int NumberOfPersonsEachPage, int NumberOfPage)
        {
            return clsPersonDataAccess.GetPersonsAsync(NumberOfPersonsEachPage, NumberOfPage);
        }

        public static Task<DataTable> GetAllPersonIDsAsync()
        {
            return clsPersonDataAccess.GetAllPersonIDsAsync();
        }

        public static Task<DataTable> GetAllPhoneNumbersAsync()
        {
            return clsPersonDataAccess.GetAllPhoneNumbersAsync();
        }

        public static Task<int> GetPersonsNumberOfPagesAsync(int PersonsEachPage)
        {
            return clsPersonDataAccess.GetPersonsNumberOfPagesAsync(PersonsEachPage);
        }
    }
}
