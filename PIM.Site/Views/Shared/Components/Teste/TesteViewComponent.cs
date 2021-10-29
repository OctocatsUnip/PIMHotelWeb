using PIM.Site.Models;
//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
//using System.Text.Encodings;

namespace PIM.Site.Views.Shared.Components.Teste
{
    public class TesteViewComponent : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            HttpClient httpClient = new HttpClient()
            {
                Timeout = TimeSpan.FromSeconds(10)
            };

            var url = "http://localhost:5000/quarto";
            JsonSerializerOptions opt = new JsonSerializerOptions()
            {                
                PropertyNameCaseInsensitive = true,

            };

            var result2 = httpClient.GetStringAsync(url).Result; //já pega content como string
            //var result = httpClient.GetAsync(url).Result;

            //if (result.StatusCode != HttpStatusCode.OK)
            //{
            //    return new List<TesteViewModel>();
            //}

            //result.EnsureSuccessStatusCode();

            //string resultTotal = await result2.ReadAsStringAsync();
            //var resultObject = JsonConvert.DeserializeObject<List<TesteViewModel>>(resultTotal);
            var resultObject = JsonSerializer.Deserialize<List<TesteViewModel>>(result2, opt);
            //var resultObject2 = JsonSerializer.Deserialize<dynamic>(result2, opt);

            return View(resultObject);
        }
    }
}
