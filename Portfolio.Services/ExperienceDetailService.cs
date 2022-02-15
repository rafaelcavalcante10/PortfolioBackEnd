using Portfolio.Repositories;
using Portfolio.Repositories.Contracts;
using Portfolio.Services.Contracts;
using Portfolio.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Services
{
    public class ExperienceDetailService : BaseService<ExperienceDetailVM>, IExperienceDetailService
    {
        private readonly IExperienceDetailRepository _experienceDetailRepository;
        public ExperienceDetailService(IExperienceDetailRepository experienceDetailRepository)
        {
            _experienceDetailRepository = experienceDetailRepository;
        }

        public override Task<ExperienceDetailVM> BuscaPorId(int id)
        {
            return base.BuscaPorId(id);
        }
        public override Task<ExperienceDetailVM[]> BuscarTodos()
        {
            return base.BuscarTodos();
        }
        public async Task<IList<ExperienceDetailVM>> BuscaPorIdExperience(int id)
        {
            try
            {
                var details = _experienceDetailRepository.GetByIdExperience(id);
                if (details == null) return null;
                var detalhes = new List<ExperienceDetailVM>();
                foreach(var detalhe in details)
                {
                    detalhes.Add(new ExperienceDetailVM
                    {
                        id = detalhe.id,
                        id_experience = detalhe.id_experience,
                        detalhe = detalhe.detalhe
                    });
                }
                return detalhes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
