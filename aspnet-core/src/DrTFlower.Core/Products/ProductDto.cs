using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace DrTFlower.Products
{
    public class ProductDto : EntityDto<int>
    {
        [AutoMapFrom(typeof(Product))]
        public string Name { get; set; }
        public string Quantity { get; set; }
    }
}
