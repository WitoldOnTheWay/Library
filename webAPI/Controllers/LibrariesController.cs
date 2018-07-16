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
    public class LibrariesController : ApiController
    {
       public LibraryRepository librariesRepository = new LibraryRepository();

        [HttpGet()]
        public IEnumerable<Library> GetAllLibraries()
        {
            return librariesRepository.GetAll();
        }
    }
}
