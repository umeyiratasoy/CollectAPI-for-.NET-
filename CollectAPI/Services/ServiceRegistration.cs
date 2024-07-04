using CollectAPI.Abstractions.Services;

namespace CollectAPI.Services
{
    public static class ServiceRegistration
    {
        public static void AddCollectServices(this IServiceCollection services)
        {
            services.AddScoped<IIpToLocationService,IpToLocationService>();
            services.AddScoped<IExchangeService, ExchangeService>();

        }
    }
}
