using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

// ReSharper disable AssignNullToNotNullAttribute

namespace LBTDTools.Controllers
{
    public class HomeController : Controller
    {
        protected HttpContext Context => Request.HttpContext.RequestServices.GetService<IHttpContextAccessor>()?.HttpContext;
        
        public async Task<IActionResult> Index() =>
            View("Index");
    }
}