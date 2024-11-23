using System.ComponentModel.DataAnnotations.Schema;

namespace Zay_Shop.Entities;

[Table("Product")]
public class Product : BaseEntity
{
    public string Photo { get; set; }
    public string Title { get; set; }
    public string Size { get; set; }
    public decimal Price { get; set; }
    public Category Category { get; set; }
    public int CategoryId { get; set; }
}