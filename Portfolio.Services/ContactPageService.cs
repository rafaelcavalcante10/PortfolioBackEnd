using Portfolio.Repositories.Contracts;
using Portfolio.Services.Contracts;
using Portfolio.Services.ViewModels;
using System;
using System.Threading.Tasks;

namespace Portfolio.Services
{
    public class ContactPageService : BaseService<PortfolioContactVM>, IContactPageService
    {
        private readonly IDeveloperRepository _developerRepository;
        public ContactPageService(IDeveloperRepository developerRepository)
        {
            _developerRepository = developerRepository;
        }

        public async Task<PortfolioContactVM> DadosContactPage(int id)
        {
            try
            {
                var developer = _developerRepository.GetById(id);
                if (developer == null) return null;
                var contact = new PortfolioContactVM();
                contact.id = developer.id;
                contact.endereco = developer.endereco;
                contact.bairro = developer.bairro;
                contact.cidade = developer.cidade;
                contact.email = developer.email;
                contact.telefone = developer.telefone;

                return contact;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }            
        }
        public override Task<PortfolioContactVM> BuscaPorId(int id)
        {
            return base.BuscaPorId(id);
        }
        public override Task<PortfolioContactVM[]> BuscarTodos()
        {
            return base.BuscarTodos();
        }
    }
}
