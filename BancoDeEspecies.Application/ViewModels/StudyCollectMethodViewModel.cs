namespace BancoDeEspecies.Application.ViewModels
{
  public class StudyCollectMethodViewModel
  {
    public int? Id { get; set; }
    public int? SampleDrawing { get; set; }
    public decimal? SamplingEffort { get; set; }
    public string? SamplingEffortUnit { get; set; }
    public int? Type { get; set; }
    public DateTime? CollectStartDate { get; set; }
    public DateTime? CollectEndDate { get; set; }

    public MaterialDestinationViewModel? MaterialDestination { get; set; }
  }
}
