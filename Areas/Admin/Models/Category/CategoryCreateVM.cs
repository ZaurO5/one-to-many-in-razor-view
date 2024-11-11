using System.ComponentModel.DataAnnotations;

namespace Zay_Shop.Areas.Admin.Models.Category;

public class CategoryCreateVM
{
    [Required(ErrorMessage = "Name required")]
    [MinLength(2, ErrorMessage = "At least 5 characters")]
    [Display(Name = "Title")]
    public string Name { get; set; }
}