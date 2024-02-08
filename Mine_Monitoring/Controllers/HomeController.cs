using Microsoft.AspNetCore.Mvc;
using Mine_Monitoring.Models;
using System.Diagnostics;


namespace Mine_Monitoring.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Example data for sidebar menu
            var sidebarItems = new List<MenuItem>
            {
                new MenuItem { Text = "صفحه اصلی", Url = Url.Action("Index", "Home") },
                new MenuItem { Text = "داشبورد مانیتورینگ معدن", Url = Url.Action("Index", "Charts") },
                // Add more menu items as needed
            };

            // Pass data to the view
            ViewData["SidebarItems"] = sidebarItems;

            return View();
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
