using System;
using System.Data;
using InstituteDataAccess ;

namespace InstituteBussiness 
{
    public class clsBoxMovement
    {
        public enum enMode { AddNew = 0, Update = 1 };
        
        public enMode Mode = enMode.AddNew;


        public int? BoxMovementID{ get; set; }
           public decimal Amount{ get; set; }
public int? BoxID{ get; set; }
public DateTime BoxMovementDate{ get; set; }
public string Description{ get; set; }
public int? MovementType{ get; set; }
public int? UserID{ get; set; }

        
        
        public clsBoxMovement()
        {
        this.BoxMovementID = null;
        this.Amount= -1M;;
        this.BoxID = null;
        this.BoxMovementDate= DateTime.Now;;
        this.Description= string.Empty;;
        this.MovementType = null;
        this.UserID = null;
             Mode = enMode.AddNew;
        }

        public clsBoxMovement(int? BoxMovementID,decimal Amount,int? BoxID,DateTime BoxMovementDate,string Description,int? MovementType,int? UserID)
        {
            this.BoxMovementID = BoxMovementID;
            this.Amount = Amount;
            this.BoxID = BoxID;
            this.BoxMovementDate = BoxMovementDate;
            this.Description = Description;
            this.MovementType = MovementType;
            this.UserID = UserID;
            Mode = enMode.Update;
        }

        private bool _AddNewBoxMovement()
        {
            this.BoxMovementID = clsBoxMovementData.AddNewBoxMovement(this.Amount,this.BoxID,this.BoxMovementDate,this.Description,this.MovementType,this.UserID);

            return (this.BoxMovementID.HasValue);
        }

        private bool _UpdateBoxMovement()
        {
            return clsBoxMovementData.UpdateBoxMovement(this.BoxMovementID,this.Amount,this.BoxID,this.BoxMovementDate,this.Description,this.MovementType,this.UserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewBoxMovement())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateBoxMovement();
            }

            return false;
        }

        public static clsBoxMovement Find(int? BoxMovementID)
        {
            decimal Amount= -1M;;
            int? BoxID= null;
            DateTime BoxMovementDate= DateTime.Now;;
            string Description= string.Empty;;
            int? MovementType= null;
            int? UserID= null;
            bool IsFound = clsBoxMovementData.GetBoxMovementInfoByID(BoxMovementID,ref Amount,ref BoxID,ref BoxMovementDate,ref Description,ref MovementType,ref UserID);

            if (IsFound)
            {
                return new clsBoxMovement(BoxMovementID,Amount,BoxID,BoxMovementDate,Description,MovementType,UserID);
            }
            else
            {
                return null;
            }
        }

        public static bool DeleteBoxMovement(int? BoxMovementID)
        {
            return clsBoxMovementData.DeleteBoxMovement(BoxMovementID);
        }

    
        public static bool DoesBoxMovementExist(int? BoxMovementID)
        {
            return clsBoxMovementData.DoesBoxMovementExist(BoxMovementID);
        }

        public static DataTable GetAllBoxMovements()
        {
            return clsBoxMovementData.GetAllBoxMovements();
        }


    }
}
