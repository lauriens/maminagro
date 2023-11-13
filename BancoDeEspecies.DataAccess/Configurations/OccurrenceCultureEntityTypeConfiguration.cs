using BancoDeEspecies.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BancoDeEspecies.DataAccess.Configurations
{
    public class OccurrenceCultureEntityTypeConfiguration : IEntityTypeConfiguration<OccurrenceCulture>
    {
        public void Configure(EntityTypeBuilder<OccurrenceCulture> builder)
        {
            builder
                .ToTable("OccurrenceCultures");

            builder
                .HasKey(p => new
                {
                    p.CultureId,
                    p.OccurrenceId
                });

            builder.Property(e => e.Area);

            builder.Property(e => e.IsMajority);

            builder.Property(e => e.Percentage);

            builder.Property(e => e.Phenology)
              .HasMaxLength(1024);

            builder.Property(e => e.Productivity);

            builder.Property(e => e.Stage)
              .HasMaxLength(256);

            builder
                .HasOne(p => p.Culture)
                .WithMany(p => p.OccurrenceCultures)
                .HasForeignKey(p => p.CultureId);

            builder
                .HasOne(p => p.Occurrence)
                .WithMany(p => p.OccurrenceCultures)
                .HasForeignKey(p => p.OccurrenceId);
        }
    }
}