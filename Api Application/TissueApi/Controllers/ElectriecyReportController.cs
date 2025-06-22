using BussinesLayerApi;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static DataAccessesLayerApi.clsDataSaleReportss;
using static DataAccessesLayerApi.clsElectrictyData;
using static DataAccessesLayerApi.clsRaawMatirailsData;

namespace TissueApi.Controllers
{
    [Route("api/Tissue")]
    [ApiController]
    public class ElectriecyReportController : ControllerBase
    {

        [HttpGet("GetEleReport/{ValueSearch}", Name = "GetEleReport")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ActionResult<IEnumerable<ElectDTO>> GetEleReport(DateTime ValueSearch)
        {
            List<ElectDTO> Reports = clsElectrictyReport.GetAllRows(ValueSearch);

            if (Reports == null || Reports.Count == 0)
            {
                return NotFound("No Reports Found!");
            }
            return Ok(Reports);
        }

        [HttpPost("AddEleReport", Name = "AddEleReport")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<ElectDTO> AddEleReport(ElectDTO saleDTO)
        {
            //we validate the data here
            if (saleDTO == null)
            {
                return BadRequest("Invalid saleDTO data.");
            }

            clsElectrictyReport SaleReport = new clsElectrictyReport(new ElectDTO(saleDTO.date
               , saleDTO.TypeOf, saleDTO.Total, saleDTO.Quantity));

            if (SaleReport.Save())

            {
                return Ok();
            }
            else
            {
                return StatusCode(500, new { message = "Error adding BeltRank" });

            }


        }

        [HttpGet("existsE/{ValueSearch}", Name = "ExistsElectrictyReport")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<bool> ExistsElectrictyReport(DateTime ValueSearch)
        {
            if (ValueSearch == null)
            {
                return BadRequest($"Not accepted  {ValueSearch}");
            }

            if (clsElectrictyReport.DoesRowExist(ValueSearch))
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