using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.Domain.Models;

namespace Portfolio.Domain.Configurations
{
    public class DeveloperConfiguration : IEntityTypeConfiguration<Developer>
    {
        public void Configure(EntityTypeBuilder<Developer> builder)
        {
            builder.ToTable("developer");
            builder.HasKey(e => e.id);
            builder.Property(p => p.nome).IsRequired();
            builder.Property(p => p.nascimento).IsRequired();
            builder.HasMany(g => g.graduations).WithOne(d => d.developer).HasForeignKey(f => f.id_developer);
            builder.HasMany(e => e.experiences).WithOne(d => d.developer).HasForeignKey(f => f.id_developer);
        }
    }
}
