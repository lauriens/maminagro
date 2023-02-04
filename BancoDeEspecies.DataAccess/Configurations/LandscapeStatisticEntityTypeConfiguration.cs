using BancoDeEspecies.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BancoDeEspecies.DataAccess.Configurations
{
    public class LandscapeStatisticEntityTypeConfiguration : IEntityTypeConfiguration<LandscapeStatistic>
    {
        public void Configure(EntityTypeBuilder<LandscapeStatistic> builder)
        {
            builder
                .ToTable("LandscapeStatistics");

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
                .Property(p => p.Value)
                .HasMaxLength(256);

            builder
                .HasOne(p => p.Landscape)
                .WithMany(p => p.LandscapeStatistics)
                .HasForeignKey(p => p.LandscapeId);
        }
    }
}