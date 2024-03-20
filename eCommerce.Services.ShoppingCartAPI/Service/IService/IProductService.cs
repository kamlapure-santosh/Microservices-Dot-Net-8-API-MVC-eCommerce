using eCommerce.Services.ShoppingCartAPI.Models.Dto;

namespace eCommerce.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
