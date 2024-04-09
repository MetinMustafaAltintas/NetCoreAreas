using Microsoft.AspNetCore.Mvc;

namespace NetCoreAreas.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SimulationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
