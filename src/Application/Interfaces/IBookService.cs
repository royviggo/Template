using System.Collections.Generic;
using Template.Domain.Entities;

namespace Template.Application.Interfaces
{
    public interface IBookService
    {
        IEnumerable<Book> GetAll();
        Book GetById(int id);
        Book GetByIsbn(string isbn);
    }
}