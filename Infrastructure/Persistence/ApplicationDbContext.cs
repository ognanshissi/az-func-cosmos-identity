using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    
    public class ApplicationDbContext: DbContext
    {
        
        public DbSet<Product> Products { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
            builder.Entity<Product>().ToContainer("Product");
            builder.Entity<Product>().HasPartitionKey(p => p.PartitionKey);
        }

        
    }
}