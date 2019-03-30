using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwingWERX.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNullOrEmptyOrWhiteSpace(this String str)
        {
            return String.IsNullOrEmpty(str) || String.IsNullOrWhiteSpace(str);
        }
        
        public static bool IsComment(this String str)
        {
            return str.StartsWith("//");
        }
    }
}
