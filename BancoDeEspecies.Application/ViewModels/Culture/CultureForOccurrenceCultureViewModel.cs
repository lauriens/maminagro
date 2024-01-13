using BancoDeEspecies.Application.ViewModels.CultureSpecie;

namespace BancoDeEspecies.Application.ViewModels.Culture
{
    public class CultureForOccurrenceCultureViewModel
    {
        public int Id { get; set; }
        public string? CommonName { get; set; }
        public string? Variety { get; set; }
        public string? Phenology { get; set; }
        public decimal? PlantedArea { get; set; }
        public int? TimeSincePlanting { get; set; }
        public string? TimeSincePlantingUnit { get; set; }
        public string SpeciesType { get; set; }
        public CultureSpecieViewModel? Specie { get; set; }
    }
}
