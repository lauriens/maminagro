using BancoDeEspecies.Domain.Enums;

namespace BancoDeEspecies.Domain.Models
{
    public class Culture
  {
    public int Id { get; set; }
    public string? CommonName { get; set; }
    public string? Variety { get; set; }
    public string? Phenology { get; set; }
    public decimal? PlantedArea { get; set; }
    public int? TimeSincePlanting { get; set; }
    public TimeUnits TimeSincePlantingUnit { get; set; }
    public int? LandscapeId { get; set; }
    public Landscape? Landscape { get; set; }
    public CultureSpeciesType? SpeciesType { get; set; }
    public int? SpecieId { get; set; }

    public CultureSpecie? Specie { get; set; }
    public ICollection<OccurrenceCulture> OccurrenceCultures { get; set; }
    }
}
