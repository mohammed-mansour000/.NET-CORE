using ASP_1.Data.Models;
using ASP_1.Data.Services;
using ASP_1.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public BooksService _booksService;
        public BooksController(BooksService booksService)
        {
            _booksService = booksService;
        }

        [Route("add-book")]
        [HttpPost]
        public IActionResult AddBook([FromBody]BookVM book)
        {
            _booksService.AddBook(book);
            return Ok();
        }

        [HttpGet]
        [Route("get-all-books")]
        public IActionResult GetAllBooks()
        {
            var allBooks = _booksService.GetAllBooks();
            return Ok(allBooks);
        }

        [HttpGet]
        [Route("get-book-by-id/{bookId}")] //name of params here should be identical of below name
        public IActionResult GetOneBook(int bookId)
        {
            var book = _booksService.GetBookById(bookId);
            return Ok(book);
        }

        [HttpPut]
        [Route("update-book-by-id/{bookId}")]
        public IActionResult UpdateBookById(int bookId, [FromBody] BookVM book)
        {
            var updatedBook = _booksService.UpdateBookById(bookId, book);
            return Ok(updatedBook);
        }

        [HttpDelete]
        [Route("delete-book-by-id/{bookId}")]
        public IActionResult DeleteBookById(int bookId)
        {
            _booksService.DeleteBookById(bookId);
            return Ok();
        }
    
    }
}
