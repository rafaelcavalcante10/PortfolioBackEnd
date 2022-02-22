using Portfolio.Domain.Models;
using System.Collections.Generic;

namespace Portfolio.Repositories.Contracts
{
    public interface IExperienceDetailRepository : IBaseRepository<ExperienceDetail>
    {
        IList<ExperienceDetail> GetByIdExperience(int id_experience);
    }
}
