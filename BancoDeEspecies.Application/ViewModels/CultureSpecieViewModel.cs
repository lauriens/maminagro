namespace BancoDeEspecies.Application.ViewModels
{
  public class CultureSpecieViewModel
  {
    public int? Id { get; set; }
    public string? Name { get; set; }
    public int? GeneraId { get; set; }
    public GenusViewModel? Genera { get; set; }
  }
}
