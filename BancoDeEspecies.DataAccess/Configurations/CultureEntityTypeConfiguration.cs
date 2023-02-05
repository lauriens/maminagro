using BancoDeEspecies.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BancoDeEspecies.DataAccess.Configurations
{
    public class CultureEntityTypeConfiguration : IEntityTypeConfiguration<Culture>
    {
        public void Configure(EntityTypeBuilder<Culture> builder)
        {
            builder
                .ToTable("Cultures");

            builder
                .HasKey(p => p.Id);

            builder
                .Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder
                .Property(p => p.CommonName)
                .HasMaxLength(256);

            builder
                .Property(p => p.ScientificName)
                .IsRequired()
                .HasMaxLength(256);

            builder
                .Property(p => p.Phenology)
                .HasMaxLength(1024);

            builder
                .Property(e => e.PlantedArea);

            builder
                .Property(e => e.SpeciesType);

            builder
                .Property(e => e.TimeSincePlanting);

            builder
                .Property(e => e.TimeSinclePlantingUnit);

            builder
                .Property(e => e.Variety);

            builder
                .HasOne(p => p.Specie)
                .WithMany(p => p.Cultures)
                .HasForeignKey(p => p.SpecieId);
        }
    }
}