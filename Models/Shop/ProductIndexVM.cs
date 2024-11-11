using Zay_Shop.Entities;

namespace Zay_Shop.Models.Shop
{
    public class ProductIndexVM
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public int? SelectedCategoryId { get; set; }
    }
}
