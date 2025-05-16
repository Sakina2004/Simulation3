using Microsoft.AspNetCore.Mvc;

namespace Simulation3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
