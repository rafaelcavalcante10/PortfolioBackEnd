using Portfolio.Domain.Models;
using Portfolio.Repositories.Context;
using Portfolio.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Repositories.Repositories
{
    public class ExperienceDetailRepository : BaseRepository<ExperienceDetail>, IExperienceDetailRepository
    {
        public ExperienceDetailRepository(DataContext context) : base(context)
        {
        }
        public IList<ExperienceDetail> GetByIdExperience(int id_experience)
        {
            return _context.ExperienceDetails.Where(w => w.id_experience == id_experience).ToList();            
        }
    }
}
