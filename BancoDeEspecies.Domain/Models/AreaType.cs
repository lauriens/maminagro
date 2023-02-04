using System;
using System.Collections.Generic;

namespace BancoDeEspecies.Domain.Models
{
  public class AreaType
  {
    public int Id { get; set; }
    public string? Name { get; set; }

    public ICollection<LandscapeAreaType> LandscapeAreaTypes { get; set; }
  }
}
