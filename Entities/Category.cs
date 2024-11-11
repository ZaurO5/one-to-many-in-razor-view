using System.ComponentModel.DataAnnotations.Schema;

namespace Zay_Shop.Entities;

[Table("Category")]
public class Category : BaseEntity
{
    public string Name { get; set; }
    public ICollection<Product> Products { get; set; }
}