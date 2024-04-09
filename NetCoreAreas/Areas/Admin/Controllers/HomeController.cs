using Microsoft.AspNetCore.Mvc;

namespace NetCoreAreas.Areas.Admin.Controllers
{
    //Area'lar Attribute olarak tanımlanmadan calıstırılamaz
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
