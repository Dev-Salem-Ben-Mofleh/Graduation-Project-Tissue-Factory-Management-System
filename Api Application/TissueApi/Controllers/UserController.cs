using BussinesLayerApi;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static DataAccessesLayerApi.clsRaawMatirailsData;
using static DataAccessesLayerApi.clsUserData;

namespace TissueApi.Controllers
{
    [Route("api/Tissue")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet("GetUser/{UserName}/{Password}", Name = "GetUser")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ActionResult<IEnumerable<UserDTO>> GetUser(string UserName, string Password)
        {
            List<UserDTO> User = clsUser.GetAllRows(UserName, Password);

            if (User == null || User.Count == 0)
            {
                return NotFound("No User Found!");
            }
            return Ok(User);
        }

    }
}
