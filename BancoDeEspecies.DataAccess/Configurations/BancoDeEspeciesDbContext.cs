using BancoDeEspecies.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BancoDeEspecies.DataAccess.Configurations
{
    public class BancoDeEspeciesDbContext : DbContext
    {

        public BancoDeEspeciesDbContext(DbContextOptions<BancoDeEspeciesDbContext> options)
          : base(options)
        {
        }

        public DbSet<AreaType> AreaTypes { get; set; }
        public DbSet<Biome> Biomes { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<OccurrenceColetaMethod> ColetaMethods { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Culture> Cultures { get; set; }
        public DbSet<CultureSpecie> CultureSpecies { get; set; }
        public DbSet<Domain.Models.Domain> Domains { get; set; }
        public DbSet<Family> Families { get; set; }
        public DbSet<Genus> Genera { get; set; }
        public DbSet<Kingdom> Kingdoms { get; set; }
        public DbSet<Landscape> Landscapes { get; set; }
        public DbSet<LandscapeAreaType> LandscapeAreaTypes { get; set; }
        public DbSet<LandscapeStatistic> LandscapeStatistics { get; set; }
        public DbSet<Locality> Locations { get; set; }
        public DbSet<LocalityType> LocationTypes { get; set; }
        public DbSet<MaterialDestination> MaterialDestinations { get; set; }
        public DbSet<Occurrence> Occurences { get; set; }
        public DbSet<OccurrenceCulture> OccurrenceCultures { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Phylum> Phylas { get; set; }
        public DbSet<Reference> References { get; set; }
        public DbSet<ReferenceType> ReferenceTypes { get; set; }
        public DbSet<SampleAreaType> SampleAreaTypes { get; set; }
        public DbSet<Specie> Species { get; set; }
        public DbSet<StudyCollectMethod> StudyCollectMethods { get; set; }
        public DbSet<ThreatDegree> ThreatDegrees { get; set; }
        public DbSet<Uf> Ufs { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CityEntityTypeConfiguration).Assembly);
        }

    }
}
