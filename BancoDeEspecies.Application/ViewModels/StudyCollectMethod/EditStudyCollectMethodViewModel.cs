using BancoDeEspecies.Domain.Enums;

namespace BancoDeEspecies.Application.ViewModels.StudyCollectMethod
{
    public class EditStudyCollectMethodViewModel
    {
        public int Id { get; set; }
        public SampleDrawing? SampleDrawing { get; set; }
        public decimal? SamplingEffort { get; set; }
        public string? SamplingEffortUnit { get; set; }
        public int? Type { get; set; }
        public DateTime? CollectStartDate { get; set; }
        public DateTime? CollectEndDate { get; set; }
        public int? MaterialDestinationId { get; set; }
    }
}
