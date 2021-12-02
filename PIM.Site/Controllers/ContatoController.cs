using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIM.Site.Controllers
{
    public class ContatoController : Controller
    {
        [Route("contato")]
        public IActionResult Index()
        {
            ViewData["Title"] = "Contato";
            return View();
        }
    }
}
