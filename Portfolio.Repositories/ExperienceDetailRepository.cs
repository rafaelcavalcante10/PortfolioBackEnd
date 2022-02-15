using Portfolio.Domain;
using Portfolio.Repositories.Context;
using Portfolio.Repositories.Contracts;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Portfolio.Repositories
{
    public class ExperienceDetailRepository : BaseRepository<ExperienceDetail>, IExperienceDetailRepository
    {
        public ExperienceDetailRepository(DataContext context) : base(context)
        {
        }
        public IList<ExperienceDetail> GetByIdExperience(int id_experience)
        {
            var query = _context.ExperienceDetails.Where(w => w.id_experience == id_experience).ToList();
            var details = new List<ExperienceDetail>();
            foreach(var detail in query)
            {
                details.Add(new ExperienceDetail
                {
                    id = detail.id,
                    id_experience = detail.id_experience,
                    detalhe = detail.detalhe
                });
            }
            return details;
        }
    }
}
