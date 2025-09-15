using Microsoft.EntityFrameworkCore;

namespace ProductInventoryManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // We will add DbSet properties for our models here in the next step
        // public DbSet<Product> Products { get; set; }
        // public DbSet<Category> Categories { get; set; }
    }
}