using Microsoft.AspNetCore.Mvc;

namespace Simulation3.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TrainerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
