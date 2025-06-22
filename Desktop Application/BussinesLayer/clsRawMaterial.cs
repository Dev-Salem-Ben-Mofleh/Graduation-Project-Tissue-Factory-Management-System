using System;
using System.Data;
using InstituteDataAccess ;

namespace InstituteBussiness 
{
    public class clsRawMaterial
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


            public int? MaterialID{ get; set; }
            public DateTime DeliveryDate{ get; set; }
            public string Material_Name{ get; set; }
            public int? Quantity{ get; set; }
            public decimal Unit_cost { get; set; }
            public int? UnitMeasurement{ get; set; }
        public clsRawMaterial()
        {
            this.MaterialID = null;
            this.DeliveryDate = DateTime.Now;
            this.Material_Name = string.Empty;
            this.Quantity = null;
            this.Unit_cost = 0;
            this.UnitMeasurement = null;
             Mode = enMode.AddNew;
        }

        public clsRawMaterial(int? MaterialID,DateTime DeliveryDate,string Material_Name,int? Quantity,
            decimal Unit_cost,int? UnitMeasurement)
        {
            this.MaterialID = MaterialID;
            this.DeliveryDate = DeliveryDate;
            this.Material_Name = Material_Name;
            this.Quantity = Quantity;
            this.Unit_cost = Unit_cost;
            this.UnitMeasurement = UnitMeasurement;
            Mode = enMode.Update;
        }

        private bool _AddNewRawMaterial()
        {
            this.MaterialID = clsRawMaterialData.AddNewRawMaterial(this.DeliveryDate,this.Material_Name,this.Quantity,this.Unit_cost,this.UnitMeasurement);

            return (this.MaterialID.HasValue);
        }

        private bool _UpdateRawMaterial()
        {
            return clsRawMaterialData.UpdateRawMaterial(this.MaterialID,this.DeliveryDate,this.Material_Name,this.Quantity,this.Unit_cost,this.UnitMeasurement);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewRawMaterial())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateRawMaterial();
            }

            return false;
        }

        public static clsRawMaterial Find(int? MaterialID)
        {
            DateTime DeliveryDate= DateTime.Now;
            string Material_Name= null;
            int? Quantity= null;
            decimal Unit_cost = 0;
            int? UnitMeasurement= null;
            bool IsFound = clsRawMaterialData.GetRawMaterialInfoByID(MaterialID,ref DeliveryDate,ref Material_Name,ref Quantity,ref Unit_cost,ref UnitMeasurement);

            if (IsFound)
            {
                return new clsRawMaterial(MaterialID,DeliveryDate,Material_Name,Quantity,Unit_cost,UnitMeasurement);
            }
            else
            {
                return null;
            }
        }

        public static clsRawMaterial Find(string Material_Name)
        {
            DateTime DeliveryDate = DateTime.Now;
            int? MaterialID = null;
            int? Quantity = null;
            decimal Unit_cost = 0;
            int? UnitMeasurement = null;
            bool IsFound = clsRawMaterialData.GetRawMaterialInfoByName(Material_Name,ref MaterialID, ref DeliveryDate, ref Quantity, ref Unit_cost, ref UnitMeasurement);

            if (IsFound)
            {
                return new clsRawMaterial(MaterialID, DeliveryDate, Material_Name, Quantity, Unit_cost, UnitMeasurement);
            }
            else
            {
                return null;
            }
        }

        public static bool DeleteRawMaterial(int? MaterialID)
        {
            return clsRawMaterialData.DeleteRawMaterial(MaterialID);
        }

    
        public static bool DoesRawMaterialExist(int? MaterialID)
        {
            return clsRawMaterialData.DoesRawMaterialExist(MaterialID);
        }
        public static bool DoesRawMaterialExist(string Material_Name)
        {
            return clsRawMaterialData.DoesRawMaterialExist(Material_Name);
        }



        public static DataTable GetAllRawMaterials()
        {
            return clsRawMaterialData.GetAllRawMaterials();
        }

        public static DataTable GetReports(string Culomn, DateTime ValueSearch)
        {
            return clsRawMaterialData.GetReports(Culomn, ValueSearch);
        }

    }
}
