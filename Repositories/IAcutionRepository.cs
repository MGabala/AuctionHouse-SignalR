namespace AuctionHouse_SignalR.Repositories
{
    public interface IAcutionRepository 
    {
        IEnumerable<Auction> GetAll();
        void NewBid(int auctionId, int newBid);
    }
}
