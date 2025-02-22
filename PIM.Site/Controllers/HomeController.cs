﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PIM.Site.Controllers
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
            ViewData["Title"] = "Hotel Cecil";
            return View();
        }        

    }
}
