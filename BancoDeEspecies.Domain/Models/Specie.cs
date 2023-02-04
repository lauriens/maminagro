namespace BancoDeEspecies.Domain.Models
{
  public class Specie
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public int? IucnThreatDegree { get; set; }
    public int? NationalThreatDegree { get; set; }
    public int? GenusId { get; set; }

    public Genus? Genus { get; set; }
    public Kingdom? Kingdom { get; set; }
    public Phylum? Phylum { get; set; }
    public ICollection<Occurrence> Occurences { get; set; }
    public ICollection<ThreatDegree> ThreatDegrees { get; set; }
  }
}
