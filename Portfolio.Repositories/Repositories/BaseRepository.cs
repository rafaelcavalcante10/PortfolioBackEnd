using Portfolio.Repositories.Context;
using Portfolio.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Repositories.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly DataContext _context;
        public BaseRepository(DataContext context)
        {
            _context = context;
        }
        
        public virtual IList<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public virtual TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public virtual bool Insert(TEntity entity)
        {         
            _context.Add<TEntity>(entity);
            return Convert.ToBoolean(_context.SaveChanges());
        }

        public virtual bool Update(TEntity entity)
        {
            _context.Update<TEntity>(entity);
            return Convert.ToBoolean(_context.SaveChanges());
        }
        public virtual bool Detele(int id)
        {
            _context.Remove<TEntity>(GetById(id));
            return Convert.ToBoolean(_context.SaveChanges());
        }
    }
}
