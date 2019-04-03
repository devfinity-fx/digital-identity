using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFINITY.DigitalIdentity.Models
{

    public class ModelNotFoundException : Exception
    {
        public ModelNotFoundException()
        {
        }

        public ModelNotFoundException(string message)
            : base(message)
        {
        }

        public ModelNotFoundException(string message, Exception inner)
            : base(message, inner)
        {

        }
    }
}
