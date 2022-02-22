using Portfolio.Domain.Models;

namespace Portfolio.Repositories.Contracts
{
    public interface IDeveloperRepository : IBaseRepository<Developer>
    {
        Developer GetById(int id, bool bGraduation = false, bool bExperience = false);
    }
}
