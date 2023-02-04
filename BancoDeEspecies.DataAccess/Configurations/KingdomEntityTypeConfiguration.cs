using BancoDeEspecies.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BancoDeEspecies.DataAccess.Configurations
{
    public class KingdomEntityTypeConfiguration : IEntityTypeConfiguration<Kingdom>
    {
        public void Configure(EntityTypeBuilder<Kingdom> builder)
        {
            builder
                .ToTable("Kingdoms");

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
                .HasOne(p => p.Domain)
                .WithMany(p => p.Kingdoms)
                .HasForeignKey(p => p.DomainId);
        }
    }
}