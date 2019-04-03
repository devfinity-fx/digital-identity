using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;

namespace DevFINITY.DigitalIdentity.Utils
{
    public enum AccessLevel
    {
        USER = 'U',
        ADMIN = 'A'
    }

    public class Utilities
    {
        public static HashSet<Type> NumericTypes = new HashSet<Type>
        {
            typeof(Byte),
            typeof(SByte),
            typeof(UInt16),
            typeof(UInt32),
            typeof(UInt64),
            typeof(Int16),
            typeof(Int32),
            typeof(Int64),
            typeof(Decimal),
            typeof(Double),
            typeof(Single),
            typeof(DateTime)
        };

        public static String Format(params object[] param)
        {
            String f = "";
            String placeholder = "";
            for (int i = 0; i < param.Length; i++)
            {
                placeholder = NumericTypes.Contains(param[i].GetType()) ? "{{{0}}}" : "'{{{0}}}'";
                f += String.Format(placeholder, i);
                f += i == param.Length - 1 ? "" : ", ";
            }

            String output = String.Format(f, param);

            output = output.Replace("'NOW()'", "NOW()");
            return output;
        }

        public static void EscapeKeyHandler(object sender, KeyEventArgs e, Control ctl)
        {
            if (e.KeyCode == Keys.Escape)
            {
                GetParentForm(ctl).ActiveControl = ctl;
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        public static Form GetParentForm(Control parent)
        {
            Form form = parent as Form;
            if (form != null)
            {
                return form;
            }
            if (parent != null)
            {
                // Walk up the control hierarchy
                return GetParentForm(parent.Parent);
            }
            return null; // Control is not on a Form
        }

        public static AccessLevel ToAccessLevel(int accessLevel)
        {
            switch (accessLevel)
            {
                case '1': return AccessLevel.USER;
                case '2': return AccessLevel.ADMIN;
            }

            return AccessLevel.USER;

        }

        public static void GetMyProperties<T>(T obj)
        {
            foreach (PropertyInfo pinfo in obj.GetType().GetProperties())
            {
                var getMethod = pinfo.GetGetMethod();
                if (getMethod.ReturnType.IsArray)
                {
                    var arrayObject = getMethod.Invoke(obj, null);
                    foreach (object element in (Array)arrayObject)
                    {
                        foreach (PropertyInfo arrayObjPinfo in element.GetType().GetProperties())
                        {
                            Console.WriteLine(arrayObjPinfo.Name + ":" + arrayObjPinfo.GetGetMethod().Invoke(element, null).ToString());
                        }
                    }
                }
            }
        }
    }

    public static class Extensions
    {
        public static bool IsNullOrEmptyOrWhiteSpace(this String str)
        {
            return String.IsNullOrEmpty(str) || String.IsNullOrWhiteSpace(str);
        }

        public static string ToText(this string[] array)
        {
            String s = "";
            for (int i = 0; i < array.Length; i++)
            {
                s += array[i];
                s += i == array.Length - 1 ? "" : ", ";
            }
            return s;
        }

        public static string Truncate(this string s, int maxLength)
        {
            return s != null && s.Length > maxLength ? s.Substring(0, maxLength) : s;
        }

        public static char ToChar(this AccessLevel accessLevel)
        {
            switch (accessLevel)
            {
                case AccessLevel.ADMIN: return 'A';
                case AccessLevel.USER: return 'U';
            }
            return 'U';
        }

        public static string MySQLEscape(this string str)
        {
            return Regex.Replace(str, @"[\x00'""\b\n\r\t\cZ\\%_]",
                delegate (Match match)
                {
                    string v = match.Value;
                    switch (v)
                    {
                        case "\x00":            // ASCII NUL (0x00) character
                            return "\\0";
                        case "\b":              // BACKSPACE character
                            return "\\b";
                        case "\n":              // NEWLINE (linefeed) character
                            return "\\n";
                        case "\r":              // CARRIAGE RETURN character
                            return "\\r";
                        case "\t":              // TAB
                            return "\\t";
                        case "\u001A":          // Ctrl-Z
                            return "\\Z";
                        default:
                            return "\\" + v;
                    }
                });
        }

        public static TKey FindKeyByValue<TKey, TValue>(this Dictionary<TKey, TValue> dictionary,
                                               TValue value)
        {
            TKey key;
            if (dictionary.ContainsValue(value))
            {
                return key = dictionary.FirstOrDefault(t => t.Value.ToString().StartsWith(value.ToString())).Key;
            }

            throw new KeyNotFoundException(String.Format("Well, shit. {0} not found.", value));
        }
    }
}
