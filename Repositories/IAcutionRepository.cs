namespace AuctionHouse_SignalR.Repositories
{
    public interface IAcutionRepository 
    {
        public Task<IEnumerable<Auction>> GetAllAsync();
       public void NewBid(Auction auction, int newBid);
    }
}
