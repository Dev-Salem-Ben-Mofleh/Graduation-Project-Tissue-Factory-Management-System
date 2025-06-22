using DataAccessesLayerApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccessesLayerApi.clsDataSaleReportss;
using static DataAccessesLayerApi.clsPrudctionData;

namespace BussinesLayerApi
{
    public class clsPrudtionReport
    {
        public ProdctionDTO PDTO
        {
            get
            {
                return (new ProdctionDTO(this.ProductionDate, this.ProductName, this.Quantity, this.DamagedQuantity,
                    this.Material_Name, this.RawAmount));
            }
        }

        public DateTime? ProductionDate { get; set; }
        public string? ProductName { get; set; }
        public int? Quantity { get; set; }
        public int? DamagedQuantity { get; set; }
        public string? Material_Name { get; set; }
        public int? RawAmount { get; set; }

        public clsPrudtionReport(ProdctionDTO pDTO)
        {
            this.ProductionDate = pDTO.ProductionDate;
            this.ProductName = pDTO.ProductName;
            this.Quantity = pDTO.Quantity;
            this.DamagedQuantity = pDTO.DamagedQuantity;
            this.Material_Name = pDTO.Material_Name;
            this.RawAmount = pDTO.RawAmount;
        }

        public static List<ProdctionDTO> GetAllRows( DateTime ValueSearch)
        {
            return clsPrudctionData.GetAllRows( ValueSearch);
        }

        bool _AddNewRow()
        {

            return clsPrudctionData.AddNewRow(PDTO);

        }

        public bool Save()
        {

            if (_AddNewRow())
                return true;
            else
                return false;
        }
        public static bool DoesRowExist(DateTime ValueSearch) => clsPrudctionData.CheckProduction_ReportssExiteForMobile(ValueSearch);

    }
}
