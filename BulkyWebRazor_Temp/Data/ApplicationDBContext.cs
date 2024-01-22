using BulkyWebRazor_Temp.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWebRazor_Temp.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category { intCategoryId = 1, strCategoryName = "Anime", intDisplayOrder = 1 },
                new Category { intCategoryId = 2, strCategoryName = "Action", intDisplayOrder = 2 },
                new Category { intCategoryId = 3, strCategoryName = "Adventure", intDisplayOrder = 3 }
                );
        }
    }
}
