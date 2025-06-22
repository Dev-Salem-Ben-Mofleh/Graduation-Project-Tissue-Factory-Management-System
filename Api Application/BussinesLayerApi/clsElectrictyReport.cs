using DataAccessesLayerApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccessesLayerApi.clsElectrictyData;
using static DataAccessesLayerApi.clsPrudctionData;
using static DataAccessesLayerApi.clsRaawMatirailsData;

namespace BussinesLayerApi
{
    public class clsElectrictyReport
    {
        public ElectDTO EDTO
        {
            get
            {
                return (new ElectDTO(this.date,
                    this.TypeOf, this.Total, this.Quantity));
            }
        }

        public DateTime? date { get; set; }
        public string? TypeOf { get; set; }
        public int? Total { get; set; }
        public int? Quantity { get; set; }


        public clsElectrictyReport(ElectDTO eDTO)
        {
            this.date = eDTO.date;
            this.TypeOf = eDTO.TypeOf;
            this.Total = eDTO.Total;
            this.Quantity = eDTO.Quantity;

        }

        public static List<ElectDTO> GetAllRows( DateTime ValueSearch)
        {
            return clsElectrictyData.GetAllRows( ValueSearch);
        }

        bool _AddNewRow()
        {

            return clsElectrictyData.AddNewRow(EDTO);

        }

        public static bool DoesRowExist(DateTime ValueSearch) => clsElectrictyData.CheckElectricty_ReportsExiteForMobile(ValueSearch);

        public bool Save()
        {

            if (_AddNewRow())
                return true;
            else
                return false;
        }
    }
}
