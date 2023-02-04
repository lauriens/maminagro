using BancoDeEspecies.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BancoDeEspecies.DataAccess.Configurations
{
    public class LocalityTypeEntityTypeConfiguration : IEntityTypeConfiguration<LocalityType>
    {
        public void Configure(EntityTypeBuilder<LocalityType> builder)
        {
            builder
                .ToTable("LocalityTypes");

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