using System.ComponentModel.DataAnnotations;

namespace ProductInventoryManagement.Models
{
    public class Stock
    {
        [Key]
        [Required]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Quantity is required.")]
        [Range(0, int.MaxValue, ErrorMessage = "Quantity must be a non-negative number.")]
        public int Quantity { get; set; }

        // One-to-one relationship with Product
        public Product? Product { get; set; }
    }
}