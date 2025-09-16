using Microsoft.AspNetCore.Identity;

namespace ProductInventoryManagement.Models
{
    // Extend the built-in IdentityUser to add any custom properties later
    public class ApplicationUser : IdentityUser
    {
        // We will add custom properties here if needed in the future,
        // for example, public string? FullName { get; set; }
    }
}