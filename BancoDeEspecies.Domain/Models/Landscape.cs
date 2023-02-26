using BancoDeEspecies.Domain.Enums;
using System;
using System.Collections.Generic;

namespace BancoDeEspecies.Domain.Models
{
    public class Landscape
  {
    public int Id { get; set; }
    public decimal? Latitude { get; set; }
    public decimal? Longitude { get; set; }
    public decimal? Radius { get; set; }
    public string? Description { get; set; }
    public bool? IsProtectedArea { get; set; }
    public Agroecosystem Agroecosystem { get; set; }
    public int? AnthromeId { get; set; }
    public int? CityId { get; set; }
    public int? ReferenceId { get; set; }
    public int? SampleAreaTypeId { get; set; }
    public Anthrome? Anthrome { get; set; }
    public Municipality? Municipality { get; set; }
    public Reference? Reference { get; set; }
    public SampleAreaType SampleAreaType { get; set; }
    public ICollection<Abundance> Abundances { get; set; }
    public ICollection<Biome>? Biomes { get; set; }
    public ICollection<Culture> Cultures { get; set; }
    public ICollection<LandscapeAreaType> LandscapeAreaTypes { get; set; }
    public ICollection<LandscapeStatistic> LandscapeStatistics { get; set; }

    public ICollection<Locality> Localities { get; set; }
  }
}
