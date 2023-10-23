using BancoDeEspecies.Domain.Enums;

namespace BancoDeEspecies.Application.ViewModels.ThreatDegree
{
    public class EditThreatDegreeViewModel
    {
        public int Id { get; set; }
        public string? Classification { get; set; }
        public DateTime? ResolutionDate { get; set; }
        public ThreatDegreeSource Source { get; set; }
        public int? UfId { get; set; }
        public int? CountryId { get; set; }
        public int? SpecieId { get; set; }
    }
}
