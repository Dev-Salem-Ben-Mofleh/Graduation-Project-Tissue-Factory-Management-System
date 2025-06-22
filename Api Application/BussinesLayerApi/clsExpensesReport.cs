using DataAccessesLayerApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccessesLayerApi.clsExpensesData;

namespace BussinesLayerApi
{
    public class clsExpensesReport
    {
        public ExpDTO EDTO
        {
            get
            {
                return (new ExpDTO(this.ExpenseDate, this.CountBills, this.Total, this.Amount,
                    this.Name));
            }
        }

        public DateTime? ExpenseDate { get; set; }
        public int? CountBills { get; set; }
        public decimal? Total { get; set; }
        public decimal? Amount { get; set; }
        public string? Name { get; set; }


        public clsExpensesReport(ExpDTO eDTO)
        {
            this.ExpenseDate = eDTO.ExpenseDate;
            this.CountBills = eDTO.CountBills;
            this.Total = eDTO.Total;
            this.Amount = eDTO.Amount;
            this.Name = eDTO.Name;
        }

        public static List<ExpDTO> GetAllRows( DateTime ValueSearch)
        {
            return clsExpensesData.GetAllRows( ValueSearch);
        }
        bool _AddNewRow()
        {

            return clsExpensesData.AddNewRow(EDTO);

        }

        public bool Save()
        {

            if (_AddNewRow())
                return true;
            else
                return false;
        }
        public static bool DoesRowExist(DateTime ValueSearch) => clsExpensesData.CheckExpensReportIsExiteForMobile(ValueSearch);

    }
}
