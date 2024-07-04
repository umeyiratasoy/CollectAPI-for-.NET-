using CollectAPI.Models.IpLocation;

namespace CollectAPI.Abstractions.Services
{
    public interface IIpToLocationService
    {
        Task<IpLocationModel> GetIpToLocationDataAsync(string ip);

    }
}
