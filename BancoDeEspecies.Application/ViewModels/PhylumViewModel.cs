namespace BancoDeEspecies.Application.ViewModels
{
  public class PhylumViewModel
  {
    public int? Id { get; set; }
    public string? Name { get; set; }

    public KingdomViewModel? Kingdom { get; set; }
  }
}
