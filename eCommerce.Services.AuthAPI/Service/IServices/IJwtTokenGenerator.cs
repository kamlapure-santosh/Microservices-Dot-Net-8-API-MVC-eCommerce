using eCommerce.Services.AuthAPI.Models;

namespace eCommerce.Services.AuthAPI.Service.IServices
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser applicationUser, IEnumerable<string> roles);
    }
}
