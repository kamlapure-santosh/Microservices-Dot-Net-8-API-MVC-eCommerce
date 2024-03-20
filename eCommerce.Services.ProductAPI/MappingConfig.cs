using AutoMapper;
using eCommerce.Services.ProductAPI.Models;
using eCommerce.Services.ProductAPI.Models.Dto;

namespace eCommerce.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
