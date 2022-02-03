using Portfolio.Domain;
using Portfolio.Repositories.Contracts;
using Portfolio.Services.Contracts;
using System;
using System.Threading.Tasks;

namespace Portfolio.Services
{
    public class DeveloperService : IDeveloperService
    {
        private readonly IDeveloperRepository _repository;
        public DeveloperService(IDeveloperRepository repository)
        {
            _repository = repository;
        }
        public async Task<Developer[]> GetDevelopers()
        {
            try
            {
                var developers = await _repository.GetDevelopers();
                if (developers == null) return null;

                return developers;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
