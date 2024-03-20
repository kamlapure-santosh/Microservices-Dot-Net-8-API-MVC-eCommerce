using Microsoft.AspNetCore.Identity;

namespace eCommerce.Services.AuthAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
