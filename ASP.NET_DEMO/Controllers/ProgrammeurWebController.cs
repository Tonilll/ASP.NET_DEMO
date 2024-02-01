using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_DEMO.Controllers
{
    public class ProgrammeurWebController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult A23()
        {
            return View("A23");
        }

        public IActionResult A21()
        {
            return View();
        }


        public IActionResult H24(string id)
        {
            
            if (string.IsNullOrWhiteSpace(id))
            {
                return View();
            }
            if(id.ToUpper() == "4P7")
            {
                ViewBag.TitreCours = "ASP";
                return View("Cours");
            }
            else if (id.ToUpper() == "4P6")
            {
                ViewBag.TitreCours = "PHP";
                return View("Cours");
            }
            return Content("Cours innexistant");
        }
    }
}
