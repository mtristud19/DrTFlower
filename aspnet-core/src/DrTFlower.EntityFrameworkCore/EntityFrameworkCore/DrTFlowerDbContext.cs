using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using DrTFlower.Authorization.Roles;
using DrTFlower.Authorization.Users;
using DrTFlower.MultiTenancy;
using DrTFlower.Products;

namespace DrTFlower.EntityFrameworkCore
{
    public class DrTFlowerDbContext : AbpZeroDbContext<Tenant, Role, User, DrTFlowerDbContext>
    {
        public DbSet<Products.Products> Products { get; set; }

        /* Define a DbSet for each entity of the application */
        
        public DrTFlowerDbContext(DbContextOptions<DrTFlowerDbContext> options)
            : base(options)
        {
        }
    }
}
