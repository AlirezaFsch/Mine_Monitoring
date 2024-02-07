using Microsoft.AspNetCore.Mvc;
using Mine_Monitoring.Models;
using System.Collections.Generic;

namespace Mine_Monitoring.Controllers
{
    public class MapController : Controller
    {
        public IActionResult Index()
        {
            // Sample data for demonstration purposes
            var model = new MapViewModel
            {
                Provinces = new List<ProvinceViewModel>
                {
                    new ProvinceViewModel { Name = "Tehran", MineCount = 20 },
                    new ProvinceViewModel { Name = "Isfahan", MineCount = 15 },
                    new ProvinceViewModel { Name = "East Azerbaijan", MineCount = 8 },
                    new ProvinceViewModel { Name = "West Azerbaijan", MineCount = 12 },
                    new ProvinceViewModel { Name = "Ardabil", MineCount = 5 },
                    new ProvinceViewModel { Name = "Bushehr", MineCount = 7 },
                    new ProvinceViewModel { Name = "Chaharmahal and Bakhtiari", MineCount = 3 },
                    new ProvinceViewModel { Name = "Fars", MineCount = 18 },
                    new ProvinceViewModel { Name = "Gilan", MineCount = 10 },
                    new ProvinceViewModel { Name = "Golestan", MineCount = 6 },
                    new ProvinceViewModel { Name = "Hamadan", MineCount = 9 },
                    new ProvinceViewModel { Name = "Hormozgan", MineCount = 4 },
                    new ProvinceViewModel { Name = "Ilam", MineCount = 2 },
                    new ProvinceViewModel { Name = "Kerman", MineCount = 14 },
                    new ProvinceViewModel { Name = "Kermanshah", MineCount = 11 },
                    new ProvinceViewModel { Name = "North Khorasan", MineCount = 5 },
                    new ProvinceViewModel { Name = "Razavi Khorasan", MineCount = 17 },
                    new ProvinceViewModel { Name = "South Khorasan", MineCount = 4 },
                    new ProvinceViewModel { Name = "Khuzestan", MineCount = 16 },
                    new ProvinceViewModel { Name = "Kohgiluyeh and Boyer-Ahmad", MineCount = 3 },
                    new ProvinceViewModel { Name = "Kurdistan", MineCount = 7 },
                    new ProvinceViewModel { Name = "Lorestan", MineCount = 10 },
                    new ProvinceViewModel { Name = "Markazi", MineCount = 8 },
                    new ProvinceViewModel { Name = "Mazandaran", MineCount = 12 },
                    new ProvinceViewModel { Name = "Qazvin", MineCount = 6 },
                    new ProvinceViewModel { Name = "Qom", MineCount = 4 },
                    new ProvinceViewModel { Name = "Semnan", MineCount = 7 },
                    new ProvinceViewModel { Name = "Sistan and Baluchestan", MineCount = 9 },
                    new ProvinceViewModel { Name = "Yazd", MineCount = 13 },
                    new ProvinceViewModel { Name = "Zanjan", MineCount = 5 },
                    new ProvinceViewModel { Name = "Alborz", MineCount = 11 }
                }
            };
            return View(model);
        }
    }
}
