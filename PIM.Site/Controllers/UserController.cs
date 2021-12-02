using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIM.Site.Controllers
{
    public class UserController : Controller
    {
        [Route("alterar-conta")]
        public IActionResult Index()
        {
            ViewData["Title"] = "Alterar Conta";
            return View();
        }

        [Route("meus-quartos")]
        public IActionResult MeusQuartos()
        {
            ViewData["Title"] = "Meus quartos";
            return View();
        }
    }
}
