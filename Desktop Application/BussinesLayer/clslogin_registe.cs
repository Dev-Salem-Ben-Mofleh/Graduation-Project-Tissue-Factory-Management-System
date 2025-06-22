using System;
using System.Data;
using InstituteDataAccess ;

namespace InstituteBussiness 
{
    public class clslogin_registe
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


        public int? LoginID{ get; set; }
           public DateTime DateLogin{ get; set; }
public int? UserID{ get; set; }
        public clslogin_registe()
        {
            this.LoginID = null;
        this.DateLogin= DateTime.Now;;
this.UserID = null;
             Mode = enMode.AddNew;
        }

        public clslogin_registe(int? LoginID,DateTime DateLogin,int? UserID)
        {
            this.LoginID = LoginID;
            this.DateLogin = DateLogin;
this.UserID = UserID;
            Mode = enMode.Update;
        }

        private bool _AddNewlogin_registe()
        {
            this.LoginID = clslogin_registeData.AddNewlogin_registe(this.DateLogin,this.UserID);

            return (this.LoginID.HasValue);
        }

        private bool _Updatelogin_registe()
        {
            return clslogin_registeData.Updatelogin_registe(this.LoginID,this.DateLogin,this.UserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewlogin_registe())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _Updatelogin_registe();
            }

            return false;
        }

        public static clslogin_registe Find(int? LoginID)
        {
            DateTime DateLogin= DateTime.Now;;
int? UserID= null;
            bool IsFound = clslogin_registeData.Getlogin_registeInfoByID(LoginID,ref DateLogin,ref UserID);

            if (IsFound)
            {
                return new clslogin_registe(LoginID,DateLogin,UserID);
            }
            else
            {
                return null;
            }
        }

        public static bool Deletelogin_registe(int? LoginID)
        {
            return clslogin_registeData.Deletelogin_registe(LoginID);
        }

    
        public static bool Doeslogin_registeExist(int? LoginID)
        {
            return clslogin_registeData.Doeslogin_registeExist(LoginID);
        }

        public static DataTable GetAlllogin_register()
        {
            return clslogin_registeData.GetAlllogin_register();
        }


    }
}
