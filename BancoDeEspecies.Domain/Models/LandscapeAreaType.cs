using System;
using System.Collections.Generic;

namespace BancoDeEspecies.Domain.Models
{
  public class LandscapeAreaType
  {
    public int LandscapeId { get; set; }
    public int AreaTypeId { get; set; }
    public decimal? Percentage { get; set; }

    public AreaType AreaType { get; set; } = null!;
    public Landscape Landscape { get; set; } = null!;
  }
}
