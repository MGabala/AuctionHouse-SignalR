using AuctionHouse_SignalR.Model;
using AuctionHouse_SignalR.Repositories;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace AuctionHouse_SignalR.Hubs
{
    public class AuctionHub : Hub
    {
        private readonly IAcutionRepository _repository;

        public AuctionHub(IAcutionRepository repository)
        {
            _repository = repository;
        }
        [BindProperty]
        public Auction _Auction { get; set; } = null!;
        public async Task NotifyNewBid(AuctionNotify auctionNotify)
        {
            await Clients.All.SendAsync("ReceiveNewBid", auctionNotify);
            await _repository.NewBid(auctionNotify.AuctionId, auctionNotify.NewBid);
        }
        public async Task TestMethod()
        {

        }
    }
}
