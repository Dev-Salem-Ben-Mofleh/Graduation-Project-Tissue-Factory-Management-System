using System;
using System.Data;
using InstituteDataAccess ;

namespace InstituteBussiness 
{
    public class clsBasicBoxe
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


        public int? BoxID{ get; set; }
           public decimal balance{ get; set; }
            public int? box_status{ get; set; }
            public string BoxName{ get; set; }
        public clsBasicBoxe()
        {
            this.BoxID = null;
            this.balance= -1M;;
            this.box_status = null;
            this.BoxName= string.Empty;;
             Mode = enMode.AddNew;
        }

        public clsBasicBoxe(int? BoxID,decimal balance,int? box_status,string BoxName)
        {
            this.BoxID = BoxID;
            this.balance = balance;
            this.box_status = box_status;
            this.BoxName = BoxName;
            Mode = enMode.Update;
        }

        private bool _AddNewBasicBoxe()
        {
            this.BoxID = clsBasicBoxeData.AddNewBasicBoxe(this.balance,this.box_status,this.BoxName);

            return (this.BoxID.HasValue);
        }

        private bool _UpdateBasicBoxe()
        {
            return clsBasicBoxeData.UpdateBasicBoxe(this.BoxID,this.balance,this.box_status,this.BoxName);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewBasicBoxe())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateBasicBoxe();
            }

            return false;
        }

        public static clsBasicBoxe Find(int? BoxID)
        {
            decimal balance= -1M;
            int? box_status= null;
            string BoxName= string.Empty;
            bool IsFound = clsBasicBoxeData.GetBasicBoxeInfoByID(BoxID,ref balance,ref box_status,ref BoxName);

            if (IsFound)
            {
                return new clsBasicBoxe(BoxID,balance,box_status,BoxName);
            }
            else
            {
                return null;
            }
        }

        public static bool DeleteBasicBoxe(int? BoxID)
        {
            return clsBasicBoxeData.DeleteBasicBoxe(BoxID);
        }

    
        public static bool DoesBasicBoxeExist(int? BoxID)
        {
            return clsBasicBoxeData.DoesBasicBoxeExist(BoxID);
        }

        public static DataTable GetAllBasicBoxes()
        {
            return clsBasicBoxeData.GetAllBasicBoxes();
        }


    }
}
