using Microsoft.EntityFrameworkCore;
using Portfolio.Domain;
using Portfolio.Repositories.Context;
using Portfolio.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Repositories
{
    public class ExperienceRepository : BaseRepository<Experience>, IExperienceRepository
    {
        public ExperienceRepository(DataContext context) : base(context)
        {
        }

        public IList<Experience> GetByIdDeveloper(int id_developer)
        {
            return _context.Experiences.Where(w => w.id_developer == id_developer).Include(i => i.experienceDetails).ToList();
        }
    }
}
