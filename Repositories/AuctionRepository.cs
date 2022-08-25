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

        public async Task NewBid(int id, int newBid)
        {
            var auctionforupdate = _context.Auctions.SingleOrDefault(x => x.Id == id);
            auctionforupdate.CurrentBid = newBid;
            await _context.SaveChangesAsync();
        }
    }
}
