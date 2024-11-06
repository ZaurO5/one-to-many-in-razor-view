using Microsoft.EntityFrameworkCore;

namespace Zay_Shop.Data
{
    public class AppDbContext : DbContext
    {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {

            }
    }
}
