using BancoDeEspecies.Application.ViewModels.Country;
using BancoDeEspecies.Application.ViewModels.Specie;
using BancoDeEspecies.Application.ViewModels.Uf;

namespace BancoDeEspecies.Application.ViewModels.ThreatDegree
{
    public class ThreatDegreeViewModel
    {
        public int Id { get; set; }
        public string? Classification { get; set; }
        public DateTime? ResolutionDate { get; set; }
        public string Source { get; set; }

        public SpecieViewModel? Specie { get; set; }
        public UfViewModel? Uf { get; set; }
        public CountryViewModel Country { get; set; }
    }
}
