namespace BancoDeEspecies.Domain.Models
{
  public class Specie
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public int? GenusId { get; set; }

    public Genus? Genus { get; set; }
    public ICollection<Occurrence> Occurrences { get; set; }
    public ICollection<ThreatDegree> ThreatDegrees { get; set; }
  }
}
