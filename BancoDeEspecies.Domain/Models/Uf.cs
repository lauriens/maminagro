using System;
using System.Collections.Generic;

namespace BancoDeEspecies.Domain.Models
{
  public class Uf
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Abbreviation { get; set; }
    public int? CountryId { get; set; }

    public Country? Country { get; set; }
    public ICollection<Municipality> Municipalities { get; set; }
    public ICollection<ThreatDegree> ThreatDegrees { get; set; }
  }
}
