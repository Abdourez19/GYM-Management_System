using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Gym_DataAccess
{
    public class clsUserData
    {
        public static bool Find (int UserID, ref int PersonID, ref string Username, ref string Password, ref int Permissions)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"Select * from Users where UserID= @UserID";

                    using (SqlCommand command = new SqlCommand (query, connection))
                    {
                        command.Parameters.AddWithValue("UserID", UserID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                PersonID = Convert.ToInt32(reader["PersonID"]);
                                Username = (string)reader["Username"];
                                Password = (string)reader["Password"];
                                Permissions = Convert.ToInt32(reader["Permissions"]);
                                IsFound = true;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR FROM clsUserData.Find(UserID):" +
                    $" *****************{e.Message}*****************");
                clsDataAccessSettings.LogErrorsAndExceptionToWindowsLogs(e.Message);
            }

            return IsFound;


        }
        public static bool Find(string Username, string Password,  ref int UserID, ref int PersonID, ref int Permissions)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"Select * from Users where 
                                                Username = @Username and Password = @Password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("Username", Username);
                        command.Parameters.AddWithValue("Password", Password);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                PersonID = Convert.ToInt32(reader["PersonID"]);
                                UserID = Convert.ToInt32(reader["UserID"]);
                                Permissions = Convert.ToInt32(reader["Permissions"]);
                                IsFound = true;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR FROM clsUserData.Find(Username, Password):" +
                    $" *****************{e.Message}*****************");
                clsDataAccessSettings.LogErrorsAndExceptionToWindowsLogs(e.Message);
            }

            return IsFound;
        }
        public static bool IsUserExists (string Username)
        {
            bool IsExists = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"Select Found = 1 from Users 
                                     where Username = @Username ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("Username", Username);

                        object Result = command.ExecuteScalar();

                        if (Result != null && int.TryParse(Result.ToString(), out int Found))
                            IsExists = true;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR FROM clsUserData.IsUserExists(Username):" +
                    $" *****************{e.Message}*****************");
                clsDataAccessSettings.LogErrorsAndExceptionToWindowsLogs(e.Message);
            }
            return IsExists;
        }
        public static bool DeleteUser(int UserID)
        {
            bool IsDeleted = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"DELETE from Users 
                                     where UserID = @UserID ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("UserID", UserID);

                        int AffectedRows = command.ExecuteNonQuery();

                        if (AffectedRows > 0)
                            IsDeleted = true;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR FROM clsUserData.DeleteUser(UserID):" +
                    $" *****************{e.Message}*****************");
                clsDataAccessSettings.LogErrorsAndExceptionToWindowsLogs(e.Message);
            }

            return IsDeleted;
        }
        public static DataTable GetUsersLIst ()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"select Users.UserID, Users.Username, People.FirstName, People.LastName, People.Phone, People.Email,

                                          		case (People.Gender)
                                          			when 0 then 'Male'
                                          			when 1 then 'Female'
                                          		END AS Gender,
                                        		
                                        		case Users.Permissions
                                        			when -1  then 'Owner'
                                        			when 63  then 'full'
                                        			when 3  then 'Basic'
                                        			else 'customized'
                                        		end as Permissions_Level

                                        From Users
                                          
                                        LEFT JOIN People
                                        ON Users.PersonID = People.PersonID; ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR FROM clsUserData.IsUserExists(Username):" +
                    $" *****************{e.Message}*****************");
                clsDataAccessSettings.LogErrorsAndExceptionToWindowsLogs(e.Message);
            }
            return dt;
        }
        public static int AddNew (int PersonID , string Username, string Password, int Permissions)
        {
            int UserID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"INSERT INTO Users (PersonId, Username, Password, Permissions)
                                          values(@PersonID, @Username, @Password, @Permissions)  

                                        select Scope_Identity()";

                    using (SqlCommand command = new SqlCommand (query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@Password", Password);
                        command.Parameters.AddWithValue("@Permissions", Permissions);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                            UserID = InsertedID;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR FROM clsUserData.AddNew:" +
                    $" *****************{e.Message}*****************");
                clsDataAccessSettings.LogErrorsAndExceptionToWindowsLogs(e.Message);
            }

            return UserID;
        }
        public static bool Update (int UserID, string Username, string Password, int Permissions)
        {
            bool IsUpdated = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"Update Users SET

                                                Username = @Username,
                                                Password = @Password,
                                                Permissions = @Permissions
                                           
                                    Where UserID = @UserID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@Password", Password);
                        command.Parameters.AddWithValue("@Permissions", Permissions);

                        int AffectedRows = command.ExecuteNonQuery();

                        if (AffectedRows > 0)
                            IsUpdated = true;
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR FROM clsUserData.Update:" +
                    $" *****************{e.Message}*****************");
                clsDataAccessSettings.LogErrorsAndExceptionToWindowsLogs(e.Message);
            }
            return IsUpdated;
        }

        

    }
}
