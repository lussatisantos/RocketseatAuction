using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Contracts;

public class IAuctionRepository
{
    Auction? GetCurrent();
}
