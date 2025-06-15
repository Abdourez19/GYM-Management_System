using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gym_DataAccess;

namespace Gym_Business
{
    public class clsPlan
    {

        public int PlanID { get; set; }
        public int PlanDuration { get; set; }
        public string PlanDescription { get; set; }
        public string AdditionalNotes { get; set; }

        public clsPlan()
        {
            this.PlanID = -1;
            this.PlanDuration = -1;
            this.PlanDescription = "";
            this.AdditionalNotes = "";
        }
        private clsPlan(int PlanID, int PlanDuration, string PlanDescription, string AdditionalNotes)
        {
            this.PlanID = PlanID;
            this.PlanDuration = PlanDuration;
            this.PlanDescription = PlanDescription;
            this.AdditionalNotes = AdditionalNotes;
        }




        public static int GetPlansCountNumber()
        {
            return clsPlanData.GetMemberShipPlansCount();
        }

        public static clsPlan  FindPlanInfoByID (int PlanID)
        {
            int PlanDuration = -1;
            string PlanDescription = "", AdditionalNotes = "";

            if (clsPlanData.FindPlanByID(PlanID, ref PlanDuration, ref PlanDescription, ref AdditionalNotes))
            {
                return new clsPlan(PlanID, PlanDuration, PlanDescription, AdditionalNotes);
            }
            else
                return null;


        }

        public static DataTable GetPlansList()
        {
            return clsPlanData.GetPlansList();
        }

        public static clsPlan GetPlanByDuration(int PlanDuration)
        {
            int PlanId = -1;
            string PlanDescription = "", AdditionalNotes = "";

            if( (clsPlanData.GetPlanByDuration(PlanDuration, ref PlanId,
                                ref PlanDescription, ref AdditionalNotes)))
            {
                return new clsPlan(PlanId, PlanDuration, PlanDescription, AdditionalNotes);
            }
            else
                return null;

        }



    }
}
