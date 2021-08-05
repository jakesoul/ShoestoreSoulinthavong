using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShoestoreSoulinthavong.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ShoestoreSoulinthavong.Controllers
{
    public class HomeController : Controller
    {
        private ShoeContext context { get; set; }

        public HomeController(ShoeContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var shoes = context.Shoes.OrderBy(m => m.Brand).ToList();
            return View(shoes);
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
