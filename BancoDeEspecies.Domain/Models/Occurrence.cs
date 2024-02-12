using BancoDeEspecies.Domain.Enums;

namespace BancoDeEspecies.Domain.Models
{
  public class Occurrence
  {
    public int Id { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public DateTime? OccurrenceTime { get; set; }
    public bool? IsDuplicate { get; set; }
    public OccurrenceType OccurrenceType { get; set; }
    public bool IsSnucOccurrence { get; set; }
    public string? ReviewerObservation { get; set; }
    public int CreatedBy { get; set; }
    public int? ThreatDegreeId { get; set; }
    public int? OccurrenceMethodId { get; set; }
    public int? SpecieId { get; set; }
    public int? ReferenceId { get; set; }
    public int? LocalityId { get; set; }

    public OccurrenceColetaMethod? OccurrenceColetaMethod { get; set; }
    public Reference? Reference { get; set; }
    public Specie? Specie { get; set; }
    public ThreatDegree? ThreatDegree { get; set; }
    public User User { get; set; }
    public ICollection<Abundance> Abundances { get; set; }
    public ICollection<OccurrenceCulture> OccurrenceCultures { get; set; }
    public Locality? Locality { get; set; }
  }
}
