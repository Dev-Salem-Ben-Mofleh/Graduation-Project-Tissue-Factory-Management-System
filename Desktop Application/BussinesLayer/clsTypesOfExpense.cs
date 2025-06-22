using System;
using System.Data;
using InstituteDataAccess ;

namespace InstituteBussiness 
{
    public class clsTypesOfExpense
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


        public int? TypesOfExpenseID{ get; set; }
           public string Name{ get; set; }
        public clsTypesOfExpense()
        {
            this.TypesOfExpenseID = null;
        this.Name= string.Empty;;
             Mode = enMode.AddNew;
        }

        public clsTypesOfExpense(int? TypesOfExpenseID,string Name)
        {
            this.TypesOfExpenseID = TypesOfExpenseID;
            this.Name = Name;
            Mode = enMode.Update;
        }

        private bool _AddNewTypesOfExpense()
        {
            this.TypesOfExpenseID = clsTypesOfExpenseData.AddNewTypesOfExpense(this.Name);

            return (this.TypesOfExpenseID.HasValue);
        }

        private bool _UpdateTypesOfExpense()
        {
            return clsTypesOfExpenseData.UpdateTypesOfExpense(this.TypesOfExpenseID,this.Name);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTypesOfExpense())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateTypesOfExpense();
            }

            return false;
        }

        public static clsTypesOfExpense Find(int? TypesOfExpenseID)
        {
            string Name= string.Empty;;
            bool IsFound = clsTypesOfExpenseData.GetTypesOfExpenseInfoByID(TypesOfExpenseID,ref Name);

            if (IsFound)
            {
                return new clsTypesOfExpense(TypesOfExpenseID,Name);
            }
            else
            {
                return null;
            }
        }

        public static bool DeleteTypesOfExpense(int? TypesOfExpenseID)
        {
            return clsTypesOfExpenseData.DeleteTypesOfExpense(TypesOfExpenseID);
        }

    
        public static bool DoesTypesOfExpenseExist(int? TypesOfExpenseID)
        {
            return clsTypesOfExpenseData.DoesTypesOfExpenseExist(TypesOfExpenseID);
        }

        public static DataTable GetAllTypesOfExpenses()
        {
            return clsTypesOfExpenseData.GetAllTypesOfExpenses();
        }


    }
}
