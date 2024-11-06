using Microsoft.AspNetCore.Mvc;

namespace Zay_Shop.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            return View();
        }
    }
}
