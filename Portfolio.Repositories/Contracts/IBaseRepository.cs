using System.Collections.Generic;

namespace Portfolio.Repositories.Contracts
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        IList<TEntity> GetAll();
        TEntity GetById(int id);
    }
}
