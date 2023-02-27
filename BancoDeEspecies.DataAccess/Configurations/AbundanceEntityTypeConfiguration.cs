using BancoDeEspecies.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BancoDeEspecies.DataAccess.Configurations
{
    public class AbundanceEntityTypeConfiguration : IEntityTypeConfiguration<Abundance>
    {
        public void Configure(EntityTypeBuilder<Abundance> builder)
        {
            builder
                .ToTable("Abundances");

            builder
                .HasKey(p => p.Id);

            builder
                .Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder
                .Property(p => p.AbundanceValue)
                .HasMaxLength(256);

            builder
                .HasOne(p => p.Occurrence)
                .WithMany(p => p.Abundances)
                .HasForeignKey(p => p.OccurrenceId)
                .IsRequired(false);

            builder
                .HasOne(p => p.Landscape)
                .WithMany(p => p.Abundances)
                .HasForeignKey(p => p.LandscapeId)
                .IsRequired(false);
        }
    }
}
