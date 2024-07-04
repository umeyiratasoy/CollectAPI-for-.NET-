using CollectAPI.Abstractions.Services;
using CollectAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CollectAPI.Controllers
{
    public class IpLocationController : Controller
    {
        private readonly IIpToLocationService _ipToLocationService;

        public IpLocationController(IIpToLocationService ipToLocationService)
        {
            _ipToLocationService = ipToLocationService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string ip)
        {
            if (string.IsNullOrEmpty(ip))
            {
                ModelState.AddModelError(string.Empty, "Please enter a valid IP address.");
                return View();
            }

            try
            {
                var locationData = await _ipToLocationService.GetIpToLocationDataAsync(ip);
                return View(locationData);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "Error fetching data from API.");
                return View();
            }
        }
    }
}
