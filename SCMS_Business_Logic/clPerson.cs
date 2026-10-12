using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCMS_Business_Logic
{
    public abstract  class clPerson
    {
        public enum enGender { Male = 0, Female = 1 }

        public string FirstName { set; get; }

        public string SecondName { set; get; }

        public string? ThirdName { set; get; }

        public string? LastName { set; get; }

        public string FullName
        {
            get
            {
                return FirstName + " " + SecondName + " " + ThirdName + " " + LastName;
            }
        }
        public enGender Gender { set; get; }

        public string txtGender
        {
            get
            {
                return Gender == enGender.Male ? "Male" : "Female";
            }
        }
        public string PhoneNumber { set; get; }

        public string? Email { set; get; }

        public string Address { set; get; }



    }
}
