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
        private readonly IExperienceDetailRepository _experienceDetailRepository;
        public ResumePageService(IDeveloperRepository developerRepository,
            IGraduationRepository graduationRepository,
            IExperienceRepository experienceRepository,
            IExperienceDetailRepository experienceDetailRepository)
        {
            _developerRepository = developerRepository;
            _graduationRepository = graduationRepository;
            _experienceRepository = experienceRepository;
            _experienceDetailRepository = _experienceDetailRepository;
        }

        public async Task<PortfolioResumeVM> DadosResumePage(int id)
        {
            try
            {
                var developer = _developerRepository.GetById(id);
                var graduations = _graduationRepository.GetByIdDeveloper(id);
                var experiences = _experienceRepository.GetByIdDeveloper(id);
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
                foreach(var experience in experiences)
                {
                    resume.experiences.Add(new Experience
                    {
                        id = experience.id,
                        cargo = experience.cargo,
                        empresa = experience.empresa,
                        inicio = experience.inicio,
                        fim = experience.fim,
                        experienceDetails = new List<ExperienceDetail>(),
                        id_developer = experience.id_developer
                    });
                }
                resume.graduations = new List<Graduation>();
                foreach(var graduation in graduations)
                {
                    resume.graduations.Add(new Graduation
                    {
                        id = graduation.id,
                        curso = graduation.curso,
                        descricao = graduation.descricao,
                        inicio = graduation.inicio,
                        fim = graduation.fim,
                        id_developer = graduation.id_developer,
                        universidade = graduation.universidade
                    });
                }
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
