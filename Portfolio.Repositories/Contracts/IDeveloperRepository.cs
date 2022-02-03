using Portfolio.Domain;
using System.Threading.Tasks;

namespace Portfolio.Repositories.Contracts
{
    public interface IDeveloperRepository
    {
        Task<Developer[]> GetDevelopers();
    }
}
