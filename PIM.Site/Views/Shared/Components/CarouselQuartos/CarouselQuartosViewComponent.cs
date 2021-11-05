using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PIM.Site.Models;

namespace PIM.Site.Views.Shared.Components.CarouselQuartos
{
    public class CarouselQuartosViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            HttpClient httpClient = new HttpClient()
            {
                Timeout = TimeSpan.FromSeconds(10)
            };

            var url = "http://localhost:5000/quarto";
            //JsonSerializerOptions opt = new JsonSerializerOptions()
            //{
            //    PropertyNameCaseInsensitive = true,

            //};

            var result = httpClient.GetStringAsync(url).Result; //já pega content como string

            //result.EnsureSuccessStatusCode();

            var resultObject = JsonConvert.DeserializeObject<List<QuartosViewModel>>(result);
            //var resultObject = JsonSerializer.Deserialize<List<TesteViewModel>>(result2, opt);                        

            return View(resultObject);
        }
    }
}
