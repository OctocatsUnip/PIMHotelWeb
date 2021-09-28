using Microsoft.AspNetCore.Mvc;
using PIM.Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIM.Site.Views.Shared.Components.Banner
{
    public class BannerViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string pagina)
        {

            var banner = new BannerViewModel();

            switch (pagina)
            {
                case "contato":
                    banner.CaminhoImg = "cidade-a-noite.jpg";
                    banner.Title = "Entre em contato";
                    break;
                case "politica":
                    banner.CaminhoImg = "politica.jpg";
                    banner.Title = "Política de Privacidade";
                    break;
                case "servicos":
                    banner.CaminhoImg = "3.jpg";
                    banner.Title = "Escolha seu quarto";
                    break;
            }            

            return View(banner);
        }
    }
}
