using Portfolio.Domain;
using Portfolio.Repositories.Context;
using Portfolio.Repositories.Contracts;

namespace Portfolio.Repositories
{
    public class DeveloperRepository : BaseRepository<Developer>, IDeveloperRepository
    {
        public DeveloperRepository(DataContext context) : base(context)
        {
        }
    }
}
