namespace BancoDeEspecies.Domain.Models
{
  public class Genus
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public Family? Family { get; set; }
    public int? FamilyId { get; set; }

    public ICollection<CultureSpecie> CultureSpecies { get; set; }
    public ICollection<Specie> Species { get; set; }
  }
}
