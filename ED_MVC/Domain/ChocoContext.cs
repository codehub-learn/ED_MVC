using Microsoft.EntityFrameworkCore;
namespace ED_MVC.Domain
{
    public class ChocoContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public ChocoContext(DbContextOptions<ChocoContext> options) : base(options) { }
    }
}
