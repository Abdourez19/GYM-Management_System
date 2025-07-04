using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gym_Business;
using System.Data;
using System.IO;
using System.Runtime.Remoting.Messaging;
using Microsoft.Win32;
using System.Diagnostics;
using System.Drawing;
using System.Security.Cryptography;

namespace GymMS_Project1.Global
{
    internal static class clsGlobal
    {
        public static clsUser CurrentUser;

        
        //public static bool RememberUsernameAndPassword(string username, string password)
        //{
        //    try
        //    {
        //        string FolderPath = System.IO.Directory.GetCurrentDirectory();
        //        string FilePath = FolderPath + "\\LoginData.txt";

        //        if (string.IsNullOrEmpty(username) && File.Exists(FilePath))
        //        {
        //            File.Delete(FilePath);
        //            return true;
        //        }

        //        string DataToSave = $"{username}#//#{password}";

        //        File.WriteAllText(FilePath,DataToSave);

        //        //using (StreamWriter sw = new StreamWriter (FilePath))
        //        //{
        //        //    sw.WriteLine(DataToSave);
        //        //    return true;
        //        //}

        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine($"ERROR: {e.Message}");
        //        return false;
        //    }

        //}
        //public static bool GetStoredCredential(ref string Username, ref string Password)
        //{
           
        //    try
        //    {
        //        string FolderPath = Directory.GetCurrentDirectory();
        //        string FilePath = Path.Combine(FolderPath, "LoginData.txt");

        //        if (File.Exists(FilePath))
        //        {
        //            using (StreamReader reader = new StreamReader(FilePath))
        //            {
        //                string Line;

        //                Line = reader.ReadLine();

        //                string[] result = Line.Split(new string[] { "#//#" }, StringSplitOptions.None);

        //                Username = result[0];
        //                Password = result[1];
        //            }
        //        }
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine($"Error: {e.Message}");
        //        return false;
        //    }
            
        //}


        public static bool SaveCredentialsToRegistry(string Username, string Password)
        {
            string KeyPath = @"SOFTWARE\GymMS_Project1";
            string ValueName = @"LoginCredentials";
            string ValueData = $"{Username}##//##{Password}";

            try
            {
                using (RegistryKey BaseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                {
                    using (RegistryKey key = BaseKey.OpenSubKey(KeyPath, true))
                    {
                        if (key != null)
                        {
                            //Registry.SetValue(key.ToString(), ValueName, ValueData, RegistryValueKind.String);
                            key.SetValue(ValueName, ValueData, RegistryValueKind.String);
                            return true;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR:" + e.Message);
            }
            return false;
        }
        public static bool GetStoredCredentialFromRegistry (ref string Username, ref string Password)
        {

            string KeyPath = @"SOFTWARE\GymMS_Project1";
            string ValueName = @"LoginCredentials";
            try
            {
                using (RegistryKey basekey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                {
                    using (RegistryKey key = basekey.OpenSubKey(KeyPath, true))
                    {
                        if (key != null)
                        {
                            string ValueData = key.GetValue(ValueName) as string;

                            if (!string.IsNullOrEmpty(ValueData))
                            {
                                string[] LoginCredentials = ValueData.Split(new string[] { "##//##" }, StringSplitOptions.None);
                                Username = LoginCredentials[0];
                                Password = LoginCredentials[1];
                                return true;
                            }
                        }
                    }
                }    
            }

            catch (Exception e)
            {
                Console.WriteLine("ERROR:" + e.Message);
            }
            return false;
        }
        public static bool DeleteCredentialsFromRegistry ()
        {
            string KeyPath = @"SOFTWARE\GymMS_Project1";
            string ValueName = "LoginCredentials";

            try
            {
                using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                {
                    using (RegistryKey key = baseKey.OpenSubKey(KeyPath, true))
                    {
                        if (key != null)
                        {
                            key.DeleteValue(ValueName);
                            return true;
                        }
                    }
                }
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("UnauthorizedAccessException: Run the program with administrative privileges.");
                //Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.Message);
            }
            return false;
        }
        public static bool LogUserToEventLog (clsUser user)
        {
            if (user == null)
                return false;

            string SourceName = "GymMS_Project1";

            if (!EventLog.SourceExists(SourceName))
            {
                EventLog.CreateEventSource(SourceName, "Application");
                Console.WriteLine("Source created Successfully :-)");
            }

            string message = $"you have used \"Username: {user.Username}\" to Login";
            EventLog.WriteEntry(SourceName, message, EventLogEntryType.Warning);
            Console.WriteLine("Activity logged successfully to Windows Logs in Event Viewer!");

            return true;
        }
        public static bool LogErrorsAndExceptionToWindowsLogs(string message)
        {
            string SourceName = "GymMS_Project1";

            if (!EventLog.SourceExists(SourceName))
            {
                EventLog.CreateEventSource(SourceName, "Application");
                Console.WriteLine("Source created Successfully :-)");
            }

            EventLog.WriteEntry(SourceName, message, EventLogEntryType.Error);
            Console.WriteLine("An unexpected error occurred!");

            return true;
        }

        public static string ComputeHash(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] PwHashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                return BitConverter.ToString(PwHashBytes).Replace("-", "").ToLower();
            }

        }
    }
}
