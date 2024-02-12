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

            builder.Property(e => e.ResolutionDate)
                .HasColumnType("timestamp without time zone");

            builder.Property(e => e.Source);

            builder
                .HasOne(p => p.Specie)
                .WithMany(p => p.ThreatDegrees)
                .HasForeignKey(p => p.SpecieId);

            builder
                .HasOne(p => p.Uf)
                .WithMany(p => p.ThreatDegrees)
                .HasForeignKey(p => p.UfId);

            builder
                .HasOne(p => p.Country)
                .WithMany(p => p.ThreatDegrees)
                .HasForeignKey(p => p.CountryId);
        }
    }
}