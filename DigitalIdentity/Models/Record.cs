using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFINITY.DigitalIdentity.Models
{
    public class Record : Model
    {
        public int ID;
        public String Address;
        public String PrivateKey;
        public String LastName;
        public String FirstName;
        public String MiddleName;
        public String Suffix;
        public String MaidenName;
        public String DateOfBirth;
        public String PlaceOfBirth;
        public char Gender;
        public String Nationality;
        public String Religion;
        public char MaritalStatus;
        public int BloodType;
        public String SSS;
        public String TIN;
        public String PhilHealth;
        public String Passport;
        public String MobileNo;
        public String LandlineNo;
        public String Email;
        public String DocumentPresented;


        #region Details
        protected override string[] Fillable
        {
            get
            {
                return new string[] {
                    "ID","Address","PrivateKey",
                    "LastName","FirstName","MiddleName",
                    "Suffix","MaidenName","DateOfBirth", "PlaceOfBirth",
                    "Gender","Nationality","Religion",
                    "MaritalStatus","BloodType","SSS",
                    "TIN","PhilHealth","Passport",
                    "MobileNo","LandlineNo","Email","DocumentPresented",
                     "created_at", "updated_at"
                };
            }
        }

        protected override string TableName
        {
            get
            {
                return "records";
            }
        }

        protected override string PrimaryKey
        {
            get
            {
                return "ID";
            }
        }
        #endregion
    }
}
