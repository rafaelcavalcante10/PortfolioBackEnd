using System.Collections.Generic;

namespace Portfolio.Repositories.Contracts
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        bool Insert(TEntity entity);
        bool Update(TEntity entity);
        bool Detele(int id);
        IList<TEntity> GetAll();
        TEntity GetById(int id);
    }
}
