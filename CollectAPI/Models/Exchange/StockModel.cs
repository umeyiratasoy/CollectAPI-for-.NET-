namespace CollectAPI.Models.Exchange
{
    public class StockModel
    {
        public bool Success { get; set; }
        public List<StockResult> Result { get; set; }
    }

    public class StockResult
    {
        public double Rate { get; set; }
        public double LastPrice { get; set; }
        public string LastPriceStr { get; set; }
        public double Hacim { get; set; }
        public string HacimStr { get; set; }
        public string Text { get; set; }
        public string Code { get; set; }

    }
}
