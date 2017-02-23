using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace code_camp_template.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "The 2017 South Florida Code Camp sample template for asp.net Core and Visual Studio Code.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Adrian Gabor.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
