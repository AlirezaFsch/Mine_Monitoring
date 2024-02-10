// In StatisticsController.cs

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Mine_Monitoring.Controllers
{
    public class StatisticsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Action to display buttons for different Excel files
        public IActionResult ExcelFiles()
        {
            return View();
        }

        // Action to fetch and display preview of an Excel file
        public IActionResult PreviewExcel(string fileName)
        {
            // Get the path to the Excel file based on the file name
            string filePath = Path.Combine("PathToYourExcelFilesDirectory", fileName);

            // Read the Excel file and extract the first 10 rows
            // You can use a library like EPPlus or ClosedXML to read Excel files
            // For simplicity, assume we have a method ReadExcelFile that reads the file and returns the data as a list of strings
            List<string> excelData = ReadExcelFile(filePath).Take(10).ToList();

            return View(excelData);
        }

        // Method to read Excel file
        private List<string> ReadExcelFile(string filePath)
        {
            // Code to read Excel file and extract data
            // Implement this method using a library like EPPlus or ClosedXML
            // For demonstration purposes, assume it returns a list of strings
            return new List<string>();
        }
    }
}
