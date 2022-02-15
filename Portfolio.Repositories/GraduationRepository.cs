using Portfolio.Domain;
using Portfolio.Repositories.Context;
using Portfolio.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Repositories
{
    public class GraduationRepository : BaseRepository<Graduation>, IGraduationRepository
    {
        public GraduationRepository(DataContext context) : base(context)
        {
        }

        public IList<Graduation> GetByIdDeveloper(int id_developer)
        {
            try
            {
                var query = _context.Graduations.Where(w => w.id_developer == id_developer).OrderByDescending(o => o.id).ToList();
                if (query == null) return null;

                return query;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
