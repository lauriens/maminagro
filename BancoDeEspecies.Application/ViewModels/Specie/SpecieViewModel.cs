using BancoDeEspecies.Application.ViewModels.Genus;
using BancoDeEspecies.Application.ViewModels.ThreatDegree;

namespace BancoDeEspecies.Application.ViewModels.Specie
{
  public class SpecieViewModel
  {
    public int Id { get; set; }
    public string Name { get; set; }

    public GenusViewModel? Genus { get; set; }
    public ICollection<ThreatDegreeViewModel> ThreatDegrees { get; set; }
  }
}
