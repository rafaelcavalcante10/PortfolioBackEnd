using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.Domain.Models;

namespace Portfolio.Domain.Configurations
{
    public class GraduationConfiguration : IEntityTypeConfiguration<Graduation>
    {
        public void Configure(EntityTypeBuilder<Graduation> builder)
        {
            builder.ToTable("graduations");
            builder.HasKey(k => k.id);
            builder.Property(p => p.curso).IsRequired();
            builder.Property(p => p.inicio).IsRequired();
            builder.Property(p => p.fim).IsRequired();
            builder.Property(p => p.universidade).IsRequired();
        }
    }
}
