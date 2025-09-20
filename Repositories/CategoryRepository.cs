using Microsoft.EntityFrameworkCore;
using ProductInventoryManagement.Data;
using ProductInventoryManagement.Interfaces;
using ProductInventoryManagement.Models;

namespace ProductInventoryManagement.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category?> GetByIdAsync(int id)
        {
            return await _context.Categories.FirstOrDefaultAsync(c => c.CategoryId == id);
        }

        public async Task AddAsync(Category category)
        {
            _context.Add(category);
            await _context.SaveChangesAsync();
        }

        public void Update(Category category)
        {
            _context.Update(category);
            _context.SaveChanges();
        }

        public void Delete(Category category)
        {
            _context.Remove(category);
            _context.SaveChanges();
        }

        public bool Exists(int id)
        {
            return _context.Categories.Any(e => e.CategoryId == id);
        }
    }
}