using Microsoft.AspNetCore.Mvc;
using RocketseatAuction.API.Entities;
using RocketseatAuction.API.Enums;
using RocketseatAuction.API.UseCases.Auctions.GetCurrent;

namespace RocketseatAuction.API.Controllers
{
    public class AuctionController : RocketseatAuctionBaseController
    {
        [HttpGet]
        [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetCurrentAuction([FromServices] GetCurrentAuctionUseCase useCase)
        {
           
            var result = useCase.Execute();

            /*
            var item = result.Items.First();
            if (item.Condition == Condition.NEW)
                throw new Exception();
            */

            if(result is null)
            {
                return NoContent();
            }

            // retornos:
                // Ok() status code 200
                // Created() criado com sucesso 201
                // NotFound()
                // Unauthorized() usuario nao esta autorizado
            return Ok(result);
        }

        [HttpPost]
        public IActionResult CreateOffer()
        {
            return Created();
        }
    }
}
