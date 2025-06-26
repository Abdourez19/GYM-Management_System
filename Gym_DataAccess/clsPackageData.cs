using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Gym_DataAccess
{
    public class clsPackageData
    {
        public static int GetPackagesCount()
        {
            int TotalPakgesCount = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT COUNT(Packages.PackageID) from Packages";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int TotalPackages))
                            TotalPakgesCount = TotalPackages;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: FROM clsMemberData.GetPackagesCount:" +
                    $"********************{e.Message} *************************");
                clsDataAccessSettings.LogErrorsAndExceptionToWindowsLogs(e.Message);
            }

            return TotalPakgesCount;
        }
        public static bool FindPackageByID (int PackageID, ref string PackageName, ref string PackageDescription,
                                                    ref double PricePerMonth)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT * FROM Packages 
                                      WHERE PackageID = @PackageID";

                    using (SqlCommand command = new SqlCommand (query, connection))
                    {
                        command.Parameters.AddWithValue("@PackageID", PackageID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                PackageName = (string)reader["PackageName"];
                                PackageDescription = (string)reader["PackageDescription"];
                                PricePerMonth =  Convert.ToDouble( reader["PricePerMonth"]);
                                IsFound = true;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR FROM clsPackagesData.FindPackageByID:" +
                    $" ***************** {e.Message} *****************");
                clsDataAccessSettings.LogErrorsAndExceptionToWindowsLogs(e.Message);
            }
            return IsFound;
        }

        public static bool FindPackageByName(string PackageName, ref int PackageID, ref string PackageDescription,
                                                    ref double PricePerMonth)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT * FROM Packages 
                                      WHERE PackageName = @PackageName";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PackageName", PackageName);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                PackageID = Convert.ToInt32(reader["PackageID"]);
                                PackageDescription = (string)reader["PackageDescription"];
                                PricePerMonth = Convert.ToDouble(reader["PricePerMonth"]);
                                IsFound = true;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR FROM clsPackagesData.FindPackageByName:" +
                    $" ***************** {e.Message} *****************");
                clsDataAccessSettings.LogErrorsAndExceptionToWindowsLogs(e.Message);
            }
            return IsFound;
        }
        public static DataTable GetPackagesList()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string Query = @"SELECT * FROM packages ORDER BY PackageID";

                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR from clsPackageData.GetPackagesList: " +
                    $"**********************{e.Message}***********************");
                clsDataAccessSettings.LogErrorsAndExceptionToWindowsLogs(e.Message);
            }
            return dt;
        }
        public static int AddNewPackage (string PackageName, string PackageDescription, double PricePerMonth)
        {
            int AffectedRows = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"insert into Packages (PackageName, PackageDescription, PricePerMonth)
                                        values(@PackageName, @PackageDescription , @PricePerMonth)
                                        select SCOPE_IDENTITY()";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PackageName", PackageName);
                        command.Parameters.AddWithValue("@PackageDescription", PackageDescription);
                        command.Parameters.AddWithValue("@PricePerMonth", PricePerMonth);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int PackageID))
                            AffectedRows = PackageID;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: FROM clsPackageData.AddNewPackage:" +
                    $"********************{e.Message} *************************");
                clsDataAccessSettings.LogErrorsAndExceptionToWindowsLogs(e.Message);
            }

            return AffectedRows;
        }
        public static bool UpdatePackage(int PackageID, string PackageName, string PackageDescription, double PricePerMonth)
        {
            
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"UPDATE Packages
                                    SET PackageName = @PackageName,
                                        PackageDescription = @PackageDescription,
                                        PricePerMonth = @PricePerMonth
                                    WHERE PackageID = @PackageID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PackageID", PackageID);
                        command.Parameters.AddWithValue("@PackageName", PackageName);
                        command.Parameters.AddWithValue("@PackageDescription", PackageDescription);
                        command.Parameters.AddWithValue("@PricePerMonth", PricePerMonth);

                        int AffectedRows = command.ExecuteNonQuery();
                        return
                            AffectedRows > 0;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: FROM clsPackageData.UpdatePackage:" +
                    $"********************{e.Message} *************************");
                clsDataAccessSettings.LogErrorsAndExceptionToWindowsLogs(e.Message);
            }

            return false;
        }
        public static bool Delete(int PackageID)
        {
            bool IsDeleted = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"DELETE FROM Packages
                                    WHERE PackageID = @PackageID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PackageID", PackageID);

                        int AffectedRows = command.ExecuteNonQuery();
                        if (AffectedRows > 0)
                            IsDeleted = true;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: FROM clsPackageData.Delete:" +
                    $"********************{e.Message} *************************");
                clsDataAccessSettings.LogErrorsAndExceptionToWindowsLogs(e.Message);
            }

            return IsDeleted;
        }

    }
}
