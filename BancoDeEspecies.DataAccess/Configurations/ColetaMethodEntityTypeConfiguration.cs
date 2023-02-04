using BancoDeEspecies.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BancoDeEspecies.DataAccess.Configurations
{
    public class ColetaMethodEntityTypeConfiguration : IEntityTypeConfiguration<OccurrenceColetaMethod>
    {
        public void Configure(EntityTypeBuilder<OccurrenceColetaMethod> builder)
        {
            builder
                .ToTable("ColetaMethods");

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
                .Property(p => p.Type);
        }
    }
}