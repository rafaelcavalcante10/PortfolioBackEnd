using Portfolio.Domain.Models;
using System.Collections.Generic;

namespace Portfolio.Repositories.Contracts
{
    public interface IGraduationRepository : IBaseRepository<Graduation>
    {
        IList<Graduation> GetByIdDeveloper(int id_developer);
    }
}
