using BancoDeEspecies.Domain.Enums;

namespace BancoDeEspecies.Application.ViewModels.StudyCollectMethod
{
    public class CreateStudyCollectMethodViewModel
    {
        public SampleDrawing? SampleDrawing { get; set; }
        public decimal? SamplingEffort { get; set; }
        public string? SamplingEffortUnit { get; set; }
        public DateTime? CollectStartDate { get; set; }
        public DateTime? CollectEndDate { get; set; }
        public int? MaterialDestinationId { get; set; }
        public int? ReferenceId { get; set; }
    }
}
