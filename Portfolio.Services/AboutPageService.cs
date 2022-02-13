using Portfolio.Repositories.Contracts;
using Portfolio.Services.Contracts;
using Portfolio.Services.ViewModels;
using System;
using System.Threading.Tasks;

namespace Portfolio.Services
{
    public class AboutPageService : BaseService<PortfolioAboutVM>, IAboutPageService
    {
        protected readonly IDeveloperRepository _developerRepository;
        public AboutPageService(IDeveloperRepository repository)
        {
            _developerRepository = repository;
        }

        public async Task<PortfolioAboutVM> DadosAboutPage(int id)
        {
            try
            {
                var developer = _developerRepository.GetById(1);
                if (developer == null) return null;
                var about = new PortfolioAboutVM();
                about.id = developer.id;
                about.nascimento = developer.nascimento;
                about.cidade = developer.cidade;
                about.email = developer.email;
                about.resumo = developer.resumo;
                about.site = developer.site;
                about.sobre = developer.sobre;
                return about;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public override Task<PortfolioAboutVM[]> BuscarTodos()
        {
            return base.BuscarTodos();
        }
        public override Task<PortfolioAboutVM> BuscaPorId(int id)
        {
            return base.BuscaPorId(id);
        }
    }
}
