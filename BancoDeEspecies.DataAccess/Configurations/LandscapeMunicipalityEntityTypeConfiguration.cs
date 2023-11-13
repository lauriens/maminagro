using BancoDeEspecies.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BancoDeEspecies.DataAccess.Configurations
{
    public class LandscapeMunicipalityEntityTypeConfiguration : IEntityTypeConfiguration<LandscapeMunicipality>
    {
        public void Configure(EntityTypeBuilder<LandscapeMunicipality> builder)
        {
            builder
                .HasKey(p => new
                {
                    p.MunicipalityId,
                    p.LandscapeId
                });

            builder
                .HasOne(p => p.Municipality)
                .WithMany("LandscapeMunicipalities")
                .HasForeignKey(lm => lm.MunicipalityId);

            builder
                .HasOne(p => p.Landscape)
                .WithMany("LandscapeMunicipalities")
                .HasForeignKey(lm => lm.LandscapeId);
        }
    }
}
