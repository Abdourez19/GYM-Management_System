using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;
using System.Configuration;


namespace Gym_DataAccess
{
    public class clsDataAccessSettings
    {
        //public static string ConnectionString = "server =.;database = GYM_MS_Project1;user id = sa; password = 123456";
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

        /// <summary>
        /// returns true if the error message logged successfully to Windows Logs.
        /// Logs activity status in the console
        /// </summary>
        /// <param name="message">most Likely message sent from Exception</param>
        /// <returns></returns>
        public static bool LogErrorsAndExceptionToWindowsLogs(string message)
        {
            string SourceName = "GymMS_Project1";

            if (!EventLog.SourceExists(SourceName))
            {
                EventLog.CreateEventSource(SourceName, "Application");
                Console.WriteLine("Source created Successfully :-)");
            }

            EventLog.WriteEntry(SourceName, message , EventLogEntryType.Error);
            Console.WriteLine("An unexpected error occurred!, Error details saved in Windows Logs under Application.");

            return true;
        }




    }
    
}
