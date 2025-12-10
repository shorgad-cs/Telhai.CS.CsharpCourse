using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telhai.CS.CsharpCourse.Services.Logging
{
    public enum LogLevel
    {
        Debug = 0,
        Info = 1,
        Warn = 2,
        Exception = 3
    }

    /// <summary>
    /// Logger
    /// </summary>
    /// <example>
    ///  Logger.Instance.Loag("Test");
    /// </example>
    public class Logger : ILogger
    {
        //Field
        private static Logger instance;
        private string logFilePath = "";

        private Logger() { }
        private Logger(string logFilePath)
        {
            this.logFilePath = logFilePath;
        }

        public static Logger GetInstance(string path = "")
        {

            //first call to Instance 
            if (Logger.instance == null)
            {
                if (string.IsNullOrEmpty(path))
                {
                    Logger.instance = new Logger();
                }
                else
                {
                    Logger.instance = new Logger(path);
                }

            }

            return instance;
        }

        public static Logger Instance
        {
            get
            {
                //first call to Instance 
                if (Logger.instance == null)
                {
                    Logger.instance = new Logger();
                }

                return instance;

            }

        }


        public static void Log(string msg)
        {
            string formattedTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(msg + ":" + formattedTime);
        }

        public static void Log(string msg, LogLevel level)
        {
            string formattedTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string logTxt = $"{msg} : {level} : {formattedTime}";
            Console.WriteLine(logTxt);
        }
    }
}
