using AOSWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AOSWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string? Search)
        {
            return View();
        }
        public IActionResult Product()
        {
            return View();
        }
        public IActionResult Product2()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Faqs()
        {
            return View();
        }
        public IActionResult Help()
        {
            return View();
        }
        public IActionResult Payment()
        {
            return View();
        }
        public IActionResult Single()
        {
            return View();
        }
        public IActionResult Single2()
        {
            return View();
        }
        public IActionResult Terms()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Search(string Search)
        {
            return RedirectToAction("index",new { Search = Search});
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
