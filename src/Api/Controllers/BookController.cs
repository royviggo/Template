using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Template.Application.Interfaces;
using Template.Domain.Entities;

namespace Template.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ApiControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _bookService.GetAll();
        }

        [HttpGet("{id:int}")]
        public Book GetById(int id)
        {
            return _bookService.GetById(id);
        }

        [HttpGet("isbn/{isbn}")]
        public Book GetByIsbn(string isbn)
        {
            return _bookService.GetByIsbn(isbn);
        }
    }
}
