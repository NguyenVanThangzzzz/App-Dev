using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDBContext: DbContext
    {
        public  DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
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
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "Programming",
                    Description = "Basic start",
                    Author = "Microsoft",
                    Price = 10,
                    CategoryId = 1
                },
                new Book
                {
                    Id = 2,
                    Title = "Advanced Programming",
                    Description = "Enhancing",
                    Author = "BTEC",
                    Price = 14,
                    CategoryId = 2
                },
                new Book
                {
                    Id = 3,
                    Title = "Data Structures",
                    Description = "Not easy",
                    Author = "Greenwich",
                    Price = 15,
                    CategoryId = 3
                }
                

                );


        }

    
    }
}
