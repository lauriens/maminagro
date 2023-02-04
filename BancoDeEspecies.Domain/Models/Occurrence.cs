using BancoDeEspecies.Domain.Enums;

namespace BancoDeEspecies.Domain.Models
{
  public class Occurrence
  {
    public int Id { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public bool? IsDuplicate { get; set; }
    public OccurrenceType OccurrenceType { get; set; }
    public bool IsSnucOccurrence { get; set; }
    public int? ThreatDegreeId { get; set; }
    public int? OccurenceMethodId { get; set; }
    public int? SpeciesId { get; set; }
    public int? ReferenceId { get; set; }

    public OccurrenceColetaMethod? OccurenceMethod { get; set; }
    public Reference? Reference { get; set; }
    public Specie? Species { get; set; }
    public ThreatDegree? ThreatDegree { get; set; }
    public ICollection<OccurrenceCulture> OccurrenceCultures { get; set; }

    public ICollection<Locality> Localities { get; set; }
  }
}
