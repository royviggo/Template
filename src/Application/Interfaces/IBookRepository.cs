using Template.Domain.Entities;

namespace Template.Application.Interfaces
{
    public interface IBookRepository : IRepository<Book>
    {
        Book GetByIsbn(string isbn);
    }
}