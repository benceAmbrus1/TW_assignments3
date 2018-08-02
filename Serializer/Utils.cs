using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializer
{
    class Utils
    {
        static public int CountNextSerial()
        {
            string[] files = Directory.GetFiles(@"C:\Users\ogben\Documents\Modul.Net\TW_assignments3\Serializer\bin\Debug");
            int count = 0;
            foreach (string file in files)
            {
                if(file.Contains("person"))
                {
                    count++;
                }
            }
            return count;
        }

        public static string LoadFirstPersonFileName()
        {
            string[] files = Directory.GetFiles(@"C:\Users\ogben\Documents\Modul.Net\TW_assignments3\Serializer\bin\Debug");
            foreach (string file in files)
            {
                if (file.Contains("person"))
                {
                    return file;
                }
            }
            return String.Empty;
        }
    }
}
