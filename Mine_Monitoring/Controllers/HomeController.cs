using Microsoft.AspNetCore.Mvc;
using Mine_Monitoring.Models;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
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

            // Sample data for the view
            var model = new HomeViewModel
            {
                Years = new List<string> { "1399", "1400", "1401", "1402", "1403" },
                MiningIndustryData = new List<double> { 5000, 6000, 7000, 8000, 9000 },
                GDPData = new List<double> { 120000, 130000, 140000, 150000, 160000 },
                MiningShareOfGDPData = new List<double> { 10, 12, 14, 15, 16 },
                OtherCountriesComparisonData = new List<CountryComparisonData>
                {
                    new CountryComparisonData { CountryName = "USA", GDP = 200000, MiningIndustryValue = 10000 },
                    new CountryComparisonData { CountryName = "China", GDP = 250000, MiningIndustryValue = 15000 },
                    new CountryComparisonData { CountryName = "Russia", GDP = 180000, MiningIndustryValue = 12000 },
                    new CountryComparisonData { CountryName = "Australia", GDP = 160000, MiningIndustryValue = 18000 },
                    new CountryComparisonData { CountryName = "Iran", GDP = 190000, MiningIndustryValue = 20000 } // Adding Iran's GDP
                }
            };

            return View(model);
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
