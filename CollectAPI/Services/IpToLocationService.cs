using CollectAPI.Abstractions.Services;
using CollectAPI.Models.IpLocation;
using Newtonsoft.Json;

namespace CollectAPI.Services
{
    public class IpToLocationService : IIpToLocationService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public IpToLocationService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IpLocationModel> GetIpToLocationDataAsync(string ip)
        {
            var client = _httpClientFactory.CreateClient("collectApi");
            string endpoint = $"/ip/ipToLocation?data.ip={ip}";
            var response = await client.GetAsync(endpoint);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var model = JsonConvert.DeserializeObject<IpLocationModel>(content);
                return model;
            }
            else
            {
                throw new Exception("Error fetching data from API.");
            }
        }
    }
}
