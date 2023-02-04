using BancoDeEspecies.Domain.Enums;

namespace BancoDeEspecies.Domain.Models
{
  public class OccurrenceColetaMethod
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public ColetaMethodType? Type { get; set; }

    public ICollection<Occurrence> Occurences { get; set; }
  }
}
