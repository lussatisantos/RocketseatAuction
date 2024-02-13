using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RocketseatAuction.API.Controllers;

public class OfferControlller : RocketseatAuctionBaseController
{
    [HttpPost]
    [Route("{itemId}")]
    public IActionResult CreateOffer([FromRoute]int itemId)
    {
        return Created();
    }
}
