using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System.ComponentModel.DataAnnotations;

namespace DrTFlower.Products.Dto
{
    public class ProductsDto : EntityDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Quantity { get; set; }
    }
}
