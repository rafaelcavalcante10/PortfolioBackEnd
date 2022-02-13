using Portfolio.Repositories.Contracts;
using Portfolio.Services.Contracts;
using Portfolio.Services.ViewModels;
using System;
using System.Threading.Tasks;

namespace Portfolio.Services
{
    public class HomePageService : BaseService<PortfolioHomeVM>, IHomePageService
    {
        protected readonly IDeveloperRepository _developerRepository;
        
        public HomePageService(IDeveloperRepository repository)
        {
            _developerRepository = repository;
        }

        public async Task<PortfolioHomeVM> DadosHomePage(int id)
        {
            try
            {
                var developer = _developerRepository.GetById(id);
                if (developer == null) return null;
                var home = new PortfolioHomeVM();
                home.id = developer.id;
                home.nome = developer.nome;
                home.cargo = developer.cargo;
                return home;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public override Task<PortfolioHomeVM> BuscaPorId(int id)
        {
            return base.BuscaPorId(id);
        }
        public override Task<PortfolioHomeVM[]> BuscarTodos()
        {
            return base.BuscarTodos();
        }
    }
}
