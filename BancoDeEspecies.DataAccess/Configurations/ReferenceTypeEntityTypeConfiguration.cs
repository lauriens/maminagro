using BancoDeEspecies.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BancoDeEspecies.DataAccess.Configurations
{
    public class ReferenceTypeEntityTypeConfiguration : IEntityTypeConfiguration<ReferenceType>
    {
        public void Configure(EntityTypeBuilder<ReferenceType> builder)
        {
            builder
                .ToTable("ReferenceTypes");

            builder
                .HasKey(p => p.Id);

            builder
                .Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder
                .Property(p => p.TypeName)
                .IsRequired()
                .HasMaxLength(256);
        }
    }
}