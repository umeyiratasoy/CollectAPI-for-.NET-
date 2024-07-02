namespace CollectAPI.Models.Exchange
{
    public class ForeignCurrencyModel
    {
        public bool Success { get; set; }
        public List<ForeignCurrencyResult> Result { get; set; }
    }

    public class ForeignCurrencyResult
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal Buying { get; set; }
        public decimal Selling { get; set; }
        public decimal Rate { get; set; }
        public string Time { get; set; }
        public DateTime DateTime { get; set; }
    }
}
