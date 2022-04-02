using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Presentation.Controllers
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
