using BussinesLayerApi;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static DataAccessesLayerApi.clsDataSaleReportss;
using static DataAccessesLayerApi.clsPrudctionData;

namespace TissueApi.Controllers
{
    [Route("api/Tissue")]
    [ApiController]
    public class PrudctionReportController : ControllerBase
    {
        [HttpGet("GetPrudctionReport/{ValueSearch}", Name = "GetPrudctionReport")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ActionResult<IEnumerable<ProdctionDTO>> GetPrudctionReport( DateTime ValueSearch)
        {
            List<ProdctionDTO> Reports = clsPrudtionReport.GetAllRows( ValueSearch);

            if (Reports == null || Reports.Count == 0)
            {
                return NotFound("No Reports Found!");
            }
            return Ok(Reports);
        }

        [HttpPost("AddProudoctionReport", Name = "AddProudoctionReport")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<ProdctionDTO> AddProudoctionReport(ProdctionDTO saleDTO)
        {
            //we validate the data here
            if (saleDTO == null)
            {
                return BadRequest("Invalid saleDTO data.");
            }

            clsPrudtionReport SaleReport = new clsPrudtionReport(new ProdctionDTO(saleDTO.ProductionDate,
                saleDTO.ProductName, saleDTO.Quantity, saleDTO.DamagedQuantity, saleDTO.Material_Name, saleDTO.RawAmount));

            if (SaleReport.Save())

            {
                return Ok();
            }
            else
            {
                return StatusCode(500, new { message = "Error adding BeltRank" });

            }


        }


        [HttpGet("existsPr/{ValueSearch}", Name = "ExistsPrudtionReport")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<bool> ExistsPrudtionReport(DateTime ValueSearch)
        {
            if (ValueSearch == null)
            {
                return BadRequest($"Not accepted  {ValueSearch}");
            }

            if (clsPrudtionReport.DoesRowExist(ValueSearch))
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
