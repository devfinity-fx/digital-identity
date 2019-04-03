using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFINITY.DigitalIdentity.Models
{
    public class City : Model
    {
        public int ID;
        public String Name;
        public int Province;


        #region Details
        protected override string[] Fillable
        {
            get
            {
                return new string[] {
                    "ID", "Name", "Province",
                     "created_at", "updated_at"
                };
            }
        }

        protected override string TableName
        {
            get
            {
                return "cities";
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
