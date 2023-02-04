using BancoDeEspecies.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BancoDeEspecies.DataAccess.Configurations
{
    public class BiomeEntityTypeConfiguration : IEntityTypeConfiguration<Biome>
    {
        public void Configure(EntityTypeBuilder<Biome> builder)
        {
            builder
                .ToTable("Biomes");

            builder
                .HasKey(p => p.Id);

            builder
                .Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(200);
        }
    }
}