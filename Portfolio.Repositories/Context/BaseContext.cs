using Microsoft.EntityFrameworkCore;
using Portfolio.Domain;

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

            modelBuilder.Entity<Developer>().ToTable("developer").HasKey(k => k.id);
            modelBuilder.Entity<Graduations>().ToTable("graduations").HasKey(k => k.id);
            
            modelBuilder.Entity<Developer>()
                .HasMany(g => g.graduations)
                .WithOne(d => d.developer)
                .HasForeignKey(f => f.id_developer);
                                
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
