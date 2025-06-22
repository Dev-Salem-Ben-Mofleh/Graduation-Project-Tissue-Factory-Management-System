using BussinesLayerApi;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static DataAccessesLayerApi.clsDataSaleReportss;
using static DataAccessesLayerApi.clsPrudctionData;
using static DataAccessesLayerApi.clsRaawMatirailsData;

namespace TissueApi.Controllers
{
    [Route("api/Tissue")]
    [ApiController]
    public class RawMAtiralsReportController : ControllerBase
    {
        [HttpGet("GetRawReport/{ValueSearch}", Name = "GetRawReport")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ActionResult<IEnumerable<RawDTO>> GetRawReport(DateTime ValueSearch)
        {
            List<RawDTO> Reports = clsRaawMatirailsReport.GetAllRows( ValueSearch);

            if (Reports == null || Reports.Count == 0)
            {
                return NotFound("No Reports Found!");
            }
            return Ok(Reports);
        }

        [HttpPost("AddRaawMatirailsReport", Name = "AddRaawMatirailsReport")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<RawDTO> AddRaawMatirailsReport(RawDTO saleDTO)
        {
            //we validate the data here
            if (saleDTO == null)
            {
                return BadRequest("Invalid saleDTO data.");
            }

            clsRaawMatirailsReport SaleReport = new clsRaawMatirailsReport(new RawDTO(saleDTO.ProductionDate,
                 saleDTO.Material_Name, saleDTO.RawAmount, saleDTO.Quantity));

            if (SaleReport.Save())

            {
                return Ok();
            }
            else
            {
                return StatusCode(500, new { message = "Error adding BeltRank" });

            }


        }
        [HttpGet("existsR/{ValueSearch}", Name = "ExistsRaawMatirailsReport")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<bool> ExistsRaawMatirailsReport(DateTime ValueSearch)
        {
            if (ValueSearch == null)
            {
                return BadRequest($"Not accepted  {ValueSearch}");
            }

            if (clsRaawMatirailsReport.DoesRowExist(ValueSearch))
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
