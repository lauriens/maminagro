namespace BancoDeEspecies.Domain.Models
{
  public class Phylum
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public int? KingdomId { get; set; }

    public Kingdom? Kingdom { get; set; }
    public ICollection<Class> Classes { get; set; }
  }
}
