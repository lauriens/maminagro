namespace BancoDeEspecies.Domain.Models
{
  public class Locality
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal? Latitude { get; set; }
    public decimal? Longitude { get; set; }
    public int? TypeId { get; set; }

    public SampleAreaType? LocalityType { get; set; }

    public ICollection<Landscape> Landscapes { get; set; }
    public ICollection<Occurrence> Occurrences { get; set; }
  }
}
