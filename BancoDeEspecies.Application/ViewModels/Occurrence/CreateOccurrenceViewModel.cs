using BancoDeEspecies.Domain.Enums;

namespace BancoDeEspecies.Application.ViewModels.Occurrence
{
    public class CreateOccurrenceViewModel
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime OccurrenceTime { get; set; }
        public OccurrenceType OccurrenceType { get; set; }
        public bool IsSnucOccurrence { get; set; }
        public bool? IsDuplicate { get; set; }
        public string ReviewerObservation { get; set; }

        public int? ThreatDegreeId { get; set; }
        public int? OccurenceMethodId { get; set; }
        public int? SpecieId { get; set; }
        public int? ReferenceId { get; set; }
        public int? LocalityId { get; set; }
        public int CreatedBy { get; set; }
    }
}
