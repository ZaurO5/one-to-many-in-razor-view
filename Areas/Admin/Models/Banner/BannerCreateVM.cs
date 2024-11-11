using System.ComponentModel.DataAnnotations;

namespace Zay_Shop.Areas.Admin.Models.Banner;

public class BannerCreateVM
{
    [Required(ErrorMessage = "Title is required")]
    [MinLength(5, ErrorMessage = "At least 5 characters")]
    public string Title { get; set; }
    public string SubTitle { get; set; }
    public string Description { get; set; }
    public string PhotoPath { get; set; }
}