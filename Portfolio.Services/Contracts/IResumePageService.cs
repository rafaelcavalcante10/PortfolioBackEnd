using Portfolio.Services.ViewModels;
using System.Threading.Tasks;

namespace Portfolio.Services.Contracts
{
    public interface IResumePageService : IBaseService<PortfolioResumeVM>
    {
        Task<PortfolioResumeVM> DadosResumePage(int id);
    }
}
