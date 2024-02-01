using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_DEMO.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Vue");
        }
    }
}
