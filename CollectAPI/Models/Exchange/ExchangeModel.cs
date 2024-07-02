using System;

namespace CollectAPI.Models.Exchange
{
    public class ExchangeModel
    {
        public bool Success { get; set; }
        public ExchangeResult[] Result { get; set; }
    }

    public class ExchangeResult
    {
        public string Currentstr { get; set; }
        public double Current { get; set; }
        public string Changeratestr { get; set; }
        public double Changerate { get; set; }
        public string Minstr { get; set; }
        public double Min { get; set; }
        public string Maxstr { get; set; }
        public double Max { get; set; }
        public string Openingstr { get; set; }
        public double Opening { get; set; }
        public string Closingstr { get; set; }
        public double Closing { get; set; }
        public string Time { get; set; }
        public string Date { get; set; }
        public DateTime Datetime { get; set; }
    }
}
