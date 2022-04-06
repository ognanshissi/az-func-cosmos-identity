using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    

    public class ApplicationDbContext: DbContext
    {
        
        public DbSet<Product> Products {get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }

        
    }
}