using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Gym_DataAccess;
using System.Security.Policy;

namespace Gym_Business
{

    
    
    public class clsPerson
    {


        private enum enMode { AddNew = 1, Update = 2 };

        private enMode _Mode = enMode.AddNew;
        public int PersonID { get; set; }
        public string IDCardNumber { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        private string _ImagePath;
        public string ImagePath
        {
            get { return _ImagePath; }
            set { _ImagePath = value; }
        }




        public clsPerson()
        {
            this.PersonID = -1;
            this.IDCardNumber = "";
            this.FirstName = "";
            this.MiddleName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Gender = -1;
            this.Email = "";
            this.Phone = "";
            this.Address = "";
            this.ImagePath = "";
            _Mode = enMode.AddNew;
        }
        private clsPerson(int PersonID,  string IDCardNumber,  string FirstName,  string MiddleName,  string LastName,
                                   DateTime DateOfBirth, int  Gender,  string Phone,
                                   string Address,  string Email,  string ImagePath)
        {
            this.PersonID = PersonID;
            this.IDCardNumber = IDCardNumber;
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Email = Email;
            this.Phone = Phone;
            this.Address = Address;
            this.ImagePath = ImagePath;
            _Mode = enMode.Update;
        }

        private bool _AddNewPerson ()
        {

            this.PersonID = clsPersonData.AddNewPerson(
                this.IDCardNumber, this.FirstName, this.MiddleName,
                this.LastName, this.DateOfBirth, this.Gender, this.Phone,
                this.Address, this.Email, this.ImagePath);

            return
                this.PersonID !=  -1;

        }
        private bool _UpdatePerson ()
        {
            return (clsPersonData.UpdatePerson(this.PersonID, this.IDCardNumber, this.FirstName, this.MiddleName,
                this.LastName, this.DateOfBirth, this.Gender, this.Phone,
                this.Address, this.Email, this.ImagePath));

        }

        public static clsPerson FindByID (int PersonID)
        {
            string IDCardNumber = "", FirstName = "", MiddleName = "", LastName = "", Email = "",
                Phone = "",Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            int Gender = -1;

            if (clsPersonData.FindByID(PersonID, ref IDCardNumber, ref FirstName, ref MiddleName, ref LastName,
                ref DateOfBirth, ref Gender, ref Phone, ref Address, ref Email, ref ImagePath))
            {
                return new clsPerson(PersonID, IDCardNumber, FirstName, MiddleName, LastName,
                DateOfBirth, Gender, Phone, Address, Email, ImagePath);
            }
            else
                return null;
        }
        public static clsPerson FindByIDCardNumber(string IDCardNumber )
        {
            string FirstName = "", MiddleName = "", LastName = "", Email = "",
                Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            int Gender = -1, PersonID = -1;

            if (clsPersonData.FindByIDCardNumber(IDCardNumber, ref PersonID, ref FirstName, ref MiddleName, ref LastName,
                ref DateOfBirth, ref Gender, ref Phone, ref Address, ref Email, ref ImagePath))
            {
                return new clsPerson(PersonID, IDCardNumber, FirstName, MiddleName, LastName,
                DateOfBirth, Gender, Phone, Address, Email, ImagePath);
            }
            else
                return null;
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:

                    if (_AddNewPerson())
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
        public static bool DeletePerson(int PersonID)
        {
            return clsPersonData.DeletePerson(PersonID);
        }
        public static bool IsPersonExists (int PersonId)
        {
            return clsPersonData.IsPersonExists(PersonId);
        }
        public static bool IsPersonExists(string IdCardNumber)
        {
            return clsPersonData.IsPersonExists(IdCardNumber);
        }



    }
}
