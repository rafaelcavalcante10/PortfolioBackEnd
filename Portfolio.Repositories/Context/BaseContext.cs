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
            modelBuilder.Entity<Graduation>().ToTable("graduations").HasKey(k => k.id);
            modelBuilder.Entity<Experience>().ToTable("experience").HasKey(k => k.id);
            modelBuilder.Entity<ExperienceDetail>().ToTable("experience_detail").HasKey(k => new { k.id, k.id_experience });
            
            modelBuilder.Entity<Developer>()
                .HasMany(g => g.graduations)
                .WithOne(d => d.developer)
                .HasForeignKey(f => f.id_developer);

            modelBuilder.Entity<Developer>()
                .HasMany(e => e.experiences)
                .WithOne(d => d.developer)
                .HasForeignKey(k => k.id_developer);

            modelBuilder.Entity<Experience>()
                .HasMany(d => d.experienceDetails)
                .WithOne(e => e.experience)
                .HasForeignKey(f => f.id_experience);

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
