using eCommerce.Services.EmailAPI.Models;

namespace eCommerce.Services.EmailAPI.Services
{
    public interface IEmailService
    {
        Task EmailCartAndLog(CartDto cartDto);
    }
}
