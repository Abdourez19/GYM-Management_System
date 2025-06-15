using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gym_Business;
using System.Data;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace GymMS_Project1.Global
{
    internal static class clsGlobal
    {
        public static clsUser CurrentUser;

        public static bool RememberUsernameAndPassword(string username, string password)
        {
            try
            {
                string FolderPath = System.IO.Directory.GetCurrentDirectory();
                string FilePath = FolderPath + "\\LoginData.txt";

                if (string.IsNullOrEmpty(username) && File.Exists(FilePath))
                {
                    File.Delete(FilePath);
                    return true;
                }

                string DataToSave = $"{username}#//#{password}";

                File.WriteAllText(FilePath,DataToSave);

                //using (StreamWriter sw = new StreamWriter (FilePath))
                //{
                //    sw.WriteLine(DataToSave);
                //    return true;
                //}

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR: {e.Message}");
                return false;
            }

        }

        public static bool GetStoredCredential(ref string Username, ref string Password)
        {
           
            try
            {
                string FolderPath = Directory.GetCurrentDirectory();
                string FilePath = Path.Combine(FolderPath, "LoginData.txt");

                if (File.Exists(FilePath))
                {
                    using (StreamReader reader = new StreamReader(FilePath))
                    {
                        string Line;

                        Line = reader.ReadLine();

                        string[] result = Line.Split(new string[] { "#//#" }, StringSplitOptions.None);

                        Username = result[0];
                        Password = result[1];
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                return false;
            }
            
        }
    }
}
