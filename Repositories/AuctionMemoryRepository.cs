namespace AuctionHouse_SignalR.Repositories
{
    public class AuctionMemoryRepository : IAcutionRepository
    {
        private readonly List<Auction> auctions = new List<Auction>();

        public AuctionMemoryRepository()
        {
            auctions.Add(new Auction { Id = 1, ItemName = "Mechaniczna klawiatura", CurrentBid = 23 });
            auctions.Add(new Auction { Id = 2, ItemName = "Monitor gamingowy", CurrentBid = 4 });
            auctions.Add(new Auction { Id = 3, ItemName = "Fotel biurowy", CurrentBid = 143 });
            auctions.Add(new Auction { Id = 4, ItemName = "Kubek", CurrentBid = 12 });
            auctions.Add(new Auction { Id = 5, ItemName = "Okulary VR", CurrentBid = 3 });
        }

        public IEnumerable<Auction> GetAll()
        {
            return auctions;
        }

        public void NewBid(int auctionId, int newBid)
        {
            var auction = auctions.Single(a => a.Id == auctionId);
            auction.CurrentBid = newBid;
        }
    }
}
