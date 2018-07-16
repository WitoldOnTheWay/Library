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
    public class AuthorsController : ApiController
    {
        private readonly AuthorRepository authorRepository = new AuthorRepository();

        [HttpGet()]
        public List<EntityLibrary.Author> GetAll()
        {
            return authorRepository.GetAll();
        }
    }
}
