using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;

namespace Gym_DataAccess
{
    public  class clsPersonData
    {

        public static bool FindByID (int PersonID,ref string IDCardNumber, ref string FirstName, ref string MiddleName, ref string LastName,
                                  ref DateTime DateOfBirth, ref int Gender, ref string Phone,ref string Address, ref string Email,ref string ImagePath)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"select * from People where PersonID = @PersonID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("PersonID", PersonID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                //IsFound = true;
                                IDCardNumber = (string)reader["IDCardNumber"];
                                FirstName = (string)reader["FirstName"];

                                if (reader["MiddleName"] != DBNull.Value)
                                    MiddleName = (string)reader["MiddleName"];
                                else
                                    MiddleName = "";

                                LastName = (string)reader["LastName"];
                                DateOfBirth = (DateTime)reader["DAteOfBirth"];
                                Gender = (int)reader["Gender"];
                                Phone = (string)reader["Phone"];
                                Email = (string)reader["Email"];

                                if (reader["Address"] != DBNull.Value)
                                    Address = (string)reader["Address"];
                                else
                                    Address = "";

                                if (reader["ImagePath"] != DBNull.Value)
                                    ImagePath = (string)reader["ImagePath"];
                                else
                                    ImagePath = "";

                                IsFound =  true;
                            }
                        }
                    }
                }


            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR FROM clsPeopleData.FindByID:" +
                    $" ***************** {e.Message} *****************");
                //IsFound = false;
                clsDataAccessSettings.LogErrorsAndExceptionToWindowsLogs(e.Message);
            }
            return IsFound;
        }


        public static bool FindByIDCardNumber (string IDCardNumber ,ref int PersonID, ref string FirstName, ref string MiddleName, ref string LastName,
                                  ref DateTime DateOfBirth, ref int Gender, ref string Phone,ref string Address, ref string Email,ref string ImagePath)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"select * from People where IDCardNumber = @IDCardNumber";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("IDCardNumber", IDCardNumber);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                PersonID = (int)reader["PersonID"];
                                FirstName = (string)reader["FirstName"];

                                if (reader["MiddleName"] != DBNull.Value)
                                    MiddleName = (string)reader["MiddleName"];
                                else
                                    MiddleName = "";

                                LastName = (string)reader["LastName"];
                                DateOfBirth = (DateTime)reader["DAteOfBirth"];
                                Gender = (int)reader["Gender"];
                                Phone = (string)reader["Phone"];
                                Email = (string)reader["Email"];

                                if (reader["Address"] != DBNull.Value)
                                    Address = (string)reader["Address"];
                                else
                                    Address = "";

                                if (reader["ImagePath"] != DBNull.Value)
                                    ImagePath = (string)reader["ImagePath"];
                                else
                                    ImagePath = "";

                                IsFound =  true;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR FROM clsPeopleData.FindByIDCardNumber" +
                    $"************************{e.Message} *************************");
                clsDataAccessSettings.LogErrorsAndExceptionToWindowsLogs(e.Message);
            }
            return IsFound;
        }


        public static int AddNewPerson (string IDCardNumber, string FirstName, string MiddleName, string LastName,
                                   DateTime DateOfBirth, int Gender, string Phone,
                                   string Address, string Email, string ImagePath)
        {
            int PersonID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection (clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string Query = @"INSERT INTO People(IDCardNumber, FirstName,MiddleName,LastName,
                                     DateOfBirth,Gender,Phone,Address,Email,ImagePath )

                                    values (@IDCardNumber, @FirstName,@MiddleName,@LastName,
                                        @DateOfBirth, @Gender,@Phone,@Address, @Email, @ImagePath);
                                    
                                    SELECT SCOPE_IDENTITY()";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {

                        command.Parameters.AddWithValue("@IDCardNumber", IDCardNumber);
                        command.Parameters.AddWithValue("@FirstName", FirstName);

                        if (MiddleName != "")
                            command.Parameters.AddWithValue("@MiddleName", MiddleName);
                        else
                            command.Parameters.AddWithValue("@MiddleName", System.DBNull.Value);

                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        command.Parameters.AddWithValue("@Gender", Gender);
                        command.Parameters.AddWithValue("@Phone", Phone);

                        if (Address != "")
                            command.Parameters.AddWithValue("@Address", Address);
                        else 
                            command.Parameters.AddWithValue("@Address", System.DBNull.Value);


                        command.Parameters.AddWithValue("@Email", Email);

                        if (ImagePath != "")
                            command.Parameters.AddWithValue("@ImagePath", ImagePath);
                        else
                            command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

                        object result = command.ExecuteScalar();

                        if (result!= null && int.TryParse(result.ToString(), out int ID))
                        {
                            PersonID = ID;
                        }
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"ERROR FROM clsPeopleData.AddNewPerson:" +
                    $"*********** {e.Message}************");
                clsDataAccessSettings.LogErrorsAndExceptionToWindowsLogs(e.Message);
            }

            return PersonID;
        }

        public static bool UpdatePerson (int PersonID,string IDCardNumber, string FirstName, string MiddleName, string LastName,
                                   DateTime DateOfBirth, int Gender, string Phone,
                                   string Address, string Email, string ImagePath)
        {
            int RowsAffected = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string Query = @"Update People set 
                                            IDCardNumber = @IDCardNumber, 
                                            FirstName = @FirstName,
                                            MiddleName = @MiddleName,
                                            LastName = @LastName,
                                            DateOfBirth = @DateOfBirth,
                                            Gender = @Gender,
                                            Phone = @Phone,     
                                            Address = @Address, 
                                            Email = @Email,
                                            ImagePath=  @ImagePath
                                    where PersonID = @PersonID ";

                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID",Convert.ToInt32(PersonID));

                        command.Parameters.AddWithValue("@IDCardNumber", IDCardNumber);
                        command.Parameters.AddWithValue("@FirstName", FirstName);

                        if (MiddleName != "")
                            command.Parameters.AddWithValue("@MiddleName", MiddleName);
                        else
                            command.Parameters.AddWithValue("@MiddleName", System.DBNull.Value);

                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        command.Parameters.AddWithValue("@Gender", Gender);
                        command.Parameters.AddWithValue("@Phone", Phone);

                        if (Address != "")
                            command.Parameters.AddWithValue("@Address", Address);
                        else
                            command.Parameters.AddWithValue("@Address", System.DBNull.Value);


                        command.Parameters.AddWithValue("@Email", Email);

                        if (ImagePath != "")
                            command.Parameters.AddWithValue("@ImagePath", ImagePath);
                        else
                            command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);


                        RowsAffected = command.ExecuteNonQuery();

                        return RowsAffected != 0;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR FROM clsPeopleData.UpdatePerson: " +
                    $"*********** {e.Message}************");
                clsDataAccessSettings.LogErrorsAndExceptionToWindowsLogs(e.Message);
                RowsAffected = -1;
            }
            return false;
        }


        public static DataTable GetAllPeople ()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string Query = @"SELECT PersonID, IdCardNumber, FirstName, MiddleName, LastName, DateOfBirth, Gender,
				                                case 
				                                when gender = 0 then 'Male'
				                                when gender = 1 then 'Female'
				                                end as GendorCaption,
				                            Phone, Address, Email, ImagePath
                                    FROM People
                                    ORDER BY FirstName";

                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                                dt.Load(reader);
                        }
                        
                    }

                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"ERROR FROM clsPeopleData.GetAllPeople:" +
                    $"*****************{e.Message} ************************");
                clsDataAccessSettings.LogErrorsAndExceptionToWindowsLogs(e.Message);
            }
            return dt;
        }

        public static bool IsPersonExists(int PersonID)
        {
            //bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"select Found = 1 FROM People where personID = @PersonID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("PersonID", PersonID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                return true;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR FROM clsPeopleData.IsPersonExists(int PersonID):" +
                    $" ********************{e.Message} ****************************");
                clsDataAccessSettings.LogErrorsAndExceptionToWindowsLogs(e.Message);
            }

            return false;
        }

        public static bool IsPersonExists(string IDCardNumber)
        {
            //bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"select Found = 1 FROM People where IDCardNumber = @IDCardNumber";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("IDCardNumber", IDCardNumber);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                return true;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR FROM clsPeopleData.IsPersonExists(string IDCardNumber):" +
                    $" ********************{e.Message} ****************************");
                clsDataAccessSettings.LogErrorsAndExceptionToWindowsLogs(e.Message);
            }

            return false;
        }

        public static bool DeletePerson(int PersonID)
        {
            int RowsAffected = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"Delete From People Where PersonID = @PersonID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("PersonID", PersonID);

                        RowsAffected = command.ExecuteNonQuery();
                        return
                            RowsAffected > 0;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR FROM clsPeopleData.DeletePerson:" +
                    $" *****************{e.Message}*****************");
                clsDataAccessSettings.LogErrorsAndExceptionToWindowsLogs(e.Message);
            }
            return false;
        }



    }
}
