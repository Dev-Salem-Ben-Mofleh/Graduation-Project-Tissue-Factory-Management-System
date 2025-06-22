using System;
using System.Data;
using InstituteDataAccess ;

namespace InstituteBussiness 
{
    public class clsSale
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


        public int? SaleID{ get; set; }
        public int? BoxMovementID{ get; set; }
        public clsBoxMovement boxMovementInfo;
        public decimal Discount{ get; set; }
        public decimal NetAmount{ get; set; }
        public int? PaymentStatuID{ get; set; }
        public clsPaymentStatu paymentStatuInfo;
        public int? PersonID{ get; set; }
        public clsPerson personInfo;
        public DateTime SaleDate { get; set; }
        public decimal TotalAmount{ get; set; }
        public int? UserID{ get; set; }
        public clsUser userInfo;

        public int? CurrencyID { get; set; }

        public clsCurrencyTyp currencyTypInfo;


        public clsSale()
        {
            this.SaleID = null;
        this.BoxMovementID = null;
            this.Discount= -1M;;
            this.NetAmount = -1M;
            this.PaymentStatuID = null;
            this.PersonID = null;
            this.SaleDate= DateTime.Now;;
            this.TotalAmount= -1M;;
            this.UserID = null;
            this.CurrencyID = null;

            Mode = enMode.AddNew;
        }

        public clsSale(int? SaleID,int? BoxMovementID,decimal Discount, decimal NetAmount,
            int? PaymentStatuID,int? PersonID,DateTime SaleDate,decimal TotalAmount,int? UserID,int? CurrencyID
            )
        {
            this.SaleID = SaleID;
            this.BoxMovementID = BoxMovementID;
            boxMovementInfo = clsBoxMovement.Find(BoxMovementID);
            this.Discount = Discount;
            this.NetAmount = NetAmount;
            this.PaymentStatuID = PaymentStatuID;
            paymentStatuInfo = clsPaymentStatu.Find(PaymentStatuID);
            this.PersonID = PersonID;
            personInfo = clsPerson.Find(PersonID);
            this.SaleDate = SaleDate;
            this.TotalAmount = TotalAmount;
            this.UserID = UserID;
            userInfo = clsUser.Find(UserID);
            this.CurrencyID = CurrencyID;
            currencyTypInfo = clsCurrencyTyp.Find(CurrencyID);


            Mode = enMode.Update;
        }

        private bool _AddNewSale()
        {
            this.SaleID = clsSaleData.AddNewSale(this.BoxMovementID,this.Discount,
                this.NetAmount,this.PaymentStatuID,this.PersonID,this.SaleDate,this.TotalAmount,this.UserID,this.CurrencyID);

            return (this.SaleID.HasValue);
        }

        private bool _UpdateSale()
        {
            return clsSaleData.UpdateSale(this.SaleID,this.BoxMovementID,this.Discount,this.NetAmount,this.PaymentStatuID,
                this.PersonID,this.SaleDate,this.TotalAmount,this.UserID, this.CurrencyID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewSale())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateSale();
            }

            return false;
        }

        public static clsSale Find(int? SaleID)
        {
            int? BoxMovementID= null;
            decimal Discount= -1M;;
            decimal NetAmount= -1M;
            int? PaymentStatuID= null;
            int? PersonID= null;
            DateTime SaleDate= DateTime.Now;;
            decimal TotalAmount= -1M;;
            int? UserID= null;
            int? CurrencyID = null;


            bool IsFound = clsSaleData.GetSaleInfoByID(SaleID,ref BoxMovementID,ref Discount,ref NetAmount,ref 
                PaymentStatuID,ref PersonID,ref SaleDate,ref TotalAmount,ref UserID,  ref CurrencyID);

            if (IsFound)
            {
                return new clsSale(SaleID,BoxMovementID,Discount,NetAmount,PaymentStatuID,PersonID,SaleDate,TotalAmount,UserID, CurrencyID);
            }
            else
            {
                return null;
            }
        }

        public static bool DeleteSale(int? SaleID)
        {
            return clsSaleData.DeleteSale(SaleID);
        }

    
        public static bool DoesSaleExist(int? SaleID)
        {
            return clsSaleData.DoesSaleExist(SaleID);
        }

        public static DataTable GetAllSales()
        {
            return clsSaleData.GetAllSales();
        }

        public static DataTable GetReports(string Culomn, DateTime ValueSearch)
        {
            return clsSaleData.GetReports(Culomn, ValueSearch);
        }
        public static DataTable GetSalePaid(DateTime Datefrom, DateTime DateTo)
        {
            return clsSaleData.GetSalePaid(Datefrom, DateTo);
        }

        public static DataTable GetSaleNoPaid(DateTime Datefrom, DateTime DateTo)
        {
            return clsSaleData.GetSaleNoPaid(Datefrom, DateTo);
        }

        public static DataTable GetSaleTotal(DateTime Datefrom, DateTime DateTo)
        {
            return clsSaleData.GetSaleTotal(Datefrom, DateTo);
        }

        public static DataTable GetSaleReportForDashboard(DateTime Datefrom, DateTime DateTo)
        {
            return clsSaleData.GetSaleReportForDashboard(Datefrom, DateTo);
        }


    }
}
