using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Models;
using Portfolio.Repositories.Context;
using Portfolio.Repositories.Contracts;
using System.Linq;

namespace Portfolio.Repositories.Repositories
{
    public class DeveloperRepository : BaseRepository<Developer>, IDeveloperRepository
    {
        public DeveloperRepository(DataContext context) : base(context)
        {
        }
        
        public Developer GetById(int id, bool bGraduation = false, bool bExperience = false)
        {
            IQueryable<Developer> query = _context.Set<Developer>();

            if (bGraduation)
                query = query.Include(g => g.graduations);

            if (bExperience)
                query = query.Include(e => e.experiences).ThenInclude(exp => exp.experienceDetails);

            return query.SingleOrDefault(m => m.id == id);
        }
    }
}
