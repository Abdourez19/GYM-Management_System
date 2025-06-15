using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Gym_DataAccess;
using System.Data.SqlTypes;


namespace Gym_Business
{
    public class clsUser
    {

        enum enMode { AddNew = 0, Update = 1}

        private enMode _Mode;
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Permissions { get; set; }

        private clsPerson _Person;


        public clsUser()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.Username = "";
            this.Password = "";
            this.Permissions = 0;
            this._Person = new clsPerson();
            this._Mode = enMode.AddNew;

        }
        public clsUser (int UserID,int PersonID, string Username, string Password, int Permissions)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.Username = Username;
            this.Password = Password;
            this.Permissions = Permissions;
            _Person = clsPerson.FindByID(PersonID);
            _Mode = enMode.Update;
        }


        private bool _AddNew()
        {
            this.UserID = clsUserData.AddNew(this.PersonID, this.Username, 
                                this.Password, this.Permissions);
            return this.UserID != -1;
        }
        private bool _Update ()
        {
            return clsUserData.Update(this.UserID,this.Username, this.Password, this.Permissions);
        }



        public static clsUser Find (int UserID)
        {
            int PersonID = -1, Permissions = 0;
            string Username = "", Password = "";

            if (clsUserData.Find(UserID, ref PersonID, ref Username, ref Password, ref Permissions))
                return new clsUser(UserID, PersonID, Username, Password, Permissions);

            return null;
        }
        public static clsUser Find(string Username,string Password)
        {
            int UserID = -1, PersonID = -1, Permissions = 0;

            if (clsUserData.Find( Username, Password,ref UserID, ref PersonID, ref Permissions))
                return new clsUser( UserID, PersonID , Username, Password , Permissions);

            return null;
        }
        public static bool IsExists (string Username)
        {
            return clsUserData.IsUserExists(Username);
        }
        public static bool Delete(int UserID)
        {
            return clsUserData.DeleteUser(UserID);
        }
        public static DataTable UsersList ()
        {
            return clsUserData.GetUsersLIst();
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNew())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return
                        false;

                case enMode.Update:
                    return _Update();
            }

            return false;
        }





    }
}
