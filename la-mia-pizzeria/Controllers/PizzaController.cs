using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
