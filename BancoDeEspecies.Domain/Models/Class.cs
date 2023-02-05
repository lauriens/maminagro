namespace BancoDeEspecies.Domain.Models
{
  public class Class
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public Phylum? Phylum { get; set; }
    public int? PhylumId { get; set; }
    public ICollection<Order> Orders { get; set; } = new List<Order>();
  }
}
