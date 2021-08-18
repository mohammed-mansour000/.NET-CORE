using ASP_1.Data.Models;
using ASP_1.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_1.Data.Services
{
    public class BooksService
    {
        private AppDbContext _context;
        public BooksService(AppDbContext context)
        {
            _context = context;
        }

        public void AddBook(BookVM book) //add a book
        {
            var _book = new Book()
            {
                Title = book.Title,
                Description = book.Description,
                IsRead = book.IsRead,
                DateRead = book.IsRead ? book.DateRead.Value : null,
                Rate = book.IsRead ? book.Rate.Value : null,
                Genre = book.Genre,
                Author = book.Author,
                CoverUrl = book.CoverUrl,
                DateAdded = DateTime.Now

            };
            _context.Books.Add(_book);
            _context.SaveChanges();
        }

        public List<Book> GetAllBooks() //get all books
        {
            var allBooks = _context.Books.ToList();
            return allBooks;
        }
        
        //get one book according to id
        public Book GetBookById(int bookId) => _context.Books.FirstOrDefault(n => n.Id == bookId);

        //update a certain book by id
        public Book UpdateBookById(int bookId, BookVM book)
        {
            //check if book with bookId is existed?
            var _book = _context.Books.FirstOrDefault(n => n.Id == bookId);
            if(_book != null)
            {
                //setting the new values of the book
                _book.Title = book.Title;
                _book.Description = book.Description;
                _book.IsRead = book.IsRead;
                _book.DateRead = book.IsRead ? book.DateRead.Value : null;
                _book.Rate = book.IsRead ? book.Rate.Value : null;
                _book.Genre = book.Genre;
                _book.Author = book.Author;
                _book.CoverUrl = book.CoverUrl;

                _context.SaveChanges();
            }
            return _book;
        }

        //delete book by id 
        public void DeleteBookById(int bookId)
        {
            //check if book with bookId is existed?
            var book = _context.Books.FirstOrDefault(n => n.Id == bookId);
            if(book != null) //if exists
            {
                _context.Books.Remove(book); //delete the book
                _context.SaveChanges();     //save the changes after deleting
            }
        }
    }
}
