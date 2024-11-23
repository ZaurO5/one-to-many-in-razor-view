using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using Zay_Shop.Entities;

namespace Zay_Shop.Areas.Admin.Models.Product;

public class ProductCreateVM
{

    [Required(ErrorMessage = "Title is required")]
    [MinLength(2, ErrorMessage = "At least 5 characters")]
    public string Title { get; set; }

    [Required(ErrorMessage = "Price is required")]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "Size is required")]
    public string Size { get; set; }

    [Required(ErrorMessage = "Photo is required")]
    public IFormFile Photo { get; set; }

    [Required]
    [Display(Name = "Product Category")]
    public int CategoryId { get; set; }
    public List<SelectListItem>? Categories { get; set; }
}