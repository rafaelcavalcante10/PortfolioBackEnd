using AutoMapper;
using Portfolio.Repositories.Contracts;
using Portfolio.Services.Contracts;
using System;
using System.Threading.Tasks;

namespace Portfolio.Services
{
    public class BaseService<ViewModel> : IBaseService<ViewModel> where ViewModel : class
    {
        protected readonly IDeveloperRepository _repository;
        protected readonly IMapper _mapper;
        public BaseService(IDeveloperRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
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
