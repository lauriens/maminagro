namespace BancoDeEspecies.Domain.Models
{
  public class LocalityType
  {
    public int Id { get; set; }
    public string? Name { get; set; }

    public ICollection<Locality> Localities { get; set; }
  }
}
