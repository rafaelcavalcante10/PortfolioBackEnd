using System.Threading.Tasks;

namespace Portfolio.Services.Contracts
{
    public interface IBaseService<ViewModel> where ViewModel : class
    {
        Task<ViewModel[]> BuscarTodos();
        Task<ViewModel> BuscaPorId(int id);
    }
}
