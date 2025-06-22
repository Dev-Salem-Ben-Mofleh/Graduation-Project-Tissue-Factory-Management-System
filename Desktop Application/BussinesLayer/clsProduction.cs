using System;
using System.Data;
using InstituteDataAccess ;

namespace InstituteBussiness 
{
    public class clsProduction
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


            public int? ProductionID{ get; set; }
            public int? DamagedQuantity{ get; set; }
            public int? MaterialID{ get; set; }
            public clsRawMaterial rawMaterialInfo;
            public int? ProductID{ get; set; }
            public clsProduct productInfo;
            public DateTime ProductionDate{ get; set; }
            public int? Quantity{ get; set; }
            public int? RawAmount{ get; set; }
            public int? StockMovementIDMaterial{ get; set; }
            public int? StockMovementIDProduct{ get; set; }
            public int? UserID{ get; set; }
        public clsProduction()
        {
            this.ProductionID = null;
            this.DamagedQuantity = null;
            this.MaterialID = null;
            this.ProductID = null;
            this.ProductionDate= DateTime.Now;;
            this.Quantity = null;
            this.RawAmount = null;
            this.StockMovementIDMaterial = null;
            this.StockMovementIDProduct = null;
            this.UserID = null;
             Mode = enMode.AddNew;
        }

        public clsProduction(int? ProductionID,int? DamagedQuantity,int? MaterialID,int? ProductID,DateTime ProductionDate,int? Quantity,int? RawAmount,int? StockMovementIDMaterial,int? StockMovementIDProduct,int? UserID)
        {
            this.ProductionID = ProductionID;
            this.DamagedQuantity = DamagedQuantity;
            this.MaterialID = MaterialID;
            rawMaterialInfo = clsRawMaterial.Find(MaterialID);
            this.ProductID = ProductID;
            productInfo = clsProduct.Find(ProductID);
            this.ProductionDate = ProductionDate;
            this.Quantity = Quantity;
            this.RawAmount = RawAmount;
            this.StockMovementIDMaterial = StockMovementIDMaterial;
            this.StockMovementIDProduct = StockMovementIDProduct;
            this.UserID = UserID;
            Mode = enMode.Update;
        }

        private bool _AddNewProduction()
        {
            this.ProductionID = clsProductionData.AddNewProduction(this.DamagedQuantity,this.MaterialID,this.ProductID,this.ProductionDate,this.Quantity,this.RawAmount,this.StockMovementIDMaterial,this.StockMovementIDProduct,this.UserID);

            return (this.ProductionID.HasValue);
        }

        private bool _UpdateProduction()
        {
            return clsProductionData.UpdateProduction(this.ProductionID,this.DamagedQuantity,this.MaterialID,this.ProductID,this.ProductionDate,this.Quantity,this.RawAmount,this.StockMovementIDMaterial,this.StockMovementIDProduct,this.UserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewProduction())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateProduction();
            }

            return false;
        }

        public static clsProduction Find(int? ProductionID)
        {
            int? DamagedQuantity= null;
            int? MaterialID= null;
            int? ProductID= null;
            DateTime ProductionDate= DateTime.Now;;
            int? Quantity= null;
            int? RawAmount= null;
            int? StockMovementIDMaterial= null;
            int? StockMovementIDProduct= null;
            int? UserID= null;
            bool IsFound = clsProductionData.GetProductionInfoByID(ProductionID,ref DamagedQuantity,ref MaterialID,ref ProductID,ref ProductionDate,ref Quantity,ref RawAmount,ref StockMovementIDMaterial,ref StockMovementIDProduct,ref UserID);

            if (IsFound)
            {
                return new clsProduction(ProductionID,DamagedQuantity,MaterialID,ProductID,ProductionDate,Quantity,RawAmount,StockMovementIDMaterial,StockMovementIDProduct,UserID);
            }
            else
            {
                return null;
            }
        }

        public static bool DeleteProduction(int? ProductionID)
        {
            return clsProductionData.DeleteProduction(ProductionID);
        }

    
        public static bool DoesProductionExist(int? ProductionID)
        {
            return clsProductionData.DoesProductionExist(ProductionID);
        }

        public static DataTable GetAllProductions()
        {
            return clsProductionData.GetAllProductions();
        }


        public static DataTable GetReports(string Culomn, DateTime ValueSearch)
        {
            return clsProductionData.GetReports(Culomn, ValueSearch);
        }

    }
}
