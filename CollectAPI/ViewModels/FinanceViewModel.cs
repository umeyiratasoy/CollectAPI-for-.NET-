using CollectAPI.Models.Exchange;

namespace CollectAPI.ViewModels
{
    public class FinanceViewModel
    {
        public ExchangeModel ExchangeData { get; set; }
        public StockModel StockData { get; set; }
        public LiveStockModel LiveStockData { get; set; }
        public GoldModel GoldData { get; set; }
        public ForeignCurrencyModel ForeignCurrencyData { get; set; }
    }
}
