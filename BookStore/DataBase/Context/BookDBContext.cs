
using BookStore.DataBase.Entity;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DataBase.Context
{
    public class BookDBContext : DbContext
    {
        public BookDBContext(DbContextOptions<BookDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Books> BookList { get; set; }
        public DbSet<Order> OrderList { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your entity models here using the fluent API
        }

        //public BookDBContext() { } // Empty constructor for dependency injection
    }

}
