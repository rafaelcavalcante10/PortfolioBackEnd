using Portfolio.Domain;
using System.Collections.Generic;

namespace Portfolio.Repositories.Contracts
{
    public interface IExperienceRepository : IBaseRepository<Experience>
    {
        IList<Experience> GetByIdDeveloper(int id_developer);
    }
}
