using BancoDeEspecies.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BancoDeEspecies.DataAccess.Configurations
{
    public class ReferenceEntityTypeConfiguration : IEntityTypeConfiguration<Reference>
    {
        public void Configure(EntityTypeBuilder<Reference> builder)
        {
            builder
                .ToTable("References");

            builder
                .HasKey(p => p.Id);

            builder
                .Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder
                .Property(p => p.AuthorName)
                .IsRequired()
                .HasMaxLength(128);

            builder
                .Property(p => p.Title)
                .HasMaxLength(256);

            builder
                .Property(p => p.Year);

            builder
                .Property(p => p.BibtexKey)
                .HasMaxLength(1024);

            builder
                .HasOne(p => p.ReferenceType)
                .WithMany(p => p.References)
                .HasForeignKey(p => p.ReferenceTypeId);
        }
    }
}