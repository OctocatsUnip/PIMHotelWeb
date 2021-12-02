using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PIM.Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PIM.Site.Views.Shared.Components.QuartosFiltro
{
    public class QuartosFiltroViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            HttpClient httpClient = new HttpClient()
            {
                Timeout = TimeSpan.FromSeconds(10)
            };

            var url = "http://localhost:5000/quartos";
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
