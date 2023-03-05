using Microsoft.AspNetCore.Mvc;

namespace ILuxDe.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
