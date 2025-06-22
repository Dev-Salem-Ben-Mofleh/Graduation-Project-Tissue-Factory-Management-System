using BussinesLayerApi;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using static DataAccessesLayerApi.clsDataSaleReportss;

namespace TissueApi.Controllers
{
    [Route("api/Tissue")]
    [ApiController]
    public class SaleReportController : ControllerBase
    {

        [HttpGet("GetSaleReport/{ValueSearch}", Name = "GetSaleReport")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ActionResult<IEnumerable<SaleDTO>> GetSaleReport( DateTime ValueSearch)
        {
            List<SaleDTO> Reports = clsSaleReport.GetAllRows(ValueSearch);

            if (Reports == null || Reports.Count == 0)
            {
                return NotFound("No Reports Found!");
            }
            return Ok(Reports);
        }

        [HttpPost("AddSaleReport", Name = "AddSaleReport")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<SaleDTO> AddSaleReport(SaleDTO saleDTO)
        {
            //we validate the data here
            if (saleDTO == null)
            {
                return BadRequest("Invalid saleDTO data.");
            }

            clsSaleReport SaleReport = new clsSaleReport(new SaleDTO(saleDTO.SaleDate,
                saleDTO.CountBills, saleDTO.Total, saleDTO.Proudct, saleDTO.Name, saleDTO.PaidBill,
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


        [HttpGet("existsS/{ValueSearch}", Name = "ExistsSaleReport")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<bool> ExistsSaleReport(DateTime ValueSearch)
        {
            if (ValueSearch == null)
            {
                return BadRequest($"Not accepted  {ValueSearch}");
            }

            if (clsSaleReport.DoesRowExist(ValueSearch))
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
