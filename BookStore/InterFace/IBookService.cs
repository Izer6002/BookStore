using BookStore.DataBase.Entity;

namespace BookStore.InterFace
{
    public interface IBookService
    {
        Task<List<Books>> GetAllBooks();
        Task<Books> GetBookById(int id);
        Task<Order> AddOrder(Order order);
        Task SaveChanges();
    }
}
