using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Configurations;

namespace Portfolio.Repositories.Context
{
    public partial class BaseContext<TContext> : DbContext where TContext : DbContext
    {
        public BaseContext(DbContextOptions<TContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("portfolio");
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DeveloperConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ExperienceConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ExperienceDetailsConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GraduationConfiguration).Assembly);
            
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
