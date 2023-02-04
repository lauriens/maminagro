using BancoDeEspecies.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BancoDeEspecies.DataAccess.Configurations
{
    public class ThreatDegreeEntityTypeConfiguration : IEntityTypeConfiguration<ThreatDegree>
    {
        public void Configure(EntityTypeBuilder<ThreatDegree> builder)
        {
            builder
                .ToTable("ThreatDegrees");

            builder
                .HasKey(p => p.Id);

            builder
                .Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder
                .Property(p => p.Classification)
                .HasMaxLength(256);

            builder.Property(e => e.IucnDate)
                .HasColumnType("timestamp without time zone");

            builder.Property(e => e.MmaDate)
              .HasColumnType("timestamp without time zone");

            builder.Property(e => e.UfResolutionDate)
                .HasColumnType("timestamp without time zone");

            builder
                .HasOne(p => p.Species)
                .WithMany(p => p.ThreatDegrees)
                .HasForeignKey(p => p.SpeciesId);

            builder
                .HasOne(p => p.Uf)
                .WithMany(p => p.ThreatDegrees)
                .HasForeignKey(p => p.UfId);
        }
    }
}