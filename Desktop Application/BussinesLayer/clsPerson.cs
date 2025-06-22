using System;
using System.Data;
using BussinesLayer;
using InstituteDataAccess ;

namespace InstituteBussiness 
{
    public class clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


           public int? PersonID{ get; set; }
           public string Email{ get; set; }
           public int? Location{ get; set; }
           public  clsLocation locationInfo;
           public string Name{ get; set; }
           public string PhoneNumber{ get; set; }
           public int? TypeName { get; set; }


        public clsPerson()
        {
        this.PersonID = null;
        this.Email = "";
        this.Location = null;
        this.Name= string.Empty;
        this.PhoneNumber = string.Empty;
        this.TypeName = null;
            Mode = enMode.AddNew;
        }

        public clsPerson(int? PersonID,string Email,int? Location,string Name, string PhoneNumber,int? TypeName)
        {
            this.PersonID = PersonID;
            this.Email = Email;
            this.Location = Location;
            locationInfo = clsLocation.Find(this.Location);
            this.Name = Name;
            this.PhoneNumber = PhoneNumber;
            this.TypeName = TypeName;
            Mode = enMode.Update;
        }

        private bool _AddNewPerson()
        {
            this.PersonID = clsPersonData.AddNewPerson(this.Email,this.Location,this.Name,this.PhoneNumber,this.TypeName);

            return (this.PersonID.HasValue);
        }

        private bool _UpdatePerson()
        {
            return clsPersonData.UpdatePerson(this.PersonID,this.Email,this.Location,this.Name,this.PhoneNumber, this.TypeName);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdatePerson();
            }

            return false;
        }

        public static clsPerson Find(int? PersonID)
        {
            string Email= "";
            int? Location= null;
            string Name= string.Empty;;
            string PhoneNumber= string.Empty;
            int? TypeName = null;
            bool IsFound = clsPersonData.GetPersonInfoByID(PersonID,ref Email,ref Location,ref Name,ref PhoneNumber,ref TypeName);

            if (IsFound)
            {
                return new clsPerson(PersonID,Email,Location,Name,PhoneNumber, TypeName);
            }
            else
            {
                return null;
            }
        }

        public static clsPerson Find(string Name )
        {
            string Email = "";
            int? Location = null;
            int? PersonID = null;
            string PhoneNumber = string.Empty;
            int? TypeName = null;
            bool IsFound = clsPersonData.GetPersonInfoByName( Name, ref PersonID, ref Email, ref Location,  ref PhoneNumber, ref TypeName);

            if (IsFound)
            {
                return new clsPerson(PersonID, Email, Location, Name, PhoneNumber, TypeName);
            }
            else
            {
                return null;
            }
        }

        public static bool DeletePerson(int? PersonID)
        {
            return clsPersonData.DeletePerson(PersonID);
        }

    
        public static bool DoesPersonExist(int? PersonID)
        {
            return clsPersonData.DoesPersonExist(PersonID);
        }

        public static DataTable GetAllPersons()
        {
            return clsPersonData.GetAllPersons();
        }
        public static DataTable GetAllClients()
        {
            return clsPersonData.GetAllClients();
        }
        public static DataTable GetAllSlipers()
        {
            return clsPersonData.GetAllSlipers();
        }

        public static DataTable GetAllAccoun(int? PersonID)
        {
            return clsPersonData.GetAll(PersonID);
        }
        public static DataTable GetAllSippers(int? PersonID)
        {
            return clsPersonData.GetAlllippers(PersonID);
        }
    }
}
