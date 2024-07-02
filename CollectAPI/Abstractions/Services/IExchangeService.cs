using CollectAPI.Models.Exchange;

namespace CollectAPI.Abstractions.Services
{
    public interface IExchangeService
    {
        Task<ExchangeModel> GetExchangeDataAsync();
        Task<StockModel> GetStockDataAsync();
        Task<LiveStockModel> GetLiveStockDataAsync();
        Task<GoldModel> GetGoldDataAsync();
        Task<ForeignCurrencyModel> GetForeignCurrencyDataAsync();
    }
}
