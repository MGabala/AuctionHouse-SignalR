using Microsoft.AspNetCore.SignalR;

namespace AuctionHouse_SignalR.Hubs
{
    public class AuctionHub : Hub
    {
        public async Task NotifyNewBid(AuctionNotify auctionNotify)
        {
            await Clients.All.SendAsync("ReceiveNewBid", auctionNotify);
        }
    }
}
