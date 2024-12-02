using Abp.Application.Services.Dto;

namespace DrTFlower.Products.Dto
{
    public class PagedProductsResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}
