using BancoDeEspecies.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BancoDeEspecies.DataAccess.Configurations
{
    public class BiomeLandscapeEntityTypeConfiguration : IEntityTypeConfiguration<BiomeLandscape>
    {
        public void Configure(EntityTypeBuilder<BiomeLandscape> builder)
        {
            builder
                .ToTable("BiomeLandscapes");

            builder
                .HasKey(p => new
                {
                    p.BiomeId,
                    p.LandscapeId
                });

            builder
                .HasOne(p => p.Biome)
                .WithMany("BiomeLandscapes")
                .HasForeignKey(bl => bl.BiomeId);

            builder
                .HasOne(p => p.Landscape)
                .WithMany("BiomeLandscapes")
                .HasForeignKey(bl => bl.LandscapeId);
        }
    }
}
