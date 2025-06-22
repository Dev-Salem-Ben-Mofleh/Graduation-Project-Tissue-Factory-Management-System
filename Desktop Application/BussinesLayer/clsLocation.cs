using InstituteDataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BussinesLayer
{
    public class clsLocation
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


        public int? LocationID { get; set; }
        public string LocationName { get; set; }
        public clsLocation()
        {
            this.LocationID = null;
            this.LocationName = string.Empty; ;
            Mode = enMode.AddNew;
        }

        public clsLocation(int? LocationID, string LocationName)
        {
            this.LocationID = LocationID;
            this.LocationName = LocationName;
            Mode = enMode.Update;
        }

        private bool _AddNewLocation()
        {
            this.LocationID = clsDataLocations.AddNewLocation(this.LocationName);

            return (this.LocationID.HasValue);
        }

        private bool _UpdateLocation()
        {
            return clsDataLocations.UpdateLocation(this.LocationID, this.LocationName);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLocation())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateLocation();
            }

            return false;
        }

        public static clsLocation Find(int? LocationID)
        {
            string LocationName = string.Empty; ;
            bool IsFound = clsDataLocations.GetLocationInfoByID(LocationID, ref LocationName);

            if (IsFound)
            {
                return new clsLocation(LocationID, LocationName);
            }
            else
            {
                return null;
            }
        }

        public static bool DeleteLocation(int? LocationID)
        {
            return clsDataLocations.DeleteLocation(LocationID);
        }


        public static bool DoesLocationExist(int? LocationID)
        {
            return clsDataLocations.DoesLocationExist(LocationID);
        }

        public static DataTable GetAllLocations()
        {
            return clsDataLocations.GetAllLocations();
        }

    }
    }
