using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Gym_DataAccess;


namespace Gym_Business
{
    public class clsPackage
    {

        enum enMode { AddNew = 0, Update = 1};

        private enMode _Mode;
        public int PackageID { get; set; }
        public string PackageName { get; set; }
        public string PackageDescription { get; set; }
        public double PricePerMonth { get; set; }


        public clsPackage ()
        {
            this.PackageID = -1;
            this.PackageName = "";
            this.PackageDescription = "";
            this.PricePerMonth = -1;
            this._Mode = enMode.AddNew;
        }
        public clsPackage(int PackageID, string PackageName, string PackageDescription,double PackagePrice)
        {
            this.PackageID = PackageID;
            this.PackageName = PackageName;
            this.PackageDescription = PackageDescription;
            this.PricePerMonth = PackagePrice;
            this._Mode = enMode.Update;
        }


        private bool _AddNewPackage ()
        {
            this.PackageID = clsPackageData.AddNewPackage(this.PackageName, this.PackageDescription,
                                                this.PricePerMonth);
            return this.PackageID != -1;
        }
        private bool _UpdatePackage ()
        {
            return clsPackageData.UpdatePackage(this.PackageID, this.PackageName,
                this.PackageDescription, this.PricePerMonth);
        }


        public static int GetPackagesCountNumber ()
        {
            return clsPackageData.GetPackagesCount();
        }
        public static clsPackage FindPackageByID(int PackageID)
        {

            string PackageName = "", packageDescription  = "";
            double PackagePrice = -1;

            if (clsPackageData.FindPackageByID(PackageID, ref PackageName, ref packageDescription, ref PackagePrice))
                return new clsPackage(PackageID, PackageName, packageDescription, PackagePrice);
            else
                return null;


        }
        public static clsPackage FindPackageByName(string PackageName)
        {
            int PackageID = -1;
            string  packageDescription = "";
            double PackagePrice = -1;

            if (clsPackageData.FindPackageByName(PackageName,ref PackageID, ref packageDescription, ref PackagePrice))
                return new clsPackage(PackageID, PackageName, packageDescription, PackagePrice);
            else
                return null;


        }
        public static DataTable GetPackagesList()
        {
            return clsPackageData.GetPackagesList(); 
        }
        public bool Save()
        {
            

            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPackage())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdatePackage();
            }
            return false;
        }
        public static bool Delete(int PackageID)
        {
            return clsPackageData.Delete(PackageID);
        }



    }
}
