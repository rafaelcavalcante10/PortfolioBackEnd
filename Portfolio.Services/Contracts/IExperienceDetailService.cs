using Portfolio.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Services.Contracts
{
    public interface IExperienceDetailService : IBaseService<ExperienceDetailVM>
    {
        Task<IList<ExperienceDetailVM>> BuscaPorIdExperience(int id);
    }
}
