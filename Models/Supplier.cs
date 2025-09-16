using System.ComponentModel.DataAnnotations;

namespace ProductInventoryManagement.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }

        [Required(ErrorMessage = "Supplier name is required.")]
        [StringLength(100, ErrorMessage = "Supplier name cannot exceed 100 characters.")]
        public string Name { get; set; }

        [StringLength(200, ErrorMessage = "Contact information cannot exceed 200 characters.")]
        public string? ContactInfo { get; set; }

        // A supplier can provide many products
        public ICollection<Product>? Products { get; set; }
    }
}