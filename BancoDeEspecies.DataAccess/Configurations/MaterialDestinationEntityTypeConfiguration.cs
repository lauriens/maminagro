using BancoDeEspecies.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BancoDeEspecies.DataAccess.Configurations
{
    public class MaterialDestinationEntityTypeConfiguration : IEntityTypeConfiguration<MaterialDestination>
    {
        public void Configure(EntityTypeBuilder<MaterialDestination> builder)
        {
            builder
                .ToTable("MaterialDestinations");

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
                .Property(p => p.Description)
                .HasMaxLength(1024);

            builder
                .Property(p => p.GbifId)
                .HasMaxLength(128);
        }
    }
}