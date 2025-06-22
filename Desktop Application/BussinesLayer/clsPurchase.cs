using System;
using System.Data;
using InstituteDataAccess ;

namespace InstituteBussiness 
{
    public class clsPurchase
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


        public int? PurchaseID{ get; set; }
        public int? BoxMovementID{ get; set; }
        public clsBoxMovement boxMovementInfo;

        public int? CurrencyTypeID{ get; set; }
        public clsCurrencyTyp currencyTypInfo;

        public decimal Discount{ get; set; }
        public decimal NetAmount{ get; set; }
        public int? PaymentStatuID{ get; set; }
        public clsPaymentStatu paymentStatuInfo;

        public DateTime PurchaseDate{ get; set; }
        public decimal TotalAmount{ get; set; }
        public int? UserID{ get; set; }

        public clsUser userInfo;

        public int? PersonID { get; set; }
        public clsPerson personInfo;

        public clsPurchase()
        {
        this.PurchaseID = null;
        this.BoxMovementID = null;
        this.CurrencyTypeID = null;
        this.Discount= -1M;;
        this.NetAmount = -1M;
        this.PaymentStatuID = null;
        this.PurchaseDate = DateTime.Now;
        this.TotalAmount= -1M;;
        this.UserID = null;
            this.PersonID = null;

            Mode = enMode.AddNew;
        }

        public clsPurchase(int? PurchaseID,int? BoxMovementID,int? CurrencyTypeID,decimal Discount, decimal NetAmount,
            int? PaymentStatuID,DateTime PurchaseDate,decimal TotalAmount,int? UserID,int? PersonID)
        {
            this.PurchaseID = PurchaseID;
            this.BoxMovementID = BoxMovementID;
            boxMovementInfo = clsBoxMovement.Find(BoxMovementID);

            this.CurrencyTypeID = CurrencyTypeID;
            currencyTypInfo = clsCurrencyTyp.Find(CurrencyTypeID);


            this.Discount = Discount;
            this.NetAmount = NetAmount;
            this.PaymentStatuID = PaymentStatuID;
            paymentStatuInfo = clsPaymentStatu.Find(PaymentStatuID);

            this.PurchaseDate = PurchaseDate;
            this.TotalAmount = TotalAmount;
            this.UserID = UserID;
            userInfo = clsUser.Find(UserID);

            this.PersonID = PersonID;
            personInfo = clsPerson.Find(PersonID);


            Mode = enMode.Update;
        }

        private bool _AddNewPurchase()
        {
            this.PurchaseID = clsPurchaseData.AddNewPurchase(this.BoxMovementID,this.CurrencyTypeID,this.Discount,this.NetAmount,this.PaymentStatuID,
                this.PurchaseDate,this.TotalAmount,this.UserID, this.PersonID);

            return (this.PurchaseID.HasValue);
        }

        private bool _UpdatePurchase()
        {
            return clsPurchaseData.UpdatePurchase(this.PurchaseID,this.BoxMovementID,this.CurrencyTypeID,this.Discount,this.NetAmount,
                this.PaymentStatuID,this.PurchaseDate,this.TotalAmount,this.UserID, this.PersonID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPurchase())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdatePurchase();
            }

            return false;
        }

        public static clsPurchase Find(int? PurchaseID)
        {
            int? BoxMovementID= null;
            int? CurrencyTypeID= null;
            decimal Discount= -1M;;
            decimal NetAmount = -1M;
            int? PaymentStatuID= null;
            DateTime PurchaseDate= DateTime.Now;
            decimal TotalAmount= -1M;;
            int? UserID= null;
            int? PersonID = null;

            bool IsFound = clsPurchaseData.GetPurchaseInfoByID(PurchaseID,ref BoxMovementID,ref CurrencyTypeID,ref
                Discount,ref NetAmount,ref PaymentStatuID,ref PurchaseDate,ref TotalAmount,ref UserID,ref PersonID);

            if (IsFound)
            {
                return new clsPurchase(PurchaseID,BoxMovementID,CurrencyTypeID,Discount,NetAmount,PaymentStatuID,PurchaseDate,TotalAmount,UserID, PersonID);
            }
            else
            {
                return null;
            }
        }

        public static bool DeletePurchase(int? PurchaseID)
        {
            return clsPurchaseData.DeletePurchase(PurchaseID);
        }

    
        public static bool DoesPurchaseExist(int? PurchaseID)
        {
            return clsPurchaseData.DoesPurchaseExist(PurchaseID);
        }

        public static DataTable GetAllPurchases()
        {
            return clsPurchaseData.GetAllPurchases();
        }

        public static DataTable GetAllPurchases(string Culomn, DateTime ValueSearch)
        {
            return clsPurchaseData.GetReports(Culomn, ValueSearch);
        }

        public static DataTable GetPruchesPaid(DateTime Datefrom, DateTime DateTo)
        {
            return clsPurchaseData.GetPruchesPaid(Datefrom, DateTo);
        }

        public static DataTable GetPurchesNoPaid(DateTime Datefrom, DateTime DateTo)
        {
            return clsPurchaseData.GetPurchesNoPaid(Datefrom, DateTo);
        }

        public static DataTable GetPurcheseTotal(DateTime Datefrom, DateTime DateTo)
        {
            return clsPurchaseData.GetPurcheseTotal(Datefrom, DateTo);
        }

        public static DataTable GetPurchesReportForDashboard(DateTime Datefrom, DateTime DateTo)
        {
            return clsPurchaseData.GetPurchesReportForDashboard(Datefrom, DateTo);
        }

    }
}
