using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Mine_Monitoring.Models;

namespace Mine_Monitoring.Controllers
{
    public class ChartsController : Controller
    {
        public IActionResult Index()
        {
            var random = new Random();

            var minerals = new List<MineralProductionData>
            {
                new MineralProductionData { Name = "Cu", Color = "rgba(255, 0, 0, 0.5)" },
                new MineralProductionData { Name = "Fe", Color = "rgba(0, 255, 0, 0.5)" },
                new MineralProductionData { Name = "Au", Color = "rgba(0, 0, 255, 0.5)" }
            };

            foreach (var mineral in minerals)
            {
                mineral.Production = Enumerable.Range(1392, 11) // Years from 1392 to 1402
                    .Select(year => random.Next(1000, 5000)) // Random production values
                    .ToList();
            }

            var model = new ChartsViewModel
            {
                Provinces = new List<string> { "تهران", "اصفهان", "کرمان", "شیراز", "تبریز", "یزد" },
                MineCounts = new List<int> { 2, 10, 20, 3, 5, 15 },
                MineStatus = new List<string> { "فعال", "غیرفعال", "تحت اکتشاف" },
                MineStatusCounts = new List<int> { 67, 17, 16 },
                Years = Enumerable.Range(1392, 11).Select(year => year.ToString()).ToList(), // Years from 1392 to 1402
                ProductionOverYears = Enumerable.Range(0, 11).Select(_ => random.Next(1000, 5000)).ToList(), // Sample production data over 11 years
                MineralProduction = minerals
            };
            return View(model);
        }
    }
}
