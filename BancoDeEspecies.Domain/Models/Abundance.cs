namespace BancoDeEspecies.Domain.Models
{
    public class Abundance
    {
        public int Id { get; set; }
        public string AbundanceValue { get; set; }
        public int? LandscapeId { get; set; }
        public int? OccurrenceId { get; set; }
        public Landscape Landscape { get; set; }
        public Occurrence Occurrence { get; set; }
    }
}
