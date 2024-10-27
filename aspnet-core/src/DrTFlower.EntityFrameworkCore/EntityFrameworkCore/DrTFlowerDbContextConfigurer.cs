using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace DrTFlower.EntityFrameworkCore
{
    public static class DrTFlowerDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DrTFlowerDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DrTFlowerDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
