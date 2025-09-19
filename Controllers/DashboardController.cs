using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductInventoryManagement.Data;
using ProductInventoryManagement.Models;
using ProductInventoryManagement.ViewModels;

namespace ProductInventoryManagement.Controllers
{
    // Only users in the "Admin" or "Manager" role can access the dashboard.
    [Authorize(Roles = "Admin,Manager")]
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // Create an instance of our ViewModel
            var viewModel = new DashboardViewModel();

            // Fetch data from the database
            viewModel.TotalProducts = await _context.Products.CountAsync();
            viewModel.TotalCategories = await _context.Categories.CountAsync();
            viewModel.TotalSuppliers = await _context.Suppliers.CountAsync();

            // Get products with low stock (quantity <= 10)
            viewModel.LowStockProducts = await _context.Products
                .Include(p => p.Stock)
                .Where(p => p.Stock != null && p.Stock.Quantity <= 10)
                .ToListAsync();

            return View(viewModel);
        }
    }
}