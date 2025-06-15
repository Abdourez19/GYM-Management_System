using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_DataAccess
{
    public class clsPlanData
    {
        public static int GetMemberShipPlansCount()
        {
            int TotalMembershipPlans = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT COUNT(Plans.planID) from Plans";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int TotalPlans))
                            TotalMembershipPlans = TotalPlans;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: FROM clsMemberData.GetMemberShipPlansCount:" +
                    $"********************{e.Message} *************************");
            }

            return TotalMembershipPlans;
        }

        public static bool FindPlanByID (int PlanID, ref int PlanDuration, ref string PlanDescription, 
                                            ref string AdditionalNotes)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection (clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"select * from plans where PlanID = @PlanID";

                    using (SqlCommand command = new SqlCommand (query, connection))
                    {
                        command.Parameters.AddWithValue("PlanID", PlanID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                PlanDuration = Convert.ToInt32( reader["PlanDuration"]);
                                PlanDescription = (string)reader["PlanDescription"];

                                if (reader["AdditionalNotes"] == DBNull.Value)
                                    AdditionalNotes = "";
                                else
                                    AdditionalNotes = (string)reader["AdditionalNotes"];
                                IsFound = true;

                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR FROM clsPlansData.FindPlanByID:" +
                    $" ***************** {e.Message} *****************");
            }
            return IsFound;
        }

        public static DataTable GetPlansList()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"select * from plans Order By PlanDuration";

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
                Console.WriteLine($"ERROR FROM clsPlansData.GetPlansList:" +
                    $" ***************** {e.Message} *****************");
            }
            return dt;
        }

        public static bool GetPlanByDuration (int PlanDuration , ref int PlanID, ref string PlanDescription,
                                            ref string AdditionalNotes)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"select * from plans where PlanDuration = @PlanDuration";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("PlanDuration", PlanDuration);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                PlanID = Convert.ToInt32(reader["PlanID"]);
                                PlanDescription = (string)reader["PlanDescription"];

                                if (reader["AdditionalNotes"] == DBNull.Value)
                                    AdditionalNotes = "";
                                else
                                    AdditionalNotes = (string)reader["AdditionalNotes"];
                                IsFound = true;

                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR FROM clsPlansData.GetPlanByDuration:" +
                    $" ***************** {e.Message} *****************");
            }
            return IsFound;
        }










    }
}
