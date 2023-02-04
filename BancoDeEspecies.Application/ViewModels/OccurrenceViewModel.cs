namespace BancoDeEspecies.Application.ViewModels
{
  public class OccurrenceViewModel
  {
    public int? Id { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public bool? IsDuplicate { get; set; }
    public int? ReferenceId { get; set; }

    public ColetaMethodViewModel? OccurenceMethod { get; set; }
    public SpeciesViewModel? Species { get; set; }
    public ThreatDegreeViewModel? ThreatDegree { get; set; }
    public ICollection<OccurrenceCultureViewModel> OccurrenceCultures { get; set; }

    public ICollection<LocalityViewModel> Locations { get; set; }
  }
}
