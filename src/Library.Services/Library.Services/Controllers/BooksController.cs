using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Library.Data;
using Library.DB;

namespace Library.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IDatabaseCommands _databaseCommands;

        // GET api/books
        [HttpGet]
        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await _databaseCommands.GetBooksAsync();
        }

        // GET api/books/5
        [HttpGet("{id}")]
        public async Task<Book> Get(int id)
        {
            return await _databaseCommands.GetBookAsync(id);
        }
    }
}
