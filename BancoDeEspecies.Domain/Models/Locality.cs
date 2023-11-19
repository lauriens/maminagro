using System.ComponentModel.DataAnnotations.Schema;

namespace BancoDeEspecies.Domain.Models
{
    public class Locality
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public int? TypeId { get; set; }

        public SampleAreaType? LocalityType { get; set; }

        private ICollection<LandscapeLocality> LandscapeLocalities { get; set; }

        [NotMapped]
        public IEnumerable<Landscape> Landscapes => LandscapeLocalities?.Select(ll => ll.Landscape);

        public ICollection<Occurrence> Occurrences { get; set; }
    }
}
