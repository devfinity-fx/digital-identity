﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFINITY.DigitalIdentity.Models
{
    public class Barangay : Model
    {
        public int ID;
        public String Name;
        public int City;
        public String ZipCode;


        #region Details
        protected override string[] Fillable
        {
            get
            {
                return new string[] {
                    "ID", "Name", "City", "ZipCode",
                     "created_at", "updated_at"
                };
            }
        }

        protected override string TableName
        {
            get
            {
                return "barangays";
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
