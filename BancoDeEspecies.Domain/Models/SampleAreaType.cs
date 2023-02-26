namespace BancoDeEspecies.Domain.Models
{
  public class SampleAreaType
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool? IsSnuc { get; set; }

    public ICollection<Landscape> Landscapes { get; set; }
    public ICollection<Locality> Localities { get; set; }
  }
}
