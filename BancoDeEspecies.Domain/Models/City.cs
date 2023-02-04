using System;
using System.Collections.Generic;

namespace BancoDeEspecies.Domain.Models
{
  public class City
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public int? UfId { get; set; }

    public Uf? Uf { get; set; }
    public ICollection<Landscape> Landscapes { get; set; }
  }
}
