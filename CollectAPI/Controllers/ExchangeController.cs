using CollectAPI.Abstractions.Services;
using CollectAPI.Models.Exchange;
using CollectAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace CollectAPI.Controllers
{
   
    public class ExchangeController : Controller
    {

        private readonly IExchangeService _exchangeService;

        public ExchangeController(IExchangeService exchangeService)
        {
            _exchangeService = exchangeService;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var exchangeModel = await _exchangeService.GetExchangeDataAsync();
                var stockModel = await _exchangeService.GetStockDataAsync();
                var liveStockModel = await _exchangeService.GetLiveStockDataAsync();
                GoldModel goldModel = await _exchangeService.GetGoldDataAsync();
                var foreignCurrencyModel = await _exchangeService.GetForeignCurrencyDataAsync();

                var viewModel = new FinanceViewModel
                {
                    ExchangeData = exchangeModel,
                    StockData = stockModel,
                    LiveStockData = liveStockModel,
                    GoldData = goldModel,
                    ForeignCurrencyData = foreignCurrencyModel
                };
                return View(viewModel);
            }
            catch (Exception ex)
            {
                // Handle error
                return Content("Error fetching data from API: " + ex.Message);
            }
        }

        
    }
}
