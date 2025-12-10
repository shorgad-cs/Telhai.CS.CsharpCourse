using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telhai.CS.CsharpCourse._01_Practice.Logging
{
   public enum LogLevel
    {
        Debug =0,
        Info=1,
        Warn=2,
        Exception=3
    }


    public class Logger
    {
      
         public static void Log(string msg)
        {
            string formattedTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(msg +":"+ formattedTime);
        }

        public static void Log(string msg, LogLevel level)
        {
            string formattedTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string logTxt = $"{msg} : {level} : {formattedTime}";
            Console.WriteLine(logTxt);
        }
    }
}
