using BussinesLayerApi;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static DataAccessesLayerApi.clsDataSaleReportss;
using static DataAccessesLayerApi.clsExpensesData;

namespace TissueApi.Controllers
{
    [Route("api/Tissue")]
    [ApiController]
    public class ExpenseReportController : ControllerBase
    {
        [HttpGet("GetExpenseReport/{ValueSearch}", Name = "GetExpenseReport")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ActionResult<IEnumerable<ExpDTO>> GetExpenseReport( DateTime ValueSearch)
        {
            List<ExpDTO> Reports = clsExpensesReport.GetAllRows( ValueSearch);

            if (Reports == null || Reports.Count == 0)
            {
                return NotFound("No Reports Found!");
            }
            return Ok(Reports);
        }
        [HttpPost("AddExpenseReport", Name = "AddExpenseReport")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<ExpDTO> AddExpenseReport(ExpDTO saleDTO)
        {
            //we validate the data here
            if (saleDTO == null)
            {
                return BadRequest("Invalid saleDTO data.");
            }

            clsExpensesReport SaleReport = new clsExpensesReport(new ExpDTO(saleDTO.ExpenseDate,
                saleDTO.CountBills, saleDTO.Total, saleDTO.Amount, saleDTO.Name));

            if (SaleReport.Save())

            {
                return Ok();
            }
            else
            {
                return StatusCode(500, new { message = "Error adding BeltRank" });

            }


        }

        [HttpGet("existsEx/{ValueSearch}", Name = "ExistsExpensesReport")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<bool> ExistsExpensesReport(DateTime ValueSearch)
        {
            if (ValueSearch == null)
            {
                return BadRequest($"Not accepted  {ValueSearch}");
            }

            if (clsExpensesReport.DoesRowExist(ValueSearch))
            {
                return Ok(true);
            }
            else
            {
                return NotFound(false);
            }
        }
    }
}

