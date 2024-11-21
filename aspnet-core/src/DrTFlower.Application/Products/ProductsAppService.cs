using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using DrTFlower.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrTFlower.Products
{

    [AbpAuthorize(PermissionNames.Pages_Products)]
    public class ProductsAppService : CrudAppService<Product, ProductDto>
    {
        public ProductsAppService(IRepository<Product, int> repository) : base(repository)
        { 
        }
    }
}
