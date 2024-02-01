using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_DEMO.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult WelcomeDefault()
        {
            return Content("Bienvenue dans ma nouvelle application!");
        }

        public IActionResult WelcomeName(string nom, string prenom)
        {
            return View("Salut " + prenom + " " + nom + "! Bienvenue dans ma nouvelle application!");
        }
    }
}
