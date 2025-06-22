using System;
using System.Data;
using InstituteDataAccess ;

namespace InstituteBussiness 
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


            public int? UserID{ get; set; }
            public string Password{ get; set; }
            public int? PersonID{ get; set; }

            public clsPerson PersonInfo;
            public string UserName{ get; set; }
            public bool IsActive { get; set; }


        public clsUser()
        {
            this.UserID = null;
            this.Password= string.Empty;;
            this.PersonID = null;
            PersonInfo = new clsPerson();
            this.UserName= string.Empty;
            this.IsActive = false;
            Mode = enMode.AddNew;
        }

        public clsUser(int? UserID,string Password,int? PersonID,string UserName,bool IsActive)
        {
            this.UserID = UserID;
            this.Password = Password;
            this.PersonID = PersonID;
            PersonInfo=clsPerson.Find(PersonID);
            this.UserName = UserName;
            this.IsActive = IsActive;
            Mode = enMode.Update;
        }

        private bool _AddNewUser()
        {
            this.UserID = clsUserData.AddNewUser(this.Password,this.PersonID,this.UserName, this.IsActive);

            return (this.UserID.HasValue);
        }

        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser(this.UserID,this.Password,this.PersonID,this.UserName, this.IsActive);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateUser();
            }

            return false;
        }

        public static clsUser Find(int? UserID)
        {
            string Password= string.Empty;
            int? PersonID= null;
            string UserName= string.Empty;
            bool IsActive=false;
            bool IsFound = clsUserData.GetUserInfoByID(UserID,ref Password,ref PersonID,ref UserName, ref IsActive);

            if (IsFound)
            {
                return new clsUser(UserID,Password,PersonID,UserName, IsActive);
            }
            else
            {
                return null;
            }
        }

        public static clsUser FindByUsernameAndPassword(string UserName,string Password)
        {
            int? PersonID = null;
            int? UserID = null;
            bool IsActive = false;
            bool IsFound = clsUserData.GetUserForLogin( UserName, Password, ref UserID,  ref PersonID,  ref IsActive);

            if (IsFound)
            {
                return new clsUser(UserID, Password, PersonID, UserName, IsActive);
            }
            else
            {
                return null;
            }
        }

        public static bool DeleteUser(int? UserID)
        {
            return clsUserData.DeleteUser(UserID);
        }

    
        public static bool DoesUserExist(int? UserID)
        {
            return clsUserData.DoesUserExist(UserID);
        }
        public static bool DoesUserExist(string UserName)
        {
            return clsUserData.DoesUserExist(UserName);
        }

        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }


    }
}
