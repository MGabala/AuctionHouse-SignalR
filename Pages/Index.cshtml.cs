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

        public IndexModel(ILogger<IndexModel> logger, IAcutionRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public async Task OnGetAsync()
        {
            Auctions = _repository.GetAll();
        }
    }
}