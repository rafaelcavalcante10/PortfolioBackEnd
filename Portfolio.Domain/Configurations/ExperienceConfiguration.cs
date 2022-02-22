using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.Domain.Models;

namespace Portfolio.Domain.Configurations
{
    public class ExperienceConfiguration : IEntityTypeConfiguration<Experience>
    {
        public void Configure(EntityTypeBuilder<Experience> builder)
        {
            builder.ToTable("experience");
            builder.HasKey(k => k.id);
            builder.Property(p => p.cargo).IsRequired();
            builder.Property(p => p.empresa).IsRequired();
            builder.Property(p => p.inicio).IsRequired();
            builder.Property(p => p.fim).IsRequired();
            builder.HasMany(e => e.experienceDetails).WithOne(o => o.experience).HasForeignKey(k => k.id_experience);
        }
    }
}
