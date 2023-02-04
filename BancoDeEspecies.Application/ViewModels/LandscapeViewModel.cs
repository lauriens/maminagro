namespace BancoDeEspecies.Application.ViewModels
{
  public class LandscapeViewModel
  {
    public int? Id { get; set; }
    public decimal? Latitude { get; set; }
    public decimal? Longitude { get; set; }
    public decimal? Radius { get; set; }
    public string? Description { get; set; }
    public bool? IsProtectedArea { get; set; }
    public int? BiomeId { get; set; }
    public int? AnthromeId { get; set; }
    public int? CityId { get; set; }
    public int? ReferenceId { get; set; }

    public BiomeViewModel? Anthrome { get; set; }
    public BiomeViewModel? Biome { get; set; }
    public CityViewModel? City { get; set; }
    public ICollection<LandscapeAreaTypeViewModel> LandscapeAreaTypes { get; set; }
    public ICollection<LandscapeStatisticViewModel> LandscapeStatistics { get; set; }

    public ICollection<LocalityViewModel> Locations { get; set; }
  }
}
