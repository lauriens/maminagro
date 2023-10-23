using BancoDeEspecies.Application.ViewModels.CultureSpecie;
using BancoDeEspecies.Application.ViewModels.OccurrenceCulture;

namespace BancoDeEspecies.Application.ViewModels.Culture
{
    public class CultureViewModel
    {
        public int Id { get; set; }
        public string? CommonName { get; set; }
        public string? Variety { get; set; }
        public string? Phenology { get; set; }
        public decimal? PlantedArea { get; set; }
        public int? TimeSincePlanting { get; set; }
        public string? TimeSinclePlantingUnit { get; set; }
        public string SpeciesType { get; set; }
        public CultureSpecieViewModel? Specie { get; set; }
        public IEnumerable<OccurrenceCultureViewModel> OccurrenceCultures { get; set; }
    }
}
