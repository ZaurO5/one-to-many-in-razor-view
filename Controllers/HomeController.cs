using Microsoft.AspNetCore.Mvc;

namespace Zay_Shop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
