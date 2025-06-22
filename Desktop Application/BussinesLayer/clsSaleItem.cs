using System;
using System.Data;
using InstituteDataAccess ;

namespace InstituteBussiness 
{
    public class clsSaleItem
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


        public int? SaleItemID{ get; set; }
        public decimal Amount{ get; set; }
        public decimal Price{ get; set; }
        public int? ProductID{ get; set; }
        public clsProduct productInfo;
        public int? SaleID{ get; set; }

        public clsSaleItem()
        {
            this.SaleItemID = null;
            this.Amount= -1M;;
            this.Price= -1M;;
            this.ProductID = null;
            this.SaleID = null;
             Mode = enMode.AddNew;
        }

        public clsSaleItem(int? SaleItemID,decimal Amount,decimal Price,int? ProductID,int? SaleID)
        {
            this.SaleItemID = SaleItemID;
            this.Amount = Amount;
            this.Price = Price;
            this.ProductID = ProductID;
            productInfo = clsProduct.Find(ProductID);
            this.SaleID = SaleID;
            Mode = enMode.Update;
        }

        private bool _AddNewSaleItem()
        {
            this.SaleItemID = clsSaleItemData.AddNewSaleItem(this.Amount,this.Price,this.ProductID,this.SaleID);

            return (this.SaleItemID.HasValue);
        }

        private bool _UpdateSaleItem()
        {
            return clsSaleItemData.UpdateSaleItem(this.SaleItemID,this.Amount,this.Price,this.ProductID,this.SaleID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewSaleItem())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateSaleItem();
            }

            return false;
        }

        public static clsSaleItem Find(int? SaleItemID)
        {
            decimal Amount= -1M;;
            decimal Price= -1M;;
            int? ProductID= null;
            int? SaleID= null;
            bool IsFound = clsSaleItemData.GetSaleItemInfoByID(SaleItemID,ref Amount,ref Price,ref ProductID,ref SaleID);

            if (IsFound)
            {
                return new clsSaleItem(SaleItemID,Amount,Price,ProductID,SaleID);
            }
            else
            {
                return null;
            }
        }

        public static clsSaleItem FindSaleID(int? SaleID)
        {
            decimal Amount = -1M; ;
            decimal Price = -1M; ;
            int? ProductID = null;
            int? SaleItemID = null;
            bool IsFound = clsSaleItemData.GetSaleItemInfoBySaleID(SaleID,ref SaleItemID, ref Amount, ref Price, ref ProductID);

            if (IsFound)
            {
                return new clsSaleItem(SaleItemID, Amount, Price, ProductID, SaleID);
            }
            else
            {
                return null;
            }
        }

        public static bool DeleteSaleItem(int? SaleItemID)
        {
            return clsSaleItemData.DeleteSaleItem(SaleItemID);
        }
        public static bool DeleteAllSaleItem(int? SaleID)
        {
            return clsSaleItemData.DeleteAllSaleItem(SaleID);
        }


        public static bool DoesSaleItemExist(int? SaleItemID)
        {
            return clsSaleItemData.DoesSaleItemExist(SaleItemID);
        }

        public static DataTable GetAllSaleItems()
        {
            return clsSaleItemData.GetAllSaleItems();
        }

        public static DataTable GetAllSaleItems(int? SaleID)
        {
            return clsSaleItemData.GetAllSaleItems(SaleID);
        }

    }
}
