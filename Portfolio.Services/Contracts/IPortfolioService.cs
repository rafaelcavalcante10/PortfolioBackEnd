using Portfolio.Services.ViewModels;
using System.Threading.Tasks;

namespace Portfolio.Services.Contracts
{
    public interface IPortfolioService : IBaseService<PortfolioVM>
    {
        Task<PortfolioVM> BuscaPorId(int id, bool bGraduation, bool bExperience);
    }
}
