using DataAccessesLayerApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccessesLayerApi.clsPrudctionData;
using static DataAccessesLayerApi.clsRaawMatirailsData;

namespace BussinesLayerApi
{
    public class clsRaawMatirailsReport
    {

        public RawDTO RDTO
        {
            get
            {
                return (new RawDTO(this.ProductionDate,
                    this.Material_Name, this.RawAmount, this.Quantity));
            }
        }

        public DateTime? ProductionDate { get; set; }
        public string? Material_Name { get; set; }
        public int? RawAmount { get; set; }
        public int? Quantity { get; set; }


        public clsRaawMatirailsReport(RawDTO pDTO)
        {
            this.ProductionDate = pDTO.ProductionDate;
            this.Material_Name = pDTO.Material_Name;
            this.RawAmount = pDTO.RawAmount;
            this.Quantity = pDTO.Quantity;

        }

        public static List<RawDTO> GetAllRows( DateTime ValueSearch)
        {
            return clsRaawMatirailsData.GetAllRows( ValueSearch);
        }

        bool _AddNewRow()
        {

            return clsRaawMatirailsData.AddNewRow(RDTO);

        }

        public bool Save()
        {

            if (_AddNewRow())
                return true;
            else
                return false;
        }
        public static bool DoesRowExist(DateTime ValueSearch) => clsRaawMatirailsData.CheckRawMatrials_ReportsExiteForMobile(ValueSearch);

    }
}
