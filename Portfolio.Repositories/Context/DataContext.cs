using Microsoft.EntityFrameworkCore;
using Portfolio.Domain;

namespace Portfolio.Repositories.Context
{
    public class DataContext : BaseContext<DataContext>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Developer> Developers { get; set; }

    }
}
