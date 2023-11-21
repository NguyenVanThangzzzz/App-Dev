using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDBContext: DbContext
    {
       public  DbSet<Category> Categories { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) //đưa tất cả options vào base
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Roman", Description = "ABCDEGH", DisplayOrder = 2 },
                new Category { Id = 2, Name = "Action", Description = "GGGGG", DisplayOrder = 3 },
                new Category { Id = 3, Name = "History", Description = "DDDDD", DisplayOrder = 4 }
                );
        }
    }
}
