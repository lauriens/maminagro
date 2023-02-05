using BancoDeEspecies.Domain.Enums;

namespace BancoDeEspecies.Application.ViewModels.Culture
{
    public class EditCultureViewModel
    {
        public int Id { get; set; }
        public string? CommonName { get; set; }
        public string? Variety { get; set; }
        public string? Phenology { get; set; }
        public decimal? PlantedArea { get; set; }
        public int? TimeSincePlanting { get; set; }
        public string? TimeSinclePlantingUnit { get; set; }
        public CultureSpeciesType SpeciesType { get; set; }
        public int? SpecieId { get; set; }
        public int? LandscapeId { get; set; }
    }
}
