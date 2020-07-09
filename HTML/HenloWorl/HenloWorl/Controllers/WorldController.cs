using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HenloWorl.Models;

namespace HenloWorl.Controllers
{
    public class WorldController : Controller
    {
        private readonly ILogger<WorldController> _logger;

        public WorldController(ILogger<WorldController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View("Index", "this string is model");
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
