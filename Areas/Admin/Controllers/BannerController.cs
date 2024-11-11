using Microsoft.AspNetCore.Mvc;
using Zay_Shop.Areas.Admin.Models.Banner;
using Zay_Shop.Data;
using Zay_Shop.Entities;

namespace Zay_Shop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BannerController : Controller
    {
        private readonly AppDbContext _context;

        public BannerController(AppDbContext context)
        {
            _context = context;
        }

        #region List

        public IActionResult Index()
        {
            var model = new BannerIndexVM
            {
                Banners = _context.Banners.ToList()
            };

            return View(model);
        }

        #endregion

        #region Create

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BannerCreateVM model)
        {
            if (!ModelState.IsValid) return View(model);

            var banner = new Banner
            {
                Title = model.Title,
                SubTitle = model.SubTitle,
                Description = model.Description,
                PhotoPath = model.PhotoPath,
                CreatedAt = DateTime.Now
            };

            _context.Banners.Add(banner);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Update

        [HttpGet]
        public IActionResult Update(int id)
        {
            var banner = _context.Banners.Find(id);
            if (banner is null) return NotFound();

            var model = new BannerUpdateVM
            {
                Title = banner.Title,
                SubTitle = banner.SubTitle,
                Description = banner.Description,
                PhotoPath = banner.PhotoPath
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Update(int id, BannerUpdateVM model)
        {
            if (!ModelState.IsValid) return View(model);

            var banner = _context.Banners.Find(id);
            if (banner is null) return NotFound();

            banner.Title = model.Title;
            banner.SubTitle = model.SubTitle;
            banner.Description = model.Description;
            banner.PhotoPath = model.PhotoPath;
            banner.ModifiedAt = DateTime.Now;

            _context.Banners.Update(banner);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        #endregion

        #region Delete

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var banner = _context.Banners.Find(id);
            if (banner is null) return NotFound();

            _context.Banners.Remove(banner);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        #endregion

        #region SetActive
        [HttpPost]
        public IActionResult SetActive(int id)
        {
            var banner = _context.Banners.Find(id);
            if (banner is null) return NotFound();

            banner.IsActive = !banner.IsActive;

            _context.Banners.Update(banner);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        #endregion
    }

}
