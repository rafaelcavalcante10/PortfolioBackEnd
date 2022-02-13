using Portfolio.Repositories.Context;
using Portfolio.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly DataContext _context;
        public BaseRepository(DataContext context)
        {
            _context = context;
        }
        public IList<TEntity> GetAll()
        {
            var query =  _context.Set<TEntity>().ToList();
            if (query == null) return null;

            return query;
        }

        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }
    }
}
