using Portfolio.Domain;
using System.Threading.Tasks;

namespace Portfolio.Services.Contracts
{
    public interface IDeveloperService
    {
        Task<Developer[]> GetDevelopers();
    }
}
