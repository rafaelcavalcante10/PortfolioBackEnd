using AutoMapper;
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
    public class PortfolioService : BaseService<PortfolioVM>, IPortfolioService
    {
        public PortfolioService(IDeveloperRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
        public override async Task<PortfolioVM> BuscaPorId(int id)
        {
            try
            {
                var developer = _repository.GetById(id);
                if (developer == null) return null;
                return _mapper.Map<PortfolioVM>(developer);                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<PortfolioVM> BuscaPorId(int id, bool bGraduation, bool bExperience)
        {
            try
            {
                var developer = _repository.GetById(id, bGraduation, bExperience);
                if (developer == null) return null;
                return _mapper.Map<PortfolioVM>(developer);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
