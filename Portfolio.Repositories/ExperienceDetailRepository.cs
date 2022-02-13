using Portfolio.Domain;
using Portfolio.Repositories.Context;
using Portfolio.Repositories.Contracts;

namespace Portfolio.Repositories
{
    public class ExperienceDetailRepository : BaseRepository<ExperienceDetail>, IExperienceDetailRepository
    {
        public ExperienceDetailRepository(DataContext context) : base(context)
        {
        }
    }
}
