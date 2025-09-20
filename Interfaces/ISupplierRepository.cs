using ProductInventoryManagement.Models;

namespace ProductInventoryManagement.Interfaces
{
    public interface ISupplierRepository
    {
        Task<IEnumerable<Supplier>> GetAllAsync();
        Task<Supplier?> GetByIdAsync(int id);
        Task AddAsync(Supplier supplier);
        void Update(Supplier supplier);
        void Delete(Supplier supplier);
        bool Exists(int id);
    }
}