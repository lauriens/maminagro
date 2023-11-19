using BancoDeEspecies.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BancoDeEspecies.DataAccess.Configurations
{
    public class LandscapeAreaTypeEntityTypeConfiguration : IEntityTypeConfiguration<LandscapeAreaType>
    {
        public void Configure(EntityTypeBuilder<LandscapeAreaType> builder)
        {
            builder
                .ToTable("LandscapeAreaTypes");

            builder
                .HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder
                .Property(e => e.Percentage);

            builder
                .HasOne(p => p.AreaType)
                .WithMany(p => p.LandscapeAreaTypes)
                .HasForeignKey(p => p.AreaTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(p => p.Landscape)
                .WithMany("LandscapeAreaTypes")
                .HasForeignKey(p => p.LandscapeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}