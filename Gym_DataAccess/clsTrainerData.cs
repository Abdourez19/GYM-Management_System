using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Gym_DataAccess
{
    public class clsTrainerData
    {
        public static bool FindTrainerByID(int TrainerID, ref int PersonID, ref short Rate, ref string Specialty , ref double Salary)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT * from Trainers 
                                    WHERE TrainerID = @TrainerID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TrainerID", TrainerID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                PersonID = Convert.ToInt32(reader["PersonID"]);
                                Rate = Convert.ToInt16(reader["Rate"]);
                                Specialty = (string)reader["Specialty"];
                                Salary = Convert.ToDouble(reader["Salary"]);
                                IsFound = true;
                            }
                        }
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR FROM clsTrainer.FindTrainerByID:" +
                    $" ***************** {e.Message} *****************");
            }
            return IsFound;
        }

        public static bool FindTrainerByFirstName(string FirstName,ref int TrainerID, ref int PersonID, ref short Rate, ref double Salary,
                                            ref string Specialty,ref string MiddleName, ref string LastName,
                                        ref DateTime DateOfBirth, ref string Gender, ref string Phone, ref string Email)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT Trainers.TrainerID,Trainers.Rate,Trainers.Specialty , People.FirstName, 
				                        People.MiddleName, People.LastName,People.DateOfBirth,
				                        case People.Gender
				                            when 0 then 'Male'
				                            when 1 then 'Female'
				                        end as Gender ,People.Phone,People.Email fROM Trainers
                                    LEFT JOIN People
                                    ON Trainers.PersonID = People.PersonID 
                                    WHERE FirstName = @FirstName";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", FirstName);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                TrainerID = Convert.ToInt32(reader["TrainerID"]);
                                PersonID = Convert.ToInt32(reader["PersonID"]);
                                Rate = Convert.ToInt16(reader["Rate"]);
                                Specialty = (string)reader["Specialty"];
                                Salary = Convert.ToDouble(reader["Salary"]);
                                MiddleName = (string)reader["MiddleName"];
                                LastName = (string)reader["LastName"];
                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                Gender = (string)reader["Gender"];
                                Phone = (string)reader["Phone"];
                                Email = (string)reader["Email"];
                                IsFound = true;
                            }
                        }
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR FROM clsTrainer.FindTrainerByID:" +
                    $" ***************** {e.Message} *****************");
            }
            return IsFound;
        }

        public static bool FindTrainerBySpecialty(string Specialty ,ref int TrainerID, ref int PersonID, ref short Rate,ref double Salary)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT * from Trainers 
                                    WHERE Specialty = @Specialty";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Specialty", Specialty);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                PersonID = Convert.ToInt32(reader["PersonID"]);
                                Rate = Convert.ToInt16(reader["Rate"]);
                                TrainerID =Convert.ToInt32( reader["TrainerID"]);
                                Salary = Convert.ToDouble(reader["Salary"]);
                                IsFound = true;
                            }
                        }
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR FROM clsTrainer.FindTrainerBySpecialty:" +
                    $" ***************** {e.Message} *****************");
            }
            return IsFound;
        }
        public static DataTable GetTrainersList()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"select Trainers.TrainerID, People.FirstName, People.LastName,Trainers.Specialty,
                                    Trainers.Rate, People.Phone, People.Email,
                                    	case (People.Gender)
                                    	    when 0 then 'Male'
                                    	    when 1 then 'Female'
                                    	END AS Gendor,
                                    people.ImagePath From Trainers
                                    
                                    LEFT JOIN People
                                    ON Trainers.PersonID = People.PersonID;";

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
                Console.WriteLine($"ERROR FROM clsTrainerData.GetTrainersList:" +
                    $" ***************** {e.Message} *****************");
            }
            return dt;
        }
        public static bool DeleteTrainer (int TrainerID)
        {
            int AffectedRows = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    connection.Open();
                    string query = @"Delete From Trainers Where TrainerID = @TrainerID";

                    using (SqlCommand command = new SqlCommand (query, connection))
                    {

                        command.Parameters.AddWithValue("TrainerID", TrainerID);
                        AffectedRows = command.ExecuteNonQuery();

                        return AffectedRows > 0;
                    }
                }


            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR FROM clsTrainerData.DeleteTrainer:" +
                    $" ***************** {e.Message} *****************");
            }

            return false;
        }
        public static int AddNewTrainer(int PersonID, short Rate, string Specialty, double Salary)
        {
            int TrainerID = -1;

            try
            {

                using (SqlConnection connection = new SqlConnection (clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Trainers ( PersonID, Rate ,Specialty, Salary)
                                           values (@PersonID, @Rate, @Specialty, @Salary)

                                           Select Scope_Identity()";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@Rate", Rate);
                        command.Parameters.AddWithValue("@Specialty", Specialty);
                        command.Parameters.AddWithValue("@Salary", Salary);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int ID))
                            TrainerID = ID;
                    }
                }


            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR FROM clsTrainerData.AddNewTrainer:" +
                   $" ***************** {e.Message} *****************");
            }
            return TrainerID;
        }
        public static bool UpdateTrainer(int TrainerID, short Rate, string Specialty, double Salary)
        {
            bool IsUpdated  = false;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"Update Trainers SET
                                                Rate = @Rate,
                                                Specialty = @Specialty,
                                                Salary = @Salary
                                           
                                    Where TrainerID = @TrainerID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TrainerID", TrainerID);
                        command.Parameters.AddWithValue("@Rate", Rate);
                        command.Parameters.AddWithValue("@Specialty", Specialty);
                        command.Parameters.AddWithValue("@Salary", Salary);

                        int AffectedRows = command.ExecuteNonQuery();

                        if (AffectedRows > 0)
                            IsUpdated = true;
                    }
                }


            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR FROM clsTrainerData.UpdateTrainer:" +
                   $" ***************** {e.Message} *****************");
            }
            return IsUpdated;
        }






    }
}
