using System.ComponentModel.DataAnnotations;

namespace ProductInventoryManagement.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Category name is required.")]
        [StringLength(50, ErrorMessage = "Category name cannot exceed 50 characters.")]
        public string Name { get; set; }

        // A category can have many products
        public ICollection<Product>? Products { get; set; }
    }
}