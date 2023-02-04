namespace BancoDeEspecies.Application.ViewModels
{
  public class ThreatDegreeViewModel
  {
    public int? Id { get; set; }
    public string? Classification { get; set; }
    public DateTime? MmaDate { get; set; }
    public DateTime? IucnDate { get; set; }
    public DateTime? UfResolutionDate { get; set; }
    public int? UfId { get; set; }
    public int? SpeciesId { get; set; }

    public SpeciesViewModel? Species { get; set; }
    public UfViewModel? Uf { get; set; }
  }
}
