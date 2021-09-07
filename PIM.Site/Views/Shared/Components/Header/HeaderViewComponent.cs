using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace PIM.Site.Views.Shared.Components.Header
{
    public class HeaderViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
