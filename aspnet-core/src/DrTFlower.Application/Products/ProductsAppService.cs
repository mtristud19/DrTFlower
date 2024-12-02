using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using DrTFlower.Authorization;
using DrTFlower.Products.Dto;
using System;
using System.Threading.Tasks;

namespace DrTFlower.Products
{
    [AbpAuthorize(PermissionNames.Pages_Products)]
    public class ProductsAppService : AsyncCrudAppService<Products, ProductsDto, int, PagedProductsResultRequestDto, CreateProductsDto, ProductsDto>, IProductsAppService
    {
        public ProductsAppService(IRepository<Products, int> repository) : base(repository)
        {
        }

        public override async Task<ProductsDto> CreateAsync(CreateProductsDto input)
        {
            return await base.CreateAsync(input);
        }

        public override async Task<ProductsDto> UpdateAsync(ProductsDto input)
        {
            return await base.UpdateAsync(input);
        }
        public override Task DeleteAsync(EntityDto<int> input)
        {
            return base.DeleteAsync(input);
        }
    }
}
