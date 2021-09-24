using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIM.Site.Controllers
{
    public class VisualizarQuarto : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
