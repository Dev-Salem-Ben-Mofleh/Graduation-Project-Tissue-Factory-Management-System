using System;
using System.Data;
using InstituteDataAccess ;

namespace InstituteBussiness 
{
    public class clsExpense
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


        public int? ExpenseID{ get; set; }
           public decimal Amount{ get; set; }
            public int? BoxMovementID{ get; set; }
        public clsBoxMovement boxMovementInfo;
            public string Description{ get; set; }
            public DateTime ExpenseDate{ get; set; }
            public int? TypesOfExpenseID{ get; set; }
        public clsTypesOfExpense typesOfExpenseInfo;
            public int? UserID{ get; set; }
        public clsExpense()
        {
            this.ExpenseID = null;
            this.Amount= -1M;;
            this.BoxMovementID = null;
            this.Description= string.Empty;;
            this.ExpenseDate= DateTime.Now;;
            this.TypesOfExpenseID = null;
            this.UserID = null;
             Mode = enMode.AddNew;
        }

        public clsExpense(int? ExpenseID,decimal Amount,int? BoxMovementID,string Description,DateTime ExpenseDate,int? TypesOfExpenseID,int? UserID)
        {
            this.ExpenseID = ExpenseID;
            this.Amount = Amount;
            this.BoxMovementID = BoxMovementID;
            boxMovementInfo = clsBoxMovement.Find(BoxMovementID);
            this.Description = Description;
            this.ExpenseDate = ExpenseDate;
            this.TypesOfExpenseID = TypesOfExpenseID;
            typesOfExpenseInfo = clsTypesOfExpense.Find(TypesOfExpenseID);

            this.UserID = UserID;
            Mode = enMode.Update;
        }

        private bool _AddNewExpense()
        {
            this.ExpenseID = clsExpenseData.AddNewExpense(this.Amount,this.BoxMovementID,this.Description,this.ExpenseDate,this.TypesOfExpenseID,this.UserID);

            return (this.ExpenseID.HasValue);
        }

        private bool _UpdateExpense()
        {
            return clsExpenseData.UpdateExpense(this.ExpenseID,this.Amount,this.BoxMovementID,this.Description,this.ExpenseDate,this.TypesOfExpenseID,this.UserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewExpense())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateExpense();
            }

            return false;
        }

        public static clsExpense Find(int? ExpenseID)
        {
            decimal Amount= -1M;;
            int? BoxMovementID= null;
            string Description= string.Empty;;
            DateTime ExpenseDate= DateTime.Now;;
            int? TypesOfExpenseID= null;
            int? UserID= null;
            bool IsFound = clsExpenseData.GetExpenseInfoByID(ExpenseID,ref Amount,ref BoxMovementID,ref Description,ref ExpenseDate,ref TypesOfExpenseID,ref UserID);

            if (IsFound)
            {
                return new clsExpense(ExpenseID,Amount,BoxMovementID,Description,ExpenseDate,TypesOfExpenseID,UserID);
            }
            else
            {
                return null;
            }
        }

        public static bool DeleteExpense(int? ExpenseID)
        {
            return clsExpenseData.DeleteExpense(ExpenseID);
        }

    
        public static bool DoesExpenseExist(int? ExpenseID)
        {
            return clsExpenseData.DoesExpenseExist(ExpenseID);
        }

        public static DataTable GetAllExpenses()
        {
            return clsExpenseData.GetAllExpenses();
        }


        public static DataTable GetReports(string Culomn, DateTime ValueSearch)
        {
            return clsExpenseData.GetReports(Culomn, ValueSearch);
        }

    }
}
