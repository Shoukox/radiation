using mame.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace mame.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Radiation()
        {
            return View();
        }
        public IActionResult Radioaktiv()
        {
            return View();
        }

        public IActionResult Izluchtypes()
        {
            return View();
        }
        public IActionResult Doziobluch()
        {
            return View();
        }
        public IActionResult Doziistoch()
        {
            return View();
        }
        public IActionResult Radandpit()
        {
            return View();
        }
        public IActionResult Kakieprod()
        {
            return View();
        }
        public IActionResult Prigovosh()
        {
            return View();
        }
        public IActionResult Prigmoloko()
        {
            return View();
        }
        public IActionResult Prigmyaso()
        {
            return View();
        }
        public IActionResult Zdoroviy()
        {
            return View();
        }
        public IActionResult Radmonit()
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
