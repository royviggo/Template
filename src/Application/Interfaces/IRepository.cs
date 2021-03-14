using System.Collections.Generic;

namespace Template.Application.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class, new()
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
    }
}