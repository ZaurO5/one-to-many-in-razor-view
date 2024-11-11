using Microsoft.AspNetCore.Mvc;
using Zay_Shop.Data;
using Zay_Shop.Models.Home;

namespace Zay_Shop.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var model = new BannerIndexVM
        {
            Banners = _context.Banners.ToList()
        };

        return View(model);
    }
}