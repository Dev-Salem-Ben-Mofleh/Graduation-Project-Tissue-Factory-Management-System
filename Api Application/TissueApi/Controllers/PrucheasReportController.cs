using BussinesLayerApi;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static DataAccessesLayerApi.clsDataPurchases;
using static DataAccessesLayerApi.clsDataSaleReportss;

namespace TissueApi.Controllers
{
    [Route("api/Tissue")]
    [ApiController]
    public class PrucheasReportController : ControllerBase
    {
        [HttpGet("GetPurcheasReport/{ValueSearch}", Name = "GetPurcheasReport")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ActionResult<IEnumerable<PurchDTO>> GetPurcheasReport( DateTime ValueSearch)
        {
            List<PurchDTO> Reports = clsPruchaseReport.GetAllRows( ValueSearch);

            if (Reports == null || Reports.Count == 0)
            {
                return NotFound("No Reports Found!");
            }
            return Ok(Reports);
        }


        [HttpPost("AddPruchaseReport", Name = "AddPruchaseReport")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<PurchDTO> AddPruchaseReport(PurchDTO saleDTO)
        {
            //we validate the data here
            if (saleDTO == null)
            {
                return BadRequest("Invalid saleDTO data.");
            }

            clsPruchaseReport SaleReport = new clsPruchaseReport(new PurchDTO(saleDTO.SaleDate,
                saleDTO.CountBills, saleDTO.Total, saleDTO.RawMatiral, saleDTO.Name, saleDTO.PaidBill,
                saleDTO.NotPaidBill));

            if (SaleReport.Save())

            {
                return Ok();
            }
            else
            {
                return StatusCode(500, new { message = "Error adding BeltRank" });

            }


        }
        [HttpGet("existsP/{ValueSearch}", Name = "ExistsclsPruchaseReport")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<bool> ExistsclsPruchaseReport(DateTime ValueSearch)
        {
            if (ValueSearch == null)
            {
                return BadRequest($"Not accepted  {ValueSearch}");
            }

            if (clsPruchaseReport.DoesRowExist(ValueSearch))
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
