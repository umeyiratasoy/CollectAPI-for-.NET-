namespace CollectAPI.Models.Exchange
{
    public class GoldModel
    {
        public bool Success { get; set; }
        public List<GoldResult> Result { get; set; }  

    }

    public class GoldResult
    {
        public string Name { get; set; }
        public decimal Buying { get; set; }
        public string BuyingStr { get; set; }
        public decimal Selling { get; set; }
        public string SellingStr { get; set; }
        public string Time { get; set; }
        public string Date { get; set; }
        public DateTime DateTime { get; set; }
        public decimal Rate { get; set; }
    }
}
