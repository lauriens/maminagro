using BancoDeEspecies.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BancoDeEspecies.DataAccess.Configurations
{
    public class LandscapeEntityTypeConfiguration : IEntityTypeConfiguration<Landscape>
    {
        public void Configure(EntityTypeBuilder<Landscape> builder)
        {
            builder
                .ToTable("Landscapes");

            builder
                .HasKey(p => p.Id);

            builder
                .Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder
                .Property(p => p.Agroecosystem)
                .IsRequired();

            builder
                .Property(p => p.Description)
                .HasMaxLength(1024);

            builder
                .Property(e => e.IsProtectedArea);

            builder
                .Property(e => e.Latitude);

            builder
                .Property(e => e.Longitude);

            builder
                .Property(e => e.Radius);

            builder
                .HasOne(p => p.Reference)
                .WithMany(p => p.Landscapes)
                .HasForeignKey(p => p.ReferenceId);

            builder
                .HasOne(p => p.Anthrome)
                .WithMany(p => p.Landscapes)
                .HasForeignKey(p => p.AnthromeId);

            builder
                .HasOne(p => p.SampleAreaType)
                .WithMany(p => p.Landscapes)
                .HasForeignKey(p => p.SampleAreaTypeId);

            builder
                .HasMany(p => p.Biomes)
                .WithMany(p => p.Landscapes);

            builder
                .HasMany(p => p.Localities)
                .WithMany(p => p.Landscapes);

            builder
                .HasOne(p => p.Municipality)
                .WithMany(p => p.Landscapes)
                .HasForeignKey(p => p.CityId);
        }
    }
}