using System;
using System.Data;
using InstituteDataAccess ;

namespace InstituteBussiness 
{
    public class clsElectricite
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


        public int? ElectrictyID{ get; set; }
           public DateTime date{ get; set; }
            public int? Quantity{ get; set; }
            public decimal Total{ get; set; }
            public string TypeOf{ get; set; }
            public int? UintPrice{ get; set; }
            public int? UserID { get; set; }
        public clsUser User;

        public int? BoxMovementID { get; set; }
        public clsBoxMovement boxMovement;


        public clsElectricite()
        {
            this.ElectrictyID = null;
        this.date= DateTime.Now;;
        this.Quantity = null;
        this.Total= -1M;;
        this.TypeOf= string.Empty;;
        this.UintPrice = null;
            this.UserID = null;

            Mode = enMode.AddNew;
        }

        public clsElectricite(int? ElectrictyID,DateTime date,int? Quantity,decimal Total,string TypeOf,int? UintPrice,int? UserID,int? BoxMovementID)
        {
            this.ElectrictyID = ElectrictyID;
            this.date = date;
            this.Quantity = Quantity;
            this.Total = Total;
            this.TypeOf = TypeOf;
            this.UintPrice = UintPrice;
            this.UserID = UserID;
            User = clsUser.Find(UserID);
            this.BoxMovementID = BoxMovementID;
            boxMovement = clsBoxMovement.Find(BoxMovementID);
            Mode = enMode.Update;
        }

        private bool _AddNewElectricite()
        {
            this.ElectrictyID = clsElectriciteData.AddNewElectricite(this.date,this.Quantity,this.Total,this.TypeOf,this.UintPrice, this.UserID, this.BoxMovementID);

            return (this.ElectrictyID.HasValue);
        }

        private bool _UpdateElectricite()
        {
            return clsElectriciteData.UpdateElectricite(this.ElectrictyID,this.date,this.Quantity,this.Total,this.TypeOf,this.UintPrice, this.UserID, this.BoxMovementID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewElectricite())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateElectricite();
            }

            return false;
        }

        public static clsElectricite Find(int? ElectrictyID)
        {
            DateTime date= DateTime.Now;;
            int? Quantity= null;
            decimal Total= -1M;;
            string TypeOf= string.Empty;;
            int? UintPrice= null;
            int? UserID = null;
            int? BoxMovementID = null;


            bool IsFound = clsElectriciteData.GetElectriciteInfoByID(ElectrictyID,ref date,ref Quantity,ref Total,ref TypeOf,ref UintPrice, ref UserID,ref BoxMovementID);

            if (IsFound)
            {
                return new clsElectricite(ElectrictyID,date,Quantity,Total,TypeOf,UintPrice, UserID, BoxMovementID);
            }
            else
            {
                return null;
            }
        }

        public static bool DeleteElectricite(int? ElectrictyID)
        {
            return clsElectriciteData.DeleteElectricite(ElectrictyID);
        }

    
        public static bool DoesElectriciteExist(int? ElectrictyID)
        {
            return clsElectriciteData.DoesElectriciteExist(ElectrictyID);
        }

        public static DataTable GetAllElectricites()
        {
            return clsElectriciteData.GetAllElectricites();
        }

        public static DataTable GetReports(string Culomn, DateTime ValueSearch)
        {
            return clsElectriciteData.GetReports(Culomn, ValueSearch);
        }

    }
}
