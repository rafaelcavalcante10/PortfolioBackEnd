using Microsoft.EntityFrameworkCore;
using Portfolio.Domain;
using Portfolio.Repositories.Context;
using Portfolio.Repositories.Contracts;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Repositories
{
    public class DeveloperRepository : IDeveloperRepository
    {
        private readonly DataContext _context;
        public DeveloperRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Developer[]> GetDevelopers()
        {
            try
            {
                IQueryable<Developer> query = _context.Developers.Include(d => d.graduations).OrderByDescending(o => o.id);
                
                if (query == null) return null;

                return await query.ToArrayAsync();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
