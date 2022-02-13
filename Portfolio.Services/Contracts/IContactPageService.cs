using Portfolio.Services.ViewModels;
using System.Threading.Tasks;

namespace Portfolio.Services.Contracts
{
    public interface IContactPageService : IBaseService<PortfolioContactVM>
    {
        Task<PortfolioContactVM> DadosContactPage(int id);
    }
}
