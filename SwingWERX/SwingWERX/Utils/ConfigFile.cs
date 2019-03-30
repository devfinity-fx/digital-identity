using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using SwingWERX.Extensions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace SwingWERX.Utils
{
    public class ConfigFile
    {
        public String Path { get; set; }

        private String[] content;
        private Dictionary<String, String> theMap;

        string EXE = Assembly.GetExecutingAssembly().GetName().Name;

        public ConfigFile(String filePath)
        {
            theMap = new Dictionary<string, string>();
            Path = filePath;
            content = File.ReadAllLines(filePath);

            foreach(String line in content)
            {
                if (line.IsNullOrEmptyOrWhiteSpace() || line.IsComment() ||
                    line.StartsWith("import"))
                {
                    continue;
                }
                String[] configLine = line.Split(':');
                String key = configLine[0].Trim();
                String val = configLine[1].Trim();
                theMap.Add(key, val);
            }
        }

        public String Read(String key)
        {
            return this[key];
        }

        public void Write(String key, String value)
        {
            theMap[key] = value;
        }

        public String this[String key]
        {
            get
            {
                if (theMap.Keys.Contains(key))
                {
                    return theMap[key];
                }
                else
                {
                    throw new KeyNotFoundException(String.Format("Key '{0}' not found in list.", key));
                }
            }
            set
            {
                if (!theMap.Keys.Contains(key))
                {
                    theMap.Add(key, value);
                }
                else
                {
                    theMap[key] = value;
                    int index = content.ToList().FindIndex(com => com.StartsWith(key));
                    content[index] = String.Format("{0}: {1}", key, value);
                }
            }
        }

        [DllImport("kernel32")]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32")]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        public void save()
        {
            File.WriteAllLines(Path, content);
        }
    }
}
