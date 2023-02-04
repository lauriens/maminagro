using System;
using System.Collections.Generic;

namespace BancoDeEspecies.Domain.Models
{
  public class LandscapeStatistic
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Value { get; set; }
    public int? LandscapeId { get; set; }

    public Landscape? Landscape { get; set; }
  }
}
