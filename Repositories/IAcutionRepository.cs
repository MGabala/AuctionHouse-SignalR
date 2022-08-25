namespace AuctionHouse_SignalR.Repositories
{
    public interface IAcutionRepository 
    {
        public Task<IEnumerable<Auction>> GetAllAsync();
       public Task NewBid(int id, int newBid);
    }
}
