using Portfolio.Services.Contracts;
using System;
using System.Threading.Tasks;

namespace Portfolio.Services
{
    public class BaseService<ViewModel> : IBaseService<ViewModel> where ViewModel : class
    {
        public BaseService()
        {

        }

        public virtual Task<ViewModel> BuscaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<ViewModel[]> BuscarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
