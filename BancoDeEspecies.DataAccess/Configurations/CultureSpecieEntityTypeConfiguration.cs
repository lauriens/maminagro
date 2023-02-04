using BancoDeEspecies.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BancoDeEspecies.DataAccess.Configurations
{
    public class CultureSpecieEntityTypeConfiguration : IEntityTypeConfiguration<CultureSpecie>
    {
        public void Configure(EntityTypeBuilder<CultureSpecie> builder)
        {
            builder
                .ToTable("CultureSpecies");

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

            builder
                .HasOne(p => p.Genus)
                .WithMany(p => p.CultureSpecies)
                .HasForeignKey(p => p.GenusId);
        }
    }
}