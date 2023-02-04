using System;
using System.Collections.Generic;

namespace BancoDeEspecies.Domain.Models
{
  public class User
  {
    public int Id { get; set; }
    public string? FullName { get; set; }
    public DateTime? CreatedAt { get; set; }
    public int? CountryCode { get; set; }
  }
}
