using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFINITY.DigitalIdentity.Classes
{
    public class Session
    {
        private Session() { } // nope.

        private static String _sessionid;
        private static List<String> _errorBag;

        private static bool _started;

        //public static User Account { get; set; }

        public static void Start()
        {
            GenerateID();
            InitializeErrorBag();
            _started = true;
        }

        public static void GenerateID()
        {
            String chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ01234567890";
            Random r = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 32; i++)
            {
                sb.Append(chars[r.Next(chars.Length - 1)]);
            }
            _sessionid = sb.ToString();

        }

        private static void InitializeErrorBag()
        {
            _errorBag = new List<String>();
            Console.WriteLine("Log: ErrorBag Initialized.");
        }

        public static List<String> ErrorBag
        {
            get
            {
                Console.WriteLine("ErrorBagCall");
                return _errorBag;
            }
        }

    }
}
