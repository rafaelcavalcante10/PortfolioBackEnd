using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Models;

namespace Portfolio.Repositories.Context
{
    public class DataContext : BaseContext<DataContext>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Developer> Developers { get; set; }
        public DbSet<Graduation> Graduations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<ExperienceDetail> ExperienceDetails { get; set; }

    }
}
