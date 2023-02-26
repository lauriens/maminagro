using BancoDeEspecies.Application.ViewModels.Abundance;
using BancoDeEspecies.Application.ViewModels.Anthrome;
using BancoDeEspecies.Application.ViewModels.Biome;
using BancoDeEspecies.Application.ViewModels.LandscapeAreaType;
using BancoDeEspecies.Application.ViewModels.LandscapeStatistic;
using BancoDeEspecies.Application.ViewModels.Locality;
using BancoDeEspecies.Application.ViewModels.Municipality;
using BancoDeEspecies.Application.ViewModels.Reference;
using BancoDeEspecies.Application.ViewModels.SampleAreaType;
using BancoDeEspecies.Domain.Enums;

namespace BancoDeEspecies.Application.ViewModels.Landscape
{
  public class LandscapeViewModel
  {
    public int Id { get; set; }
    public decimal? Latitude { get; set; }
    public decimal? Longitude { get; set; }
    public decimal? Radius { get; set; }
    public string? Description { get; set; }
    public bool? IsProtectedArea { get; set; }
    public Agroecosystem Agroecosystem { get; set; }

    public AnthromeViewModel? Anthrome { get; set; }
    public MunicipalityViewModel? Municipality { get; set; }
    public SampleAreaTypeViewModel? SampleAreaType { get; set; }
    public ReferenceViewModel? Reference { get; set; }
    public ICollection<AbundanceViewModel> Abundances { get; set; }
    public ICollection<BiomeViewModel> Biome { get; set; }
    public ICollection<LandscapeAreaTypeViewModel> LandscapeAreaTypes { get; set; }
    public ICollection<LandscapeStatisticViewModel> LandscapeStatistics { get; set; }

    public ICollection<LocalityViewModel> Locations { get; set; }
  }
}
