using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIM.Site.Controllers
{
    public class ServicosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("detalhes-quarto")]
        public IActionResult InfoQuarto()
        {
            return View();
        }

        [Route("confirmar-reserva")]
        public IActionResult ConfirmarReserva()
        {
            return View();
        }
    }
}
