namespace CollectAPI.Models.IpLocation
{
    public class IpLocationModel
    {
        public bool Success { get; set; }
        public Result Result { get; set; }
    }

    public class Result
    {
        public string Ip { get; set; }
        public string Type { get; set; }
        public string Country_Name { get; set; }
        public string RegionCode { get; set; }
        public string RegionName { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
