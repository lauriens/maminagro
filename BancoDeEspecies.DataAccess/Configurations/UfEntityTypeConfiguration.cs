using BancoDeEspecies.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BancoDeEspecies.DataAccess.Configurations
{
    public class UfEntityTypeConfiguration : IEntityTypeConfiguration<Uf>
    {
        public void Configure(EntityTypeBuilder<Uf> builder)
        {
            builder
                .ToTable("Ufs");

            builder
                .HasKey(p => p.Id);

            builder
                .Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(p => p.Abbreviation)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            builder
                .HasOne(p => p.Country)
                .WithMany(p => p.Ufs)
                .HasForeignKey(p => p.CountryId);
        }
    }
}