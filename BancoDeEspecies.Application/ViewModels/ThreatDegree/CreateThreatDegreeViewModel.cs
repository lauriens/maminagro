using BancoDeEspecies.Domain.Enums;

namespace BancoDeEspecies.Application.ViewModels.ThreatDegree
{
    public class CreateThreatDegreeViewModel
    {
        public string? Classification { get; set; }
        public DateTime? ResolutionDate { get; set; }
        public ThreatDegreeSource Source { get; set; }
        public int? UfId { get; set; }
        public int? CountryId { get; set; }
        public int? SpecieId { get; set; }
    }
}
