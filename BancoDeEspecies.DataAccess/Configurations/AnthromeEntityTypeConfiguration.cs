using BancoDeEspecies.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BancoDeEspecies.DataAccess.Configurations
{
    public class AnthromeEntityTypeConfiguration : IEntityTypeConfiguration<Anthrome>
    {
        public void Configure(EntityTypeBuilder<Anthrome> builder)
        {
            builder
                .ToTable("Anthromes");

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