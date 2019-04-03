using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFINITY.DigitalIdentity.Models
{
    public class Province : Model
    {
        public int ID;
        public String Name;
        public String Region;


        #region Details
        protected override string[] Fillable
        {
            get
            {
                return new string[] {
                    "ID", "Name", "Region",
                     "created_at", "updated_at"
                };
            }
        }

        protected override string TableName
        {
            get
            {
                return "provinces";
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
