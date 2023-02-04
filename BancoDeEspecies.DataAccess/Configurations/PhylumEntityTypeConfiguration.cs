using BancoDeEspecies.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BancoDeEspecies.DataAccess.Configurations
{
    public class PhylumEntityTypeConfiguration : IEntityTypeConfiguration<Phylum>
    {
        public void Configure(EntityTypeBuilder<Phylum> builder)
        {
            builder
                .ToTable("Phyla");

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
                .HasOne(p => p.Kingdom)
                .WithMany(p => p.Phyla)
                .HasForeignKey(p => p.KingdomId);
        }
    }
}