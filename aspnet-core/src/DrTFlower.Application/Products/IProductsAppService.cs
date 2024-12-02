using Abp.Application.Services;
using DrTFlower.Products.Dto;

namespace DrTFlower.Products
{
    public interface IProductsAppService : IAsyncCrudAppService<ProductsDto, int, PagedProductsResultRequestDto, CreateProductsDto, ProductsDto>
    {
    }
}
