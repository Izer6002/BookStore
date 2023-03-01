using BookStore.DataBase.Entity;
using BookStore.InterFace;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace BookStore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private IBookService _service;

        public BooksController(IBookService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<Books>>> GetAllBooks()
        {
            var books = await _service.GetAllBooks();
            return Ok(books);
        }

        [HttpGet]
        public async Task<ActionResult<Books>> GetBookById(int id)
        {
            var book= await _service.GetBookById(id);
            return Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> AddOrder(Order order)
        {
            var addNewBook=await _service.AddOrder(order);
            return Ok(addNewBook);
        }
    }

}
