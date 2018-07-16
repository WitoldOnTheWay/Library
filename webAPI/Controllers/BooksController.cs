using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.IO;
using System.Text;


using EntityLibrary;

namespace webAPI.Controllers
{
    public class BooksController : ApiController
    {
        private readonly BookRepository bookRepository = new BookRepository();

        [HttpGet()]
        [Route("api/book")]
        //public IEnumerable<Book> GetAll()
          public List<EntityLibrary.Book>GetAllBooks()
        {
            //BookRepository bookRepository = new BookRepository();
            return bookRepository.GetAll();
        }

        [HttpGet]
        [Route("api/book/{Id}")]
        
        public Book GetBookById(int Id)
        {
            //var guid = Guid.Parse(bookId);
            //return bookRepository.GetAll().First(x => x.Id == guid);
            BookRepository bookRepository = new BookRepository();
                return bookRepository.GetBookById(Id);
            
        }

        [Route("api/book/add")]
        [HttpPost]
       
        public void AddBook(Book book)
        {
            BookRepository bookRepository = new BookRepository();
            bookRepository.add(book);
        }
        
        [HttpPut]
        [Route("api/book/{Id}")]
        public Book EditBook([FromBody]Book book,int Id)
        {
            BookRepository bookRepository = new BookRepository();
            return bookRepository.Edit(book,Id);

        }
        
        [HttpPost]
        //[HttpGet]
        [Route("api/book/delete/{Id}")]
        
        
        public void DeleteBook(int Id)
        {
            BookRepository bookRepository = new BookRepository();
            bookRepository.deleteBook(Id);
        }
        [HttpGet]
        [Route("api/book/search")]
        public List<Book> GetBooksThatContain(string SearchInput)
        {
            //BookRepository bookRepository = new BookRepository();
            return bookRepository.GetBooksThatContain(SearchInput);
        }

    }
}
