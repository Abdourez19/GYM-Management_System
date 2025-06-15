using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gym_DataAccess;
using System.Data;
using System.Runtime.Remoting.Messaging;


namespace Gym_Business
{
    public class clsMemberShip
    {

        enum enMode { AddNew = 1, Update = 2};

        enMode _Mode = enMode.AddNew;

        
        public int MemberID { get; set; }
        public int PersonID { get; set; }
        public int PackageID { get; set; }
        public int PlanID { get; set; }
        public int TrainerID { get; set; }
        public double Amount { get; set; }
        public string AdditionalNotes { get; set; }
        public DateTime SubscriptionDate { get; set; }

        //clsPerson _PersonInfo;


        public clsMemberShip ()
        {
            this.MemberID = -1;
            this.PersonID = -1;
            this.PackageID = -1;
            this.PlanID = -1;
            this.TrainerID = -1;
            this.Amount = -1;
            this.AdditionalNotes = "";
            this.SubscriptionDate = DateTime.Now;

        }
        clsMemberShip(int MemberID, int PersonID,int PackageID,int PlanID, int TrainerID, 
            double Amount,DateTime SubscriptionDate, string AdditionalNotes)
        {
            this.MemberID = MemberID;
            this.PersonID = PersonID;
            this.PackageID = PackageID;
            this.PlanID = PlanID;
            this.TrainerID = TrainerID;
            this.Amount = Amount;
            this.SubscriptionDate = SubscriptionDate;
            this.AdditionalNotes = AdditionalNotes;
            //this.Person = clsPerson.FindByID(PersonID); 

            _Mode = enMode.Update;
        }

        public static clsMemberShip FindMember (int MemberId)
        {
            int PersonID = -1, PackageID = -1, PlanID = -1, TrainerID = -1;
            double Amount = -1;
            DateTime SubscriptionDate = new DateTime();
            string AdditionalNotes = "";

            if (clsMemberShipData.FindMember(MemberId,ref PersonID,ref PackageID,ref  PlanID,ref TrainerID,
                                                ref Amount,ref SubscriptionDate,ref AdditionalNotes))
                return new clsMemberShip(MemberId, PersonID,PackageID,PlanID,TrainerID,Amount,
                    SubscriptionDate,AdditionalNotes);
            else
                return null;
        }
        public static DataTable GetMemberShipsList ()
        {
            return clsMemberShipData.GetMemberShipsList();
        }
        public static int GetActiveMembersCountNumber()
        {
            return clsMemberShipData.GetActiveMembersCount();
                
        }
        private bool _AddNewMember ()
        {
            this.MemberID = clsMemberShipData.AddNewMembership(
                 this.PersonID, this.PackageID, this.PlanID, this.TrainerID, this.Amount,
                     this.SubscriptionDate, this.AdditionalNotes);

            return
                MemberID != -1;
        }
        private bool _UpdatePerson()
        {
            return (clsMemberShipData.UpdateMemberShip(this.MemberID,  this.PackageID,  this.PlanID, this.TrainerID,
                                 this.Amount,  this.SubscriptionDate,  this.AdditionalNotes));

        }
        public bool Save ()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewMember())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;


                case enMode.Update:
                    return _UpdatePerson();
            }
            return false;
        }
        public static bool DeleteMembership(int MemberID)
        {
            clsMemberShip member = FindMember(MemberID);
            int MemberShipsNumberPerPerson = 0;
            

            if (member == null)
                return false;

            MemberShipsNumberPerPerson = clsMemberShipData.PersonMembershipsCount(member.PersonID);

            if (MemberShipsNumberPerPerson > 1)
                return clsMemberShipData.DeleteMembership(MemberID);


            int PersonID = member.PersonID;

            return (clsMemberShipData.DeleteMembership(MemberID) && clsPersonData.DeletePerson(PersonID));
            
        }
        
        


    }
}
