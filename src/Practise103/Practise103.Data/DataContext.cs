using Microsoft.EntityFrameworkCore;
using Practise103.Core.Entities;

namespace Practise103.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
            
        }

        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<RoleEntity> Roles { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<UserRefreshTokenEntity> UserRefreshTokens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var roles = new RoleEntity[]
            {
                new RoleEntity { Id = 1, Name = "Seller" }, 
                new RoleEntity { Id = 2, Name = "Buyer" } 
            };
            modelBuilder.Entity<RoleEntity>().HasData(roles);

            modelBuilder.ApplyConfiguration(new ProductEntityConfiguration());
            modelBuilder.ApplyConfiguration(new UserEntityConfiguration());

            base.OnModelCreating(modelBuilder);
        }

    }
}
