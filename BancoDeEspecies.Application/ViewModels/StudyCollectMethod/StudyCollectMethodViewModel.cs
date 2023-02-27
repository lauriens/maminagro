using BancoDeEspecies.Application.ViewModels.MaterialDestination;
using BancoDeEspecies.Application.ViewModels.Reference;
using BancoDeEspecies.Domain.Enums;

namespace BancoDeEspecies.Application.ViewModels.StudyCollectMethod
{
  public class StudyCollectMethodViewModel
  {
    public int Id { get; set; }
    public SampleDrawing? SampleDrawing { get; set; }
    public decimal? SamplingEffort { get; set; }
    public string? SamplingEffortUnit { get; set; }
    public DateTime? CollectStartDate { get; set; }
    public DateTime? CollectEndDate { get; set; }

    public MaterialDestinationViewModel? MaterialDestination { get; set; }
    public ReferenceViewModel Reference { get; set; }
  }
}
