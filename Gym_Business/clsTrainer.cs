using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Gym_DataAccess;

namespace Gym_Business
{
    public class clsTrainer
    {
        enum enMode { AddNew = 0, Update = 1};
        private enMode _Mode;
        public int TrainerID { get; set; }
        public int PersonID { get; set; }
        public short Rate { get; set; }
        public string Specialty { get; set; }
        public double Salary { get; set; }
        public clsPerson Person{ get; set; }


        public clsTrainer ()
        {
            this.TrainerID = -1;
            this.PersonID = -1;
            this.Rate = -1;
            this.Specialty = "";
            this.Salary = -1;
            this.Person = null;
            this._Mode = enMode.AddNew;
        }
        private clsTrainer(int TrainerID, int PersonID,short Rate, string Specialty,double Salary)
        {
            this.TrainerID = TrainerID;
            this.PersonID = PersonID;
            this.Rate = Rate;
            this.Specialty = Specialty;
            this.Salary = Salary;
            this.Person = clsPerson.FindByID(PersonID);
            this._Mode = enMode.Update;
        }


        private bool _AddNewTrainer ()
        {

            this.TrainerID = clsTrainerData.AddNewTrainer(this.PersonID, this.Rate, this.Specialty, this.Salary);

            return TrainerID != -1;
           
        }
        private bool _UpdateTrainer ()
        {
            return clsTrainerData.UpdateTrainer(this.TrainerID, this.Rate, this.Specialty, this.Salary);
        }



        public static clsTrainer FindByID(int TrainerID)
        {
            int  PersonID = -1;
            short Rate = -1;
            string Specialty = "";
            double Salary = -1;

            if (clsTrainerData.FindTrainerByID(TrainerID, ref PersonID, ref Rate, ref Specialty, ref Salary))
                return new clsTrainer(TrainerID, PersonID, Rate, Specialty,Salary);
            else
                return null;

        }
        public static DataTable GetTrainersList()
        {
            return clsTrainerData.GetTrainersList();
        }
        public static clsTrainer FindTrainerBySpecialty(string Specialty)
        {
            int TrainerID = -1, PersonID = -1;
            short Rate = -1;
            double Salary = -1;

            if (clsTrainerData.FindTrainerBySpecialty(Specialty, ref TrainerID, ref PersonID, ref Rate,ref Salary))
            {
                return new clsTrainer(TrainerID, PersonID, Rate, Specialty,Salary);
            }
            else
                return null;
        }
        public static bool DeleteTrainer(int TrainerID)
        {
            int personID = clsTrainer.FindByID(TrainerID).PersonID;
            return clsTrainerData.DeleteTrainer(TrainerID) && clsPerson.DeletePerson(personID);
        }
        public bool Save ()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTrainer())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateTrainer();

            }
            return false;
        }








    }
}
