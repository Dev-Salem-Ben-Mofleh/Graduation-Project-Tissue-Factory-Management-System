using System;
using System.Data;
using InstituteDataAccess ;

namespace InstituteBussiness 
{
    public class clsPaymentStatu
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


        public int? PaymentStatuID{ get; set; }
           public string TypeName{ get; set; }
        public clsPaymentStatu()
        {
            this.PaymentStatuID = null;
        this.TypeName= string.Empty;;
             Mode = enMode.AddNew;
        }

        public clsPaymentStatu(int? PaymentStatuID,string TypeName)
        {
            this.PaymentStatuID = PaymentStatuID;
            this.TypeName = TypeName;
            Mode = enMode.Update;
        }

        private bool _AddNewPaymentStatu()
        {
            this.PaymentStatuID = clsPaymentStatuData.AddNewPaymentStatu(this.TypeName);

            return (this.PaymentStatuID.HasValue);
        }

        private bool _UpdatePaymentStatu()
        {
            return clsPaymentStatuData.UpdatePaymentStatu(this.PaymentStatuID,this.TypeName);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPaymentStatu())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdatePaymentStatu();
            }

            return false;
        }

        public static clsPaymentStatu Find(int? PaymentStatuID)
        {
            string TypeName= string.Empty;;
            bool IsFound = clsPaymentStatuData.GetPaymentStatuInfoByID(PaymentStatuID,ref TypeName);

            if (IsFound)
            {
                return new clsPaymentStatu(PaymentStatuID,TypeName);
            }
            else
            {
                return null;
            }
        }

        public static bool DeletePaymentStatu(int? PaymentStatuID)
        {
            return clsPaymentStatuData.DeletePaymentStatu(PaymentStatuID);
        }

    
        public static bool DoesPaymentStatuExist(int? PaymentStatuID)
        {
            return clsPaymentStatuData.DoesPaymentStatuExist(PaymentStatuID);
        }

        public static DataTable GetAllPaymentStatus()
        {
            return clsPaymentStatuData.GetAllPaymentStatus();
        }


    }
}
