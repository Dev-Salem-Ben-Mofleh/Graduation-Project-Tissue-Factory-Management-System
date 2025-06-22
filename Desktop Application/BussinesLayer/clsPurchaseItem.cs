using System;
using System.Data;
using InstituteDataAccess ;

namespace InstituteBussiness 
{
    public class clsPurchaseItem
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


        public int? PurchaseItemID{ get; set; }
           public int? MaterialID{ get; set; }
            public decimal Price{ get; set; }
            public int? PurchaseID{ get; set; }
            public int? Qauntity{ get; set; }
        public clsPurchaseItem()
        {
        this.PurchaseItemID = null;
        this.MaterialID = null;
        this.Price= -1M;;
        this.PurchaseID = null;
        this.Qauntity = null;
             Mode = enMode.AddNew;
        }

        public clsPurchaseItem(int? PurchaseItemID,int? MaterialID,decimal Price,int? PurchaseID,int? Qauntity)
        {
            this.PurchaseItemID = PurchaseItemID;
            this.MaterialID = MaterialID;
            this.Price = Price;
            this.PurchaseID = PurchaseID;
            this.Qauntity = Qauntity;
            Mode = enMode.Update;
        }

        private bool _AddNewPurchaseItem()
        {
            this.PurchaseItemID = clsPurchaseItemData.AddNewPurchaseItem(this.MaterialID,this.Price,this.PurchaseID,this.Qauntity);

            return (this.PurchaseItemID.HasValue);
        }

        private bool _UpdatePurchaseItem()
        {
            return clsPurchaseItemData.UpdatePurchaseItem(this.PurchaseItemID,this.MaterialID,this.Price,this.PurchaseID,this.Qauntity);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPurchaseItem())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdatePurchaseItem();
            }

            return false;
        }

        public static clsPurchaseItem Find(int? PurchaseItemID)
        {
            int? MaterialID= null;
            decimal Price= -1M;;
            int? PurchaseID= null;
            int? Qauntity= null;
            bool IsFound = clsPurchaseItemData.GetPurchaseItemInfoByID(PurchaseItemID,ref MaterialID,ref Price,ref PurchaseID,ref Qauntity);

            if (IsFound)
            {
                return new clsPurchaseItem(PurchaseItemID,MaterialID,Price,PurchaseID,Qauntity);
            }
            else
            {
                return null;
            }
        }
        public static clsPurchaseItem FindByPurchaseID(int? PurchaseID)
        {
            int? MaterialID = null;
            decimal Price = -1M; ;
            int? PurchaseItemID = null;
            int? Qauntity = null;
            bool IsFound = clsPurchaseItemData.GetPurchaseItemByPurchaseID( PurchaseID, ref PurchaseItemID, ref MaterialID, ref Price,ref Qauntity);

            if (IsFound)
            {
                return new clsPurchaseItem(PurchaseItemID, MaterialID, Price, PurchaseID, Qauntity);
            }
            else
            {
                return null;
            }
        }

        public static bool DeletePurchaseItem(int? PurchaseID)
        {
            return clsPurchaseItemData.DeletePurchaseItemByPurchaseID(@PurchaseID);
        }

    
        public static bool DoesPurchaseItemExist(int? PurchaseItemID)
        {
            return clsPurchaseItemData.DoesPurchaseItemExist(PurchaseItemID);
        }

        public static DataTable GetAllPurchaseItems(int? PurchaseID)
        {
            return clsPurchaseItemData.GetAllPurchaseItems(PurchaseID);
        }


    }
}
