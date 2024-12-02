using AutoMapper;

namespace DrTFlower.Products.Dto
{
    public class ProductMapProfile : Profile
    {
        public ProductMapProfile()
        {
            CreateMap<CreateProductsDto, Products>();

            CreateMap<Products, ProductsDto>();

            CreateMap<ProductsDto, Products>();
        }
    }
}
