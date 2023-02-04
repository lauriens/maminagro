namespace BancoDeEspecies.Domain.Models
{
  public class CultureSpecie
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public int? GenusId { get; set; }

    public Genus? Genus { get; set; }
    public ICollection<Culture> Cultures { get; set; }
  }
}
