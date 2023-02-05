using BancoDeEspecies.Application.ViewModels.Domain;

namespace BancoDeEspecies.Application.ViewModels.Kingdom
{
  public class KingdomViewModel
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public DomainViewModel? Domain { get; set; }

  }
}
