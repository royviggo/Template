using System.Collections.Generic;
using Template.Application.Interfaces;
using Template.Domain.Entities;

namespace Template.Application.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IEnumerable<Book> GetAll()
        {
            return _bookRepository.GetAll();
        }

        public Book GetById(int id)
        {
            return _bookRepository.GetById(id);
        }

        public Book GetByIsbn(string isbn)
        {
            return _bookRepository.GetByIsbn(isbn);
        }
    }
}
