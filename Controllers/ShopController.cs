using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Zay_Shop.Data;
using Zay_Shop.Models.Shop;

namespace Zay_Shop.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;

        public ShopController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? categoryId)
        {
            var categories = _context.Categories.Include(c => c.Products).ToList();
            var products = _context.Products.Include(p => p.Category).AsQueryable();

            if (categoryId.HasValue)
            {
                products = products.Where(p => p.CategoryId == categoryId);
            }

            var model = new ProductIndexVM
            {
                Categories = categories,
                Products = products.ToList(),
                SelectedCategoryId = categoryId
            };

            return View(model);
        }
    }
}
