using Microsoft.AspNetCore.Mvc;

namespace RocketseatAuction.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuctionController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCurrentAuction()
        {

            // retornos:
                // Ok() status code 200
                // Created() criado com sucesso 201
                // NotFound()
                // Unauthorized() usuario nao esta autorizado
            return NotFound("Lussati");
        }
    }
}
