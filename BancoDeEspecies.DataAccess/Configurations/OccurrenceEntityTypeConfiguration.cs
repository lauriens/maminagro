using BancoDeEspecies.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BancoDeEspecies.DataAccess.Configurations
{
    public class OccurrenceEntityTypeConfiguration : IEntityTypeConfiguration<Occurrence>
    {
        public void Configure(EntityTypeBuilder<Occurrence> builder)
        {
            builder
                .ToTable("Occurrences");

            builder
                .HasKey(p => p.Id);

            builder
                .Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder
                .Property(p => p.StartDate);

            builder
                .Property(p => p.EndDate);

            builder
                .Property(p => p.OccurrenceTime);

            builder
                .Property(p => p.IsDuplicate);

            builder
                .Property(p => p.OccurrenceType);

            builder
                .Property(p => p.IsSnucOccurrence);

            builder
                .Property(p => p.ReviewerObservation)
                .HasMaxLength(2048);

            builder
                .HasOne(p => p.User)
                .WithMany()
                .HasForeignKey(p => p.CreatedBy);

            builder
                .HasOne(p => p.OccurenceColetaMethod)
                .WithMany(p => p.Occurences)
                .HasForeignKey(p => p.OccurenceMethodId);

            builder
                .HasOne(p => p.Reference)
                .WithMany(p => p.Occurences)
                .HasForeignKey(p => p.ReferenceId);

            builder
                .HasOne(p => p.Specie)
                .WithMany(p => p.Occurences)
                .HasForeignKey(p => p.SpecieId);

            builder
                .HasOne(p => p.ThreatDegree)
                .WithMany(p => p.Occurences)
                .HasForeignKey(p => p.ThreatDegreeId);

            builder
                .HasOne(p => p.Locality)
                .WithMany(p => p.Occurences)
                .HasForeignKey(p => p.LocalityId);
        }
    }
}