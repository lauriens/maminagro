namespace BancoDeEspecies.Domain.Models
{
  public class Kingdom
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public Domain? Domain { get; set; } = null;
    public int? DomainId { get; set; }

    public ICollection<Phylum> Phyla { get; set; }
  }
}
