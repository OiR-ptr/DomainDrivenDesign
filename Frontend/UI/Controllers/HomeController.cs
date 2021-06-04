using ApiClient.Backend;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UI.Models;
using UI.ViewModels.Home;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly TestClientFactory _factory;

        private readonly ILogger<HomeController> _logger;

        public HomeController(TestClientFactory factory, ILogger<HomeController> _logger)
        {
            _factory = factory;
        }

        public async Task<IActionResult> Index()
        {
            var weatherClient = _factory.CreateWeatherForecast();
            var response = await weatherClient.GetAsync();
            var viewModel = new IndexViewModel
            {
                Summaries = response.Select(item => item.Summary),
            };
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
