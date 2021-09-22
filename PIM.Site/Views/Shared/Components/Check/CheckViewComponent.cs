using Microsoft.AspNetCore.Mvc;
using PIM.Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIM.Site.Views.Shared.Components.Check
{
    public class CheckViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {

            var check = new List<CheckViewModel>();

            check.Add(new CheckViewModel { Titulo = "Check-in", Icone = "fa-calendar-alt" });
            check.Add(new CheckViewModel { Titulo = "Check-out", Icone = "fa-calendar-alt" });

            return View(check);
        }
    }
}
