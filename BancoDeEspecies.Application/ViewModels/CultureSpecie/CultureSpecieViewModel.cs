using BancoDeEspecies.Application.ViewModels.Genus;

namespace BancoDeEspecies.Application.ViewModels.CultureSpecie
{
  public class CultureSpecieViewModel
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public GenusViewModel? Genus { get; set; }
  }
}
