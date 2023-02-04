using BancoDeEspecies.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BancoDeEspecies.DataAccess.Configurations
{
    public class SampleAreaTypeEntityTypeConfiguration : IEntityTypeConfiguration<SampleAreaType>
    {
        public void Configure(EntityTypeBuilder<SampleAreaType> builder)
        {
            builder
                .ToTable("SampleAreaTypes");

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
                .Property(p => p.IsSnuc);
        }
    }
}