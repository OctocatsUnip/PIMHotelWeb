﻿using Microsoft.AspNetCore.Mvc;

namespace PIM.Site.Controllers
{
    public class SobreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
