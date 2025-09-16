using Microsoft.EntityFrameworkCore;
using ProductInventoryManagement.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ProductInventoryManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Stock> Stock { get; set; }

    }
}