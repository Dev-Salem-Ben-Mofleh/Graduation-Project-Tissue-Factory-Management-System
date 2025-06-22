using System;
using System.Data;
using InstituteDataAccess ;

namespace InstituteBussiness 
{
    public class clsProduct
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


            public int? ProductID{ get; set; }
            public string description{ get; set; }
            public string ProductName{ get; set; }
            public int? Quantity{ get; set; }
            public string UnitMeasurement { get; set; }
            public decimal UnitPrice { get; set; }
        public clsProduct()
        {
            this.ProductID = null;
            this.description= string.Empty;;
            this.ProductName = string.Empty;
            this.Quantity = null;
            this.UnitMeasurement = string.Empty;
            this.UnitPrice = 0;
             Mode = enMode.AddNew;
        }

        public clsProduct(int? ProductID,string description, string ProductName,int? Quantity, string UnitMeasurement, decimal UnitPrice)
        {
            this.ProductID = ProductID;
            this.description = description;
            this.ProductName = ProductName;
            this.Quantity = Quantity;
            this.UnitMeasurement = UnitMeasurement;
            this.UnitPrice = UnitPrice;
            Mode = enMode.Update;
        }

        private bool _AddNewProduct()
        {
            this.ProductID = clsProductData.AddNewProduct(this.description,this.ProductName,this.Quantity,this.UnitMeasurement,this.UnitPrice);

            return (this.ProductID.HasValue);
        }

        private bool _UpdateProduct()
        {
            return clsProductData.UpdateProduct(this.ProductID,this.description,this.ProductName,this.Quantity,this.UnitMeasurement,this.UnitPrice);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewProduct())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateProduct();
            }

            return false;
        }

        public static clsProduct Find(int? ProductID)
        {
            string description= string.Empty;;
            string ProductName= null;
            int? Quantity= null;
            string UnitMeasurement= string.Empty;
            decimal UnitPrice = 0;
            bool IsFound = clsProductData.GetProductInfoByID(ProductID,ref description,ref ProductName,ref Quantity,ref UnitMeasurement,ref UnitPrice);

            if (IsFound)
            {
                return new clsProduct(ProductID,description,ProductName,Quantity,UnitMeasurement,UnitPrice);
            }
            else
            {
                return null;
            }
        }

        public static clsProduct Find(string ProductName)
        {
            string description = string.Empty; ;
            int? ProductID = null;
            int? Quantity = null;
            string UnitMeasurement = string.Empty;
            decimal UnitPrice = 0;
            bool IsFound = clsProductData.GetProductInfoByName(ProductName, ref ProductID , ref description, ref Quantity, ref UnitMeasurement, ref UnitPrice);

            if (IsFound)
            {
                return new clsProduct(ProductID, description,  ProductName , Quantity, UnitMeasurement, UnitPrice);
            }
            else
            {
                return null;
            }
        }

        public static bool DeleteProduct(int? ProductID)
        {
            return clsProductData.DeleteProduct(ProductID);
        }

    
        public static bool DoesProductExist(int? ProductID)
        {
            return clsProductData.DoesProductExist(ProductID);
        }

        public static DataTable GetAllProducts()
        {
            return clsProductData.GetAllProducts();
        }


    }
}
