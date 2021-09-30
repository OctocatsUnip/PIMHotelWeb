using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIM.Site.Controllers
{
    public class LoginController : Controller
    {
        [Route("logar")]
        public IActionResult SingIn()
        {
            return View();
        }
    }
}
