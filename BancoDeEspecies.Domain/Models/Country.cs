namespace BancoDeEspecies.Domain.Models
{
  public class Country
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? ContinentName { get; set; }

    public ICollection<Uf> Ufs { get; set; }
    public ICollection<User> Users { get; set; }
  }
}
