using System.ComponentModel.DataAnnotations.Schema;

namespace BancoDeEspecies.Domain.Models
{
    public class Landscape
    {
        public int Id { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public decimal? Radius { get; set; }
        public string? Description { get; set; }
        public bool? IsProtectedArea { get; set; }
        public Agroecosystem Agroecosystem { get; set; }
        public int? AgroecosystemId { get; set; }
        public int? AnthromeId { get; set; }
        public int? CityId { get; set; }
        public int? ReferenceId { get; set; }
        public int? SampleAreaTypeId { get; set; }
        public Anthrome? Anthrome { get; set; }

        private ICollection<LandscapeMunicipality>? LandscapeMunicipalities { get; set; }

        [NotMapped]
        public IEnumerable<Municipality>? Municipalities => LandscapeMunicipalities.Select(lm => lm.Municipality);

        public Reference? Reference { get; set; }
        public SampleAreaType SampleAreaType { get; set; }
        public ICollection<Abundance> Abundances { get; set; }

        private ICollection<BiomeLandscape> BiomeLandscapes { get; set; }

        [NotMapped]
        public IEnumerable<Biome>? Biomes => BiomeLandscapes.Select(bl => bl.Biome);

        public ICollection<Culture> Cultures { get; set; }
        public ICollection<LandscapeAreaType> LandscapeAreaTypes { get; set; }
        public ICollection<LandscapeStatistic> LandscapeStatistics { get; set; }

        public ICollection<Locality> Localities { get; set; }
    }
}
