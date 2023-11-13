using BancoDeEspecies.Application.ViewModels.Abundance;
using BancoDeEspecies.Application.ViewModels.Locality;
using BancoDeEspecies.Application.ViewModels.OccurrenceColetaMethod;
using BancoDeEspecies.Application.ViewModels.OccurrenceCulture;
using BancoDeEspecies.Application.ViewModels.Reference;
using BancoDeEspecies.Application.ViewModels.Specie;
using BancoDeEspecies.Application.ViewModels.ThreatDegree;
using BancoDeEspecies.Application.ViewModels.User;
using BancoDeEspecies.Domain.Enums;

namespace BancoDeEspecies.Application.ViewModels.Occurrence
{
  public class OccurrenceViewModel
  {
    public int Id { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public DateTime OccurrenceTime { get; set; }
    public string OccurrenceType { get; set; }
    public bool IsSnucOccurrence { get; set; }
    public bool? IsDuplicate { get; set; }
    public string ReviewerObservation { get; set; }

    public OccurrenceColetaMethodViewModel? OccurrenceColetaMethod { get; set; }
    public ReferenceViewModel Reference { get; set; }
    public SpecieViewModel? Specie { get; set; }
    public ThreatDegreeViewModel? ThreatDegree { get; set; }
    public UserViewModel User { get; set; }
    public ICollection<AbundanceViewModel> Abundances { get; set; }
    public ICollection<OccurrenceCultureViewModel> OccurrenceCultures { get; set; }
    public LocalityViewModel Locality { get; set; }
  }
}
