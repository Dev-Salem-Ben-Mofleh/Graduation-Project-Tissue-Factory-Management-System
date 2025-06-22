using System;
using System.Data;
using InstituteDataAccess ;

namespace InstituteBussiness 
{
    public class clsCurrencyTyp
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


        public int? CurrencyTypeID{ get; set; }
           public string Name{ get; set; }
        public decimal Amount { get; set; }

        public clsCurrencyTyp()
        {
            this.CurrencyTypeID = null;
            this.Name= string.Empty;;
            this.Amount = 0; ;

            Mode = enMode.AddNew;
        }

        public clsCurrencyTyp(int? CurrencyTypeID,string Name, decimal Amount)
        {
            this.CurrencyTypeID = CurrencyTypeID;
            this.Name = Name;
            this.Amount = Amount;
            Mode = enMode.Update;
        }

        private bool _AddNewCurrencyTyp()
        {
            this.CurrencyTypeID = clsCurrencyTypData.AddNewCurrencyTyp(this.Name,this.Amount);

            return (this.CurrencyTypeID.HasValue);
        }

        private bool _UpdateCurrencyTyp()
        {
            return clsCurrencyTypData.UpdateCurrencyTyp(this.CurrencyTypeID,this.Name, this.Amount);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCurrencyTyp())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateCurrencyTyp();
            }

            return false;
        }

        public static clsCurrencyTyp Find(int? CurrencyTypeID)
        {
            string Name= string.Empty;
            decimal Amount = 0; ;

            bool IsFound = clsCurrencyTypData.GetCurrencyTypInfoByID(CurrencyTypeID,ref Name, ref Amount);

            if (IsFound)
            {
                return new clsCurrencyTyp(CurrencyTypeID,Name, Amount);
            }
            else
            {
                return null;
            }
        }

        public static bool DeleteCurrencyTyp(int? CurrencyTypeID)
        {
            return clsCurrencyTypData.DeleteCurrencyTyp(CurrencyTypeID);
        }

    
        public static bool DoesCurrencyTypExist(int? CurrencyTypeID)
        {
            return clsCurrencyTypData.DoesCurrencyTypExist(CurrencyTypeID);
        }

        public static DataTable GetAllCurrencyType()
        {
            return clsCurrencyTypData.GetAllCurrencyType();
        }


    }
}
