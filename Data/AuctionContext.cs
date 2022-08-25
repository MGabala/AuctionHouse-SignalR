using Microsoft.EntityFrameworkCore;

namespace AuctionHouse_SignalR.Data
{
    public class AuctionContext : DbContext
    {
        public DbSet<Auction> Auctions { get; set; } = null!;
        public AuctionContext(DbContextOptions<AuctionContext> options) : base(options) 
        {

        }
    }
}
