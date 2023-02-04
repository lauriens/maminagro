using System;
using System.Collections.Generic;

namespace BancoDeEspecies.Domain.Models
{
  public class StudyCollectMethod
  {
    public int Id { get; set; }
    public int? SampleDrawing { get; set; }
    public decimal? SamplingEffort { get; set; }
    public string? SamplingEffortUnit { get; set; }
    public int? Type { get; set; }
    public DateTime? CollectStartDate { get; set; }
    public DateTime? CollectEndDate { get; set; }
    public int? MaterialDestinationId { get; set; }
    public int? ReferenceId { get; set; }

    public MaterialDestination? MaterialDestination { get; set; }
    public Reference? Reference { get; set; }
  }
}
