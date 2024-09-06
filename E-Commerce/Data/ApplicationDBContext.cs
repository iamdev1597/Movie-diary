using E_Commerce.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            
        }
        public DbSet<Category> ProductCategory { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { id = 1, Name = "Actions", DisplayOrder = 1 },
                new Category { id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { id = 3, Name = "Drama", DisplayOrder = 3 }
                );
        }

    }
}
