using AutoMapper;
using Portfolio.Repositories.Contracts;
using Portfolio.Services.Contracts;
using Portfolio.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Services
{
    public class PortfolioService : BaseService<PortfolioVM>, IPortfolioService
    {
        public PortfolioService(IDeveloperRepository developerRepository, 
                                IGraduationRepository graduationRepository, 
                                IExperienceRepository experienceRepository, 
                                IExperienceDetailRepository experienceDetailRepository, 
                                IMapper mapper) : base(developerRepository, graduationRepository, experienceRepository, experienceDetailRepository, mapper) 
        {

        }
       
        public override async Task<PortfolioVM> BuscaPorId(int id)
        {
            try
            {
                base.LerBaseTxt();
                var developer = _developerRepository.GetById(id);
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
                base.LerBaseTxt();
                var developer = _developerRepository.GetById(id, bGraduation, bExperience);
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
