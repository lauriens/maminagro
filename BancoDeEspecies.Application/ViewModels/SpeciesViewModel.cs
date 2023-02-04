namespace BancoDeEspecies.Application.ViewModels
{
  public class SpeciesViewModel
  {
    public int? Id { get; set; }
    public string? Name { get; set; }
    public int? IucnThreatDegree { get; set; }
    public int? NationalThreatDegree { get; set; }

    public GenusViewModel? Genus { get; set; }
    public ICollection<ThreatDegreeViewModel> ThreatDegrees { get; set; }
  }
}
