using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.DataAccess;
using WebApp.DataAccess.Entities;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class BookController : Controller
    {
        public DbContextApp _dbContext;
        public BookController(DbContextApp dbContext)
        {
            _dbContext = dbContext;
        }

        public ActionResult<BookDto> CreateBook(BookDto book)
        {
            var b = new Book()
            {
                ID = book.ID,
                Author = book.Author,
                ISBN = book.ISBN,
                Language = book.Language,
                Pages = book.Pages,
                Title = book.Title
            };
            _dbContext.Books.Add(b);
            _dbContext.SaveChanges();
            return View();
        }
    }
}
