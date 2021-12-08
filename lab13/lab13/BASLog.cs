using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    static class BASLog
    {
        static string logPath = @"D:\info\BASlogfile.txt";

        public static void Writer(string buff)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(logPath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(buff);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
    }
}
