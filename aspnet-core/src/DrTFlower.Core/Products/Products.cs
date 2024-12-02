using Abp.Domain.Entities;

namespace DrTFlower.Products
{
    public class Products : Entity<int>
    {
        public string Name { get; set; }
        public string Quantity { get; set; }
        
        public Products()
        {
        }

        public Products(string name, string quantity)
        {
            Name = name;
            Quantity = quantity;

        }
    }
}
