using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFINITY.DigitalIdentity.Models
{
    public class Fingerprint : Model
    {
        public int ID;
        public int Index;
        public String FingerprintData;
        public String Address;


        #region Details
        protected override string[] Fillable
        {
            get
            {
                return new string[] {
                    "ID", "Index", "FingerprintData", "Address"
                     //"created_at", "updated_at"
                };
            }
        }

        protected override string TableName
        {
            get
            {
                return "fingerprints";
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
