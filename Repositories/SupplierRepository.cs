using Microsoft.EntityFrameworkCore;
using ProductInventoryManagement.Data;
using ProductInventoryManagement.Interfaces;
using ProductInventoryManagement.Models;

namespace ProductInventoryManagement.Repositories
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly ApplicationDbContext _context;

        public SupplierRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Supplier>> GetAllAsync()
        {
            return await _context.Suppliers.ToListAsync();
        }

        public async Task<Supplier?> GetByIdAsync(int id)
        {
            return await _context.Suppliers.FirstOrDefaultAsync(s => s.SupplierId == id);
        }

        public async Task AddAsync(Supplier supplier)
        {
            _context.Add(supplier);
            await _context.SaveChangesAsync();
        }

        public void Update(Supplier supplier)
        {
            _context.Update(supplier);
            _context.SaveChanges();
        }

        public void Delete(Supplier supplier)
        {
            _context.Remove(supplier);
            _context.SaveChanges();
        }

        public bool Exists(int id)
        {
            return _context.Suppliers.Any(e => e.SupplierId == id);
        }
    }
}