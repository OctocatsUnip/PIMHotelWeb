using Microsoft.AspNetCore.Mvc;

namespace PIM.Site.Controllers
{
    public class PoliticaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
