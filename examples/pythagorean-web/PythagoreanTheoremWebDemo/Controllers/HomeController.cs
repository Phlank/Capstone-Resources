using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PythagoreanTheoremBackend.Handlers;
using PythagoreanTheoremWebDemo.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PythagoreanTheoremWebDemo.Controllers
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
            var model = new PythagoreanViewModel
            {
                Formula = "a^2 + b^2 = c^2"
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Calculate(CalculatePostModel postModel)
        {
            var result = PythagoreanHandler.GetHypotenuse(postModel.SideOne, postModel.SideTwo);
            var model = new CalculateViewModel
            {
                Result = result
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
