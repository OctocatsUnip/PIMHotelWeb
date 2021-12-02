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
            ViewData["Title"] = "Detalhes quarto";
            return View();
        }

        [Route("confirmar-reserva")]
        public IActionResult ConfirmarReserva()
        {
            ViewData["Title"] = "Confirmar Reserva";
            return View();
        }
    }
}
