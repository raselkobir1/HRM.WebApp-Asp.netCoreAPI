using Microsoft.AspNetCore.Mvc;

namespace HRM.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["BaseUrl"] = $"{this.Request.Scheme}://{this.Request.Host}/{this.Request.PathBase}";
            return View();
        }
    }
}
