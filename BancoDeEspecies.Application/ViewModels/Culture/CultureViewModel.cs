using BancoDeEspecies.Application.ViewModels.CultureSpecie;
using BancoDeEspecies.Domain.Enums;

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
    public CultureSpeciesType SpeciesType { get; set; }
    public CultureSpecieViewModel? Specie { get; set; }
  }
}
