using Portfolio.Domain;
using Portfolio.Repositories.Contracts;
using Portfolio.Services.Contracts;
using Portfolio.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Portfolio.Services
{
    public class ResumePageService : BaseService<PortfolioResumeVM>, IResumePageService
    {
        private readonly IDeveloperRepository _developerRepository;
        private readonly IGraduationRepository _graduationRepository;
        private readonly IExperienceRepository _experienceRepository;
        public ResumePageService(IDeveloperRepository developerRepository,
            IGraduationRepository graduationRepository,
            IExperienceRepository experienceRepository)
        {
            _developerRepository = developerRepository;
            _graduationRepository = graduationRepository;
            _experienceRepository = experienceRepository;
        }

        public async Task<PortfolioResumeVM> DadosResumePage(int id)
        {
            try
            {
                var developer = _developerRepository.GetById(id);
                var graduation = _graduationRepository.GetByIdDeveloper(id);
                var experience = _experienceRepository.GetByIdDeveloper(id);
                var resume = new PortfolioResumeVM();
                resume.id = developer.id;
                resume.bairro = developer.bairro;
                resume.cidade = developer.cidade;
                resume.email = developer.email;
                resume.endereco = developer.endereco;
                resume.informacao = developer.informacao;
                resume.nome = developer.nome;
                resume.telefone = developer.telefone;
                resume.experiences = new List<Experience>();
                resume.experiences = experience;
                resume.graduations = new List<Graduation>();
                resume.graduations = graduation;
                return resume;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public override Task<PortfolioResumeVM> BuscaPorId(int id)
        {
            return base.BuscaPorId(id);
        }
        public override Task<PortfolioResumeVM[]> BuscarTodos()
        {
            return base.BuscarTodos();
        }
    }
}
