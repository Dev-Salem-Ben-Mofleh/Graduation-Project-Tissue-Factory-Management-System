using DataAccessesLayerApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccessesLayerApi.clsDataPurchases;

namespace BussinesLayerApi
{
    public class clsPruchaseReport
    {
        public PurchDTO PDTO
        {
            get
            {
                return (new PurchDTO(this.SaleDate, this.CountBills, this.Total, this.RawMatiral,
                    this.Name, this.PaidBill, this.NotPaidBill));
            }
        }

        public DateTime? SaleDate { get; set; }
        public int? CountBills { get; set; }
        public decimal? Total { get; set; }
        public string? RawMatiral { get; set; }
        public string? Name { get; set; }
        public decimal? PaidBill { get; set; }
        public decimal? NotPaidBill { get; set; }


        public clsPruchaseReport(PurchDTO pDTO)
        {
            this.SaleDate = pDTO.SaleDate;
            this.CountBills = pDTO.CountBills;
            this.Total = pDTO.Total;
            this.RawMatiral = pDTO.RawMatiral;
            this.Name = pDTO.Name;
            this.PaidBill = pDTO.PaidBill;
            this.NotPaidBill = pDTO.NotPaidBill;
        }

        public static List<PurchDTO> GetAllRows( DateTime ValueSearch)
        {
            return clsDataPurchases.GetAllRows( ValueSearch);
        }
        bool _AddNewRow()
        {

            return clsDataPurchases.AddNewRow(PDTO);

        }

        public bool Save()
        {

            if (_AddNewRow())
                return true;
            else
                return false;
        }
        public static bool DoesRowExist(DateTime ValueSearch) => clsDataPurchases.CheckPurches_ReportsExiteForMobile(ValueSearch);

    }
}
