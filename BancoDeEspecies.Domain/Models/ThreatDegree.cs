using System;
using System.Collections.Generic;

namespace BancoDeEspecies.Domain.Models
{
  public class ThreatDegree
  {
    public int Id { get; set; }
    public string? Classification { get; set; }
    public DateTime? MmaDate { get; set; }
    public DateTime? IucnDate { get; set; }
    public DateTime? UfResolutionDate { get; set; }
    public int? UfId { get; set; }
    public int? SpeciesId { get; set; }

    public Specie? Species { get; set; }
    public Uf? Uf { get; set; }
    public ICollection<Occurrence> Occurences { get; set; }
  }
}
