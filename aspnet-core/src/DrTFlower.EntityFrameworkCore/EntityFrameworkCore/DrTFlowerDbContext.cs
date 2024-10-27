using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using DrTFlower.Authorization.Roles;
using DrTFlower.Authorization.Users;
using DrTFlower.MultiTenancy;

namespace DrTFlower.EntityFrameworkCore
{
    public class DrTFlowerDbContext : AbpZeroDbContext<Tenant, Role, User, DrTFlowerDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public DrTFlowerDbContext(DbContextOptions<DrTFlowerDbContext> options)
            : base(options)
        {
        }
    }
}
