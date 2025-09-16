using ProductInventoryManagement.Models;

namespace ProductInventoryManagement.ViewModels
{
    public class DashboardViewModel
    {
        public int TotalProducts { get; set; }
        public int TotalCategories { get; set; }
        public int TotalSuppliers { get; set; }
        public List<Product> LowStockProducts { get; set; } = new List<Product>();
    }
}