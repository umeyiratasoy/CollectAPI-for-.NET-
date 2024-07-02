namespace CollectAPI.Models.Exchange
{
    public class LiveStockModel
    {
        public bool Success { get; set; }
        public List<LiveStockResult> Result { get; set; }


    }
    public class LiveStockResult
    {
        public string Currency { get; set; }
        public string Name { get; set; }
        public string PriceStr { get; set; }
        public decimal Price { get; set; }
        public decimal Rate { get; set; }
        public string Time { get; set; }
    }
}
