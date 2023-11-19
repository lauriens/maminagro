using BancoDeEspecies.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BancoDeEspecies.DataAccess.Configurations
{
    public class LandscapeLocalityEntityTypeConfiguration : IEntityTypeConfiguration<LandscapeLocality>
    {
        public void Configure(EntityTypeBuilder<LandscapeLocality> builder)
        {
            builder
                .ToTable("LandscapeLocalities");

            builder
                .HasKey(p => new
                {
                    p.LocalityId,
                    p.LandscapeId
                });

            builder
                .HasOne(p => p.Landscape)
                .WithMany("LandscapeLocalities")
                .HasForeignKey(p => p.LandscapeId);

            builder
                .HasOne(p => p.Locality)
                .WithMany("LandscapeLocalities")
                .HasForeignKey(p => p.LocalityId);
        }
    }
}
