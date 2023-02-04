using System;
using System.Collections.Generic;

namespace BancoDeEspecies.Domain.Models
{
  public class ReferenceType
  {
    public int Id { get; set; }
    public string? TypeName { get; set; }
    public string? CreatedAt { get; set; }

    public ICollection<Reference> References { get; set; }
  }
}
