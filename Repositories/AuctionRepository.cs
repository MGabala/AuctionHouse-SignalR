using AuctionHouse_SignalR.Data;

using Microsoft.EntityFrameworkCore;

namespace AuctionHouse_SignalR.Repositories
{
    public class AuctionRepository : IAcutionRepository
    {
        
        
        private readonly AuctionContext _context;

        public AuctionRepository(AuctionContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Auction>> GetAllAsync()
        {
            return await _context.Auctions.ToListAsync();
        }

        public async void NewBid(Auction auction, int newBid)
        {
            var auctionforupdate = _context.Auctions.SingleOrDefault(x => x.Id == auction.Id);
            auctionforupdate.CurrentBid = newBid;
            await _context.SaveChangesAsync();
        }
    }
}
