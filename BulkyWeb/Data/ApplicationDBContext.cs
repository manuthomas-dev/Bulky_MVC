using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category { intCategoryId = 1, strCategoryName = "Action", intDisplayOrder = 1 },
                new Category { intCategoryId = 2, strCategoryName = "Romance", intDisplayOrder = 2 },
                new Category { intCategoryId = 3, strCategoryName = "SciFi", intDisplayOrder = 3 },
                new Category { intCategoryId = 4, strCategoryName = "Crime", intDisplayOrder = 4 }
            );
        }
    }
}
