using System.Collections.Generic;
using System.Linq;
using Template.Application.Interfaces;
using Template.Data.Data;
using Template.Domain.Entities;

namespace Template.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        public IEnumerable<Book> GetAll()
        {
            return BookData.GetBooks();
        }

        public Book GetById(int id)
        {
            return BookData.GetBooks().Where(b => b.Id == id).FirstOrDefault();
        }

        public Book GetByIsbn(string isbn)
        {
            return BookData.GetBooks().Where(b => b.Isbn == isbn).FirstOrDefault();
        }
    }
}
