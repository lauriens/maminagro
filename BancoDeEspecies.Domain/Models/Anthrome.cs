namespace BancoDeEspecies.Domain.Models
{
  public class Anthrome
  {
    public int Id { get; set; }
    public string? Name { get; set; }

    public ICollection<Landscape> Landscapes { get; set; }
  }
}
