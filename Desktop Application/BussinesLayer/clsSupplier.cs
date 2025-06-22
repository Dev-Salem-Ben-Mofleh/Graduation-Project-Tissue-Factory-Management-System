using System;
using System.Data;
using InstituteDataAccess ;

namespace InstituteBussiness 
{
    public class clsSupplier
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


        public int? SupplierID{ get; set; }
           public string Description{ get; set; }
public int? PersonID{ get; set; }
public int? PurchaseID{ get; set; }
        public clsSupplier()
        {
            this.SupplierID = null;
        this.Description= string.Empty;;
this.PersonID = null;
this.PurchaseID = null;
             Mode = enMode.AddNew;
        }

        public clsSupplier(int? SupplierID,string Description,int? PersonID,int? PurchaseID)
        {
            this.SupplierID = SupplierID;
            this.Description = Description;
this.PersonID = PersonID;
this.PurchaseID = PurchaseID;
            Mode = enMode.Update;
        }

        private bool _AddNewSupplier()
        {
            this.SupplierID = clsSupplierData.AddNewSupplier(this.Description,this.PersonID,this.PurchaseID);

            return (this.SupplierID.HasValue);
        }

        private bool _UpdateSupplier()
        {
            return clsSupplierData.UpdateSupplier(this.SupplierID,this.Description,this.PersonID,this.PurchaseID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewSupplier())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateSupplier();
            }

            return false;
        }

        public static clsSupplier Find(int? SupplierID)
        {
            string Description= string.Empty;;
int? PersonID= null;
int? PurchaseID= null;
            bool IsFound = clsSupplierData.GetSupplierInfoByID(SupplierID,ref Description,ref PersonID,ref PurchaseID);

            if (IsFound)
            {
                return new clsSupplier(SupplierID,Description,PersonID,PurchaseID);
            }
            else
            {
                return null;
            }
        }

        public static bool DeleteSupplier(int? SupplierID)
        {
            return clsSupplierData.DeleteSupplier(SupplierID);
        }

    
        public static bool DoesSupplierExist(int? SupplierID)
        {
            return clsSupplierData.DoesSupplierExist(SupplierID);
        }

        public static DataTable GetAllSuppliers()
        {
            return clsSupplierData.GetAllSuppliers();
        }


    }
}
