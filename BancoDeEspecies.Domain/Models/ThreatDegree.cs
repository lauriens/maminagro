using BancoDeEspecies.Domain.Enums;

namespace BancoDeEspecies.Domain.Models
{
  public class ThreatDegree
  {
    public int Id { get; set; }
    public string? Classification { get; set; }
    public DateTime? ResolutionDate { get; set; }
    public ThreatDegreeSource Source { get; set; }
    public int? UfId { get; set; }
    public int? CountryId { get; set; }
    public int? SpeciesId { get; set; }

    public Specie? Species { get; set; }
    public Uf? Uf { get; set; }
    public Country? Country { get; set; }
    public ICollection<Occurrence> Occurences { get; set; }
  }
}
