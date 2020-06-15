using System;
using Microsoft.AspNetCore.Mvc;

namespace TimeDisplay.Controllers
{
    public class TimeDisplayController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            DateTime now = DateTime.Now;
            ViewBag.date = now.ToString("MMM d, yyyy");
            ViewBag.time = now.ToString("h:mm tt");
            return View("index");
        }

    }
} 