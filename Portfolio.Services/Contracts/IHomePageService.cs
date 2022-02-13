using Portfolio.Services.ViewModels;
using System.Threading.Tasks;

namespace Portfolio.Services.Contracts
{
    public interface IHomePageService : IBaseService<PortfolioHomeVM>
    {
        Task<PortfolioHomeVM> DadosHomePage(int id);
    }
}
