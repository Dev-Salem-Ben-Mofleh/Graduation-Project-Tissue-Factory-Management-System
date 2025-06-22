using System;
using System.Data;
using InstituteDataAccess ;

namespace InstituteBussiness 
{
    public class clsStockMovement
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


            public int? StockMovementID{ get; set; }
            public int? MaterialID{ get; set; }
            public int? ProductID{ get; set; }
            public int? Quantity{ get; set; }
            public DateTime StockMovementDate{ get; set; }
            public int? StockMovementType{ get; set; }
            public int? UserID{ get; set; }
            public int? TypeOfOperation { get; set; }
            public int? SaleID { get; set; }
            public int? PurchaseID { get; set; }



        public clsStockMovement()
        {
            this.StockMovementID = null;
            this.MaterialID = null;
            this.ProductID = null;
            this.Quantity = null;
            this.StockMovementDate= DateTime.Now;;
            this.StockMovementType = null;
            this.UserID = null;
            this.TypeOfOperation = null;
            this.SaleID = null;
            this.PurchaseID = null;

            Mode = enMode.AddNew;
        }

        public clsStockMovement(int? StockMovementID,int? MaterialID,int? ProductID,int? Quantity,DateTime StockMovementDate,
            int? StockMovementType,int? UserID,int? TypeOfOperation,int? SaleID,int? PurchaseID)
        {
            this.StockMovementID = StockMovementID;
            this.MaterialID = MaterialID;
            this.ProductID = ProductID;
            this.Quantity = Quantity;
            this.StockMovementDate = StockMovementDate;
            this.StockMovementType = StockMovementType;
            this.UserID = UserID;
            this.TypeOfOperation = TypeOfOperation;
            this.SaleID = SaleID;
            this.PurchaseID = PurchaseID;

            Mode = enMode.Update;
        }

        private bool _AddNewStockMovement()
        {
            this.StockMovementID = clsStockMovementData.AddNewStockMovement(this.MaterialID,this.ProductID,this.Quantity,
                this.StockMovementDate,this.StockMovementType,this.UserID,this.TypeOfOperation,this.SaleID, this.PurchaseID);

            return (this.StockMovementID.HasValue);
        }

        private bool _UpdateStockMovement()
        {
            return clsStockMovementData.UpdateStockMovement(this.StockMovementID,this.MaterialID,this.ProductID,this.Quantity,
                this.StockMovementDate,this.StockMovementType,this.UserID,this.TypeOfOperation, this.SaleID, this.PurchaseID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewStockMovement())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateStockMovement();
            }

            return false;
        }

        public static clsStockMovement Find(int? StockMovementID)
        {
            int? MaterialID= null;
            int? ProductID= null;
            int? Quantity= null;
            DateTime StockMovementDate= DateTime.Now;;
            int? StockMovementType= null;
            int? UserID= null;
            int? TypeOfOperation = null;
            int? SaleID = null;
            int? PurchaseID = null;



            bool IsFound = clsStockMovementData.GetStockMovementInfoByID(StockMovementID,ref MaterialID,ref 
                ProductID,ref Quantity,ref StockMovementDate,ref StockMovementType,ref UserID, ref TypeOfOperation,ref SaleID,ref PurchaseID);

            if (IsFound)
            {
                return new clsStockMovement(StockMovementID,MaterialID,ProductID,Quantity,StockMovementDate,StockMovementType,UserID, TypeOfOperation, SaleID, PurchaseID);
            }
            else
            {
                return null;
            }
        }

        public static clsStockMovement FindBySaleID(int? SaleID, int? ProductID)

        {
            int? MaterialID = null;
            int? Quantity = null;
            DateTime StockMovementDate = DateTime.Now; 
            int? StockMovementType = null;
            int? UserID = null;
            int? TypeOfOperation = null;
            int? StockMovementID = null;
            int? PurchaseID = null;


            bool IsFound = clsStockMovementData.GetStockMovementInfoBySaleID( SaleID, ProductID,ref StockMovementID, ref MaterialID, 
                ref Quantity, ref StockMovementDate, ref StockMovementType, ref UserID, ref TypeOfOperation,ref PurchaseID);

            if (IsFound)
            {
                return new clsStockMovement(StockMovementID, MaterialID, ProductID, Quantity, StockMovementDate, 
                    StockMovementType, UserID, TypeOfOperation, SaleID, PurchaseID);
            }
            else
            {
                return null;
            }
        }


        public static bool DeleteStockMovement(int? StockMovementID)
        {
            return clsStockMovementData.DeleteStockMovement(StockMovementID);
        }

        public static bool DeleteStockMovementBySaleID(int? SaleID)
        {
            return clsStockMovementData.DeleteStockMovementBySaleID(SaleID);
        }

        public static bool DeleteStockMovementByPurchaseID(int? PurchaseID)
        {
            return clsStockMovementData.DeleteStockMovementByPurchaseID(PurchaseID);
        }


        public static bool DoesStockMovementExist(int? StockMovementID)
        {
            return clsStockMovementData.DoesStockMovementExist(StockMovementID);
        }

        public static DataTable GetAllStockMovements()
        {
            return clsStockMovementData.GetAllStockMovements();
        }



    }
}
