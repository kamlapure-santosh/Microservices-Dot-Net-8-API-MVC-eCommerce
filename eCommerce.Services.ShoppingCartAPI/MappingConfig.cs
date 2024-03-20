using AutoMapper;
using eCommerce.Services.ShoppingCartAPI.Models;
using eCommerce.Services.ShoppingCartAPI.Models.Dto;

namespace eCommerce.Services.ShoppingCartAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CartDetailsDto, CartDetails>().ReverseMap();
                config.CreateMap<CartHeaderDto, CartHeader>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
