using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Portal.Domain;

using Portal.Persistance.Configs;

namespace Portal.Persisatance
{
    public class PortalDbContext :DbContext
    {
        public PortalDbContext(DbContextOptions<PortalDbContext> options)
              : base(options)
        {
        }

        public DbSet<Food> Foods { get; set; }
       public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; } 
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new FoodConfig());

            base.OnModelCreating(builder);
        }

    }
}
