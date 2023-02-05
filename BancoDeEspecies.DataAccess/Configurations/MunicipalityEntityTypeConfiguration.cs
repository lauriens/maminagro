using BancoDeEspecies.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BancoDeEspecies.DataAccess.Configurations
{
    public class MunicipalityEntityTypeConfiguration : IEntityTypeConfiguration<Municipality>
    {
        public void Configure(EntityTypeBuilder<Municipality> builder)
        {
            builder
                .ToTable("Municipalities");

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
                .HasOne(p => p.Uf)
                .WithMany(p => p.Municipalities)
                .HasForeignKey(p => p.UfId);
        }
    }
}