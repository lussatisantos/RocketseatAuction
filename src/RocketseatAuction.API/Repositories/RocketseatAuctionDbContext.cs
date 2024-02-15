﻿using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Writers;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Repositories;

public class RocketseatAuctionDbContext : DbContext
{
    public DbSet<Auction> Auctions { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Offer> Offers { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source=C:\Users\1\OneDrive\Documentos\GitHub\RocketseatAuction\db\leilaoDbNLW.db");
    }
}
