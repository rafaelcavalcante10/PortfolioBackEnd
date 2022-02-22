using Portfolio.Domain.Models;
using Portfolio.Repositories.Context;
using Portfolio.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Repositories.Repositories
{
    public class GraduationRepository : BaseRepository<Graduation>, IGraduationRepository
    {
        public GraduationRepository(DataContext context) : base(context)
        {
        }

        public IList<Graduation> GetByIdDeveloper(int id_developer)
        {
            return _context.Graduations.Where(w => w.id_developer == id_developer).OrderByDescending(o => o.id).ToList();
        }
    }
}
