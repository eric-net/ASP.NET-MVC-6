using Microsoft.EntityFrameworkCore;

namespace DemoAPI.Models.Data
{
    public class DemoContext  : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options) : base(options) 
        { 
        }
        public DbSet<Product> Products { get; set; }
    }
}
