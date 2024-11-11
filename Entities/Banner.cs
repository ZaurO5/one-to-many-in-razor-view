namespace Zay_Shop.Entities;

public class Banner : BaseEntity
{
    public string Title { get; set; }
    public string SubTitle { get; set; }
    public string Description { get; set; }
    public string PhotoPath { get; set; }
    public bool IsActive { get; set; }
}