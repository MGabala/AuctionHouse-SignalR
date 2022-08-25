using AuctionHouse_SignalR.Repositories;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AuctionHouse_SignalR.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IAcutionRepository _repository;
        public IEnumerable<Auction> Auctions { get; set; }
        [BindProperty]
        public Auction _Auction { get; set; } = null!;

        public IndexModel(ILogger<IndexModel> logger, IAcutionRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public async Task OnGetAsync()
        {
            Auctions = await _repository.GetAllAsync();
        }
        public async Task<IActionResult> OnPostBid(int auctionId, int newBid)
        {
            _Auction.Id = auctionId;
           // _repository.NewBid(_Auction, newBid);
            return RedirectToPage("Index");
        }
    }
}