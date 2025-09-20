using Microsoft.EntityFrameworkCore;
using ProductInventoryManagement.Data;
using ProductInventoryManagement.Interfaces;
using ProductInventoryManagement.Models;

namespace ProductInventoryManagement.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _context.Products
                .Include(p => p.Category)
                .Include(p => p.Supplier)
                .Include(p => p.Stock)
                .ToListAsync();
        }

        public async Task<Product?> GetByIdAsync(int id)
        {
            return await _context.Products
                .Include(p => p.Category)
                .Include(p => p.Supplier)
                .Include(p => p.Stock)
                .FirstOrDefaultAsync(p => p.ProductId == id);
        }

        public async Task AddAsync(Product product)
        {
            _context.Add(product);
            await _context.SaveChangesAsync();
        }

        public void Update(Product product)
        {
            _context.Update(product);
            _context.SaveChanges();
        }

        public void Delete(Product product)
        {
            _context.Remove(product);
            _context.SaveChanges();
        }
    }
}