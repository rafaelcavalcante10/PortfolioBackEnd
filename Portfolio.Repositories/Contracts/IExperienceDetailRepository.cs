using Portfolio.Domain.Models;
using System.Collections.Generic;

namespace Portfolio.Repositories.Contracts
{
    public interface IExperienceDetailRepository : IBaseRepository<ExperienceDetail>
    {
        ExperienceDetail GetById(int id, int id_experience);
        IList<ExperienceDetail> GetByIdExperience(int id_experience);
    }
}
