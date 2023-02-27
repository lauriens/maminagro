using BancoDeEspecies.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BancoDeEspecies.DataAccess.Configurations
{
    public class StudyCollectMethodEntityTypeConfiguration : IEntityTypeConfiguration<StudyCollectMethod>
    {
        public void Configure(EntityTypeBuilder<StudyCollectMethod> builder)
        {
            builder
                .ToTable("StudyCollectMethods");

            builder
                .HasKey(p => p.Id);

            builder
                .Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder
                .Property(p => p.CollectStartDate)
                .HasColumnType("timestamp with time zone");

            builder
                .Property(p => p.CollectEndDate)
                .HasColumnType("timestamp with time zone");

            builder.Property(e => e.SampleDrawing);

            builder.Property(e => e.SamplingEffort);

            builder
                .Property(p => p.SamplingEffortUnit)
                .HasMaxLength(256);

            builder
                .HasOne(p => p.MaterialDestination)
                .WithMany(p => p.StudyCollectMethods)
                .HasForeignKey(p => p.MaterialDestinationId);

            builder
                .HasOne(p => p.Reference)
                .WithMany(p => p.StudyCollectMethods)
                .HasForeignKey(p => p.ReferenceId);
        }
    }
}