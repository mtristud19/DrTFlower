
using Abp.AutoMapper;
using System.ComponentModel.DataAnnotations;

namespace DrTFlower.Products.Dto
{
    public class CreateProductsDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Quantity { get; set; }
    }
}
