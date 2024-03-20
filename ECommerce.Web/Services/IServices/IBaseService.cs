using eCommerce.Web.Models;
using eCommerce.Web.Models;

namespace eCommerce.Web.Services.IServices
{
    public interface IBaseService
    {
        Task<ResponseDto?> SendAsync(RequestDto requestDto, bool withBearer = true);
    }
}
