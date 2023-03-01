using BookStore.DataBase.Context;
using BookStore.DataBase.Entity;
using BookStore.InterFace;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Services
{
    public class BookService : IBookService
    {
        private readonly BookDBContext db;
        private readonly IBookService bookService;

        public async Task<Order> AddOrder(Order order)
        {
            await db.OrderList.AddAsync(order);
            await SaveChanges();
            return order;
        }

        public async Task<List<Books>> GetAllBooks()
        {
            return await db.BookList.ToListAsync();
        }

        public async Task<Books> GetBookById(int id)
        {
            return await bookService.GetBookById(id);
        }

        public async Task SaveChanges()
        {
            await db.SaveChangesAsync();
        }

       
    }
}
