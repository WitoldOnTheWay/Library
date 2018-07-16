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
    public class BookTypeController : ApiController
    {
        //private readonly IBookTypeRepository booktypeRepository = new BookTypeRepository();

        [HttpGet()]
        public IEnumerable<BookType> GetAll()
        {
            //return bookTypeRepository.GetAll();
            return null;
        }
    }
}
