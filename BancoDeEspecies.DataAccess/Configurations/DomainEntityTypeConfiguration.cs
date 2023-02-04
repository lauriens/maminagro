using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BancoDeEspecies.DataAccess.Configurations
{
    public class DomainEntityTypeConfiguration : IEntityTypeConfiguration<Domain.Models.Domain>
    {
        public void Configure(EntityTypeBuilder<Domain.Models.Domain> builder)
        {
            builder
                .ToTable("Domains");

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