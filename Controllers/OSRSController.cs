using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiscoreTracker.Controllers
{
    public class OSRSController : Controller
    {
        public string Index()
        {
            return "hello.";
        }

        [HttpGet]
        public IActionResult Track(string player)
        {
            ViewData["Player"] = player;

            return View();
        }
    }
}
