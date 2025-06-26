using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.ComponentModel;

namespace Gym_DataAccess
{
    public class clsMemberShipData
    {
        public static bool FindMember (int MemberID, ref int PersonID, ref int PackageID, ref int PlanID, ref int TrainerID,
                                        ref double Amount, ref DateTime SubscriptionDate, ref string AdditionalNotes)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection  = new SqlConnection (clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string Query = @"select * from MemberShip_Plans where MemberID = @MemberID ";

                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("MemberID", MemberID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                PersonID = (int)reader["PersonID"];
                                PackageID = (int)reader["PackageID"];
                                PlanID = (int)reader["PlanID"];

                                if (reader["TrainerID"] != DBNull.Value)
                                    TrainerID = Convert.ToInt32(reader["TrainerID"]);
                                else
                                    TrainerID = -1;


                                Amount = (double)reader["Amount"];
                                SubscriptionDate = (DateTime)reader["SubscriptionDate"];

                                if (reader["AdditionalNotes"] != DBNull.Value)
                                    AdditionalNotes = (string)reader["AdditionalNotes"];
                                else
                                    AdditionalNotes = "";

                                IsFound = true;
                            }
                        }
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"ERROR FROM clsMemberData.FindMember:" +
                    $"********************{e.Message} *************************");
                clsDataAccessSettings.LogErrorsAndExceptionToWindowsLogs(e.Message);
            }
            return IsFound;
        }

        public static bool FindMember(string FirstName,ref int MemberID, ref int PersonID, ref int PackageID, ref int PlanID, ref int TrainerID,
           ref double Amount, ref DateTime SubscriptionDate, ref string AdditionalNotes)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string Query = @"select MemberShip_Plans.*, People.FirstName, People.MiddleName,
                                            People.LastName from MemberShip_Plans
                                    left join  People
                                    ON MemberShip_Plans.FirstName = @FirstName";

                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("FirstName", FirstName);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MemberID = (int)reader["MemberID"];
                                PersonID = (int)reader["PersonID"];
                                PackageID = (int)reader["PackageID"];
                                PlanID = (int)reader["PlanID"];
                                TrainerID = (int)reader["TrainerID"];
                                Amount = (double)reader["Amount"];
                                SubscriptionDate = (DateTime)reader["SubscriptionDate"];
                                AdditionalNotes = (string)reader["AdditionalNotes"];
                                IsFound =  true;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR FROM clsMemberData.FindMember:" +
                    $"********************{e.Message} *************************");
                clsDataAccessSettings.LogErrorsAndExceptionToWindowsLogs(e.Message);
            }
            return IsFound;
        }



        public static int GetActiveMembersCount ()
        {
            int TotalActiveMembers = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT COUNT( MemberShip_Plans.PersonID) from MemberShip_Plans";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int TotalMembers))
                            TotalActiveMembers = TotalMembers;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: FROM clsMemberData.GetActiveMembersCount:" +
                    $"********************{e.Message} *************************");
                clsDataAccessSettings.LogErrorsAndExceptionToWindowsLogs(e.Message);
            }

            return TotalActiveMembers;
        }

        public static DataTable GetMemberShipsList()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string Query = @" SELECT    MemberShip_Plans.MemberID, People.FirstName, People.MiddleName, 
                                                              People.LastName, People.Gender ,
                                                                  case People.Gender
                                        			                    when 0 then 'Male'
                                        			                    when 1 then 'Female'
                                        			                end as Gender_Caption,
                                                              People.Email, People.Phone, Packages.PackageName,
                                        					  Plans.planDuration, Trainers.Specialty
                                        FROM     MemberShip_Plans 
                                        
                                        left JOIN People 
                                        ON MemberShip_Plans.PersonID = People.PersonID
                                        
                                        left JOIN Packages 
                                        ON MemberShip_Plans.PackageID = Packages.PackageID
                                        
                                        left JOIN plans 
                                        ON MemberShip_Plans.PlanID = Plans.planID
                                        
                                        left JOIN Trainers
                                        ON MemberShip_Plans.TrainerID = Trainers.TrainerID

                                    order by People.FirstName";

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
                Console.WriteLine($"ERROR from clsMembersData.GetMemberShipsList: " +
                    $"**********************{e.Message}***********************");
                clsDataAccessSettings.LogErrorsAndExceptionToWindowsLogs(e.Message);
            }
            return dt;
        }

        public static int AddNewMembership( int PersonID, int PackageID, int PlanID, int TrainerID, double Amount
                                        , DateTime SubscriptionDate,  string AdditionalNotes)
        {            
            int AffectedRows = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"insert into MemberShip_Plans(PersonID,PackageID,PlanID,TrainerID,Amount
                                                        ,SubscriptionDate,AdditionalNotes)

                                        values(@PersonID,@PackageID,@PlanID,@TrainerID,@Amount
                                                        ,@SubscriptionDate,@AdditionalNotes);

                                        SELECT SCOPE_IDENTITY()";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@PackageID", PackageID);
                        command.Parameters.AddWithValue("@PlanID", PlanID);
                        if (TrainerID != -1)
                            command.Parameters.AddWithValue("@TrainerID", TrainerID);
                        else
                            command.Parameters.AddWithValue("@TrainerID", System.DBNull.Value);

                        command.Parameters.AddWithValue("@Amount", Amount);
                        command.Parameters.AddWithValue("@SubscriptionDate", SubscriptionDate);

                        if (!string.IsNullOrEmpty(AdditionalNotes))
                            command.Parameters.AddWithValue("@AdditionalNotes", AdditionalNotes);
                        else
                            command.Parameters.AddWithValue("@AdditionalNotes", System.DBNull.Value);

                        object result = command.ExecuteScalar();

                        if (result!= null && int.TryParse(result.ToString(), out int memberID))
                            AffectedRows = memberID;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: FROM clsMemberShipData.AddNewMembership:" +
                    $"********************{e.Message} *************************");
                clsDataAccessSettings.LogErrorsAndExceptionToWindowsLogs(e.Message);
            }

            return AffectedRows;
        }
    
        public static bool UpdateMemberShip (int MemberID, int PackageID, int PlanID, int TrainerID, 
                                double Amount, DateTime SubscriptionDate, string AdditionalNotes)
        {
            bool IsUpdated = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"UPDATE MemberShip_Plans SET
                                        PackageID = @PackageID,
                                        PlanID = @PlanID,
                                        TrainerID = @TrainerID,
                                        Amount = @Amount,
                                        SubscriptionDate = @SubscriptionDate,
                                        AdditionalNotes = @AdditionalNotes
                                    Where MemberID = @MemberID";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MemberID", MemberID);
                        command.Parameters.AddWithValue("@PackageID", PackageID);
                        command.Parameters.AddWithValue("@PlanID", PlanID);
                        if (TrainerID != -1)
                            command.Parameters.AddWithValue("@TrainerID", TrainerID);
                        else
                            command.Parameters.AddWithValue("@TrainerID", System.DBNull.Value);

                        command.Parameters.AddWithValue("@Amount", Amount);
                        command.Parameters.AddWithValue("@SubscriptionDate", SubscriptionDate);

                        if (!string.IsNullOrEmpty(AdditionalNotes))
                            command.Parameters.AddWithValue("@AdditionalNotes", AdditionalNotes);
                        else
                            command.Parameters.AddWithValue("@AdditionalNotes", System.DBNull.Value);

                        int AffectedRows = command.ExecuteNonQuery();

                        if (AffectedRows > 0)
                            IsUpdated = true;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: FROM clsMemberShipData.UpdateMembership:" +
                    $"********************{e.Message} *************************");
                clsDataAccessSettings.LogErrorsAndExceptionToWindowsLogs(e.Message);
            }

            return IsUpdated;
        }

        public static bool DeleteMembership(int MemberID)
        {
            int  AffectedRows = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"delete from MemberShip_Plans where  MemberID = @MemberID";

                    using (SqlCommand command = new SqlCommand (query, connection))
                    {
                        command.Parameters.AddWithValue("@MemberID" , MemberID);

                        AffectedRows = command.ExecuteNonQuery();

                        return AffectedRows > 0;
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: FROM clsMemberShipData.DeleteMembership:" +
                    $"********************{e.Message} *************************");
                clsDataAccessSettings.LogErrorsAndExceptionToWindowsLogs(e.Message);
            }
            return false;
        }

        public static int PersonMembershipsCount( int PersonID)
        {
            int numberOfMemberships = 0;
            
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string Query = @"select TotalMemberShips =  count(MemberShip_Plans.MemberID)  from MemberShip_Plans
                                            where PersonID = @PersonID";

                    using (SqlCommand command = new SqlCommand (Query,connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                numberOfMemberships = Convert.ToInt32(reader["TotalMemberShips"]);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: FROM clsMemberShipData.PersonMembershipsCount:" +
                    $"********************{e.Message} *************************");

                clsDataAccessSettings.LogErrorsAndExceptionToWindowsLogs(e.Message);
            }


            return numberOfMemberships;
        }
    }
}
