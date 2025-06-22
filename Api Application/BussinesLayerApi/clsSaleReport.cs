using DataAccessesLayerApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccessesLayerApi.clsDataSaleReportss;

namespace BussinesLayerApi
{
    public class clsSaleReport
    {
        public SaleDTO SDTO
        {
            get
            {
                return (new SaleDTO(this.SaleDate, this.CountBills, this.Total, this.Proudct,
                    this.Name,this.PaidBill,this.NotPaidBill));
            }
        }

        public DateTime? SaleDate { get; set; }
        public int? CountBills { get; set; }
        public decimal? Total { get; set; }
        public string? Proudct { get; set; }
        public string? Name { get; set; }
        public decimal? PaidBill { get; set; }
        public decimal? NotPaidBill { get; set; }


        public clsSaleReport(SaleDTO sDTO)
        {
            this.SaleDate = sDTO.SaleDate;
            this.CountBills = sDTO.CountBills;
            this.Total = sDTO.Total;
            this.Proudct = sDTO.Proudct;
            this.Name = sDTO.Name;
            this.PaidBill = sDTO.PaidBill;
            this.NotPaidBill = sDTO.NotPaidBill;
        }

        public static List<SaleDTO> GetAllRows( DateTime ValueSearch)
        {
           return clsDataSaleReportss.GetAllRows( ValueSearch);
        }
        bool _AddNewRow()
        {

            return clsDataSaleReportss.AddNewRow(SDTO);

        }

        public bool Save()
        {

            if (_AddNewRow())
                return true;
            else
                return false;
        }
        public static bool DoesRowExist(DateTime ValueSearch) => clsDataSaleReportss.CheckSelaReportIsExiteForMobile(ValueSearch);

    }
}
