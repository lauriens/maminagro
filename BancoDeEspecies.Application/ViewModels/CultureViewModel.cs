namespace BancoDeEspecies.Application.ViewModels
{
  public class CultureViewModel
  {
    public int? Id { get; set; }
    public string? Name { get; set; }
    public string? CommonName { get; set; }
    public string? Variety { get; set; }
    public string? Phenology { get; set; }
    public decimal? PlantedArea { get; set; }
    public int? TimeSincePlanting { get; set; }
    public string? TimeSinclePlantingUnit { get; set; }
    public string? SpeciesType { get; set; }
    public int? SpeciesId { get; set; }
    public CultureSpecieViewModel? Species { get; set; }
  }
}
