using BancoDeEspecies.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BancoDeEspecies.DataAccess.Configurations
{
    public class AgroecosystemEntityTypeConfiguration : IEntityTypeConfiguration<Agroecosystem>
    {
        public void Configure(EntityTypeBuilder<Agroecosystem> builder)
        {
            builder
                .ToTable("Agroecosystems");

            builder
                .HasKey(a => a.Id);

            builder
                .Property(a => a.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder
                .Property(a => a.Name)
                .HasMaxLength(256);

            builder
                .Property(a => a.Abbreviation)
                .HasMaxLength(50);
        }
    }
}
