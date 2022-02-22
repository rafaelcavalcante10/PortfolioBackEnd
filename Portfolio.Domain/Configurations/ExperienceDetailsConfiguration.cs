using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.Domain.Models;

namespace Portfolio.Domain.Configurations
{
    public class ExperienceDetailsConfiguration : IEntityTypeConfiguration<ExperienceDetail>
    {
        public void Configure(EntityTypeBuilder<ExperienceDetail> builder)
        {
            builder.ToTable("experience_detail");
            builder.HasKey(k => new { k.id, k.id_experience });
            builder.Property(p => p.detalhe).IsRequired();
        }
    }
}
