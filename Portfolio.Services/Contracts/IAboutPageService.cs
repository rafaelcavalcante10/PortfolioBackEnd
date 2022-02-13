using Portfolio.Services.ViewModels;
using System.Threading.Tasks;

namespace Portfolio.Services.Contracts
{
    public interface IAboutPageService : IBaseService<PortfolioAboutVM>
    {
        Task<PortfolioAboutVM> DadosAboutPage(int id);
    }
}
