using CollectAPI.Abstractions.Services;
using CollectAPI.Models.Exchange;

namespace CollectAPI.Services
{
    public class ExchangeService : IExchangeService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ExchangeService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        private async Task<T> FetchExchangeDataAsync<T>(string endpoint)
        {
            var client = _httpClientFactory.CreateClient("collectApi");
            var response = await client.GetAsync(endpoint);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var model = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(content);
                return model;
            }
            else
            {
                throw new Exception("Error fetching data from API.");
            }
        }

        public async Task<ExchangeModel> GetExchangeDataAsync()
        {
            return await FetchExchangeDataAsync<ExchangeModel>("/economy/borsaIstanbul");
        }

        public async Task<StockModel> GetStockDataAsync()
        {
            return await FetchExchangeDataAsync<StockModel>("/economy/hisseSenedi");
        }

        public async Task<LiveStockModel> GetLiveStockDataAsync()
        {
            return await FetchExchangeDataAsync<LiveStockModel>("/economy/liveBorsa");
        }

        public async Task<GoldModel> GetGoldDataAsync()
        {
            return await FetchExchangeDataAsync<GoldModel>("/economy/goldPrice");
        }

        public async Task<ForeignCurrencyModel> GetForeignCurrencyDataAsync()
        {
            return await FetchExchangeDataAsync<ForeignCurrencyModel>("/economy/allCurrency ");
        }
    }

}
