using eCommerce.Services.ShoppingCartAPI.Models.Dto;

namespace eCommerce.Services.ShoppingCartAPI.Service.IService
{
    public interface ICouponService
    {
        Task<CouponDto> GetCoupon(string couponCode);
    }
}
