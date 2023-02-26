using BancoDeEspecies.Application.ViewModels.Kingdom;

namespace BancoDeEspecies.Application.ViewModels.Phylum
{
  public class PhylumViewModel
  {
    public int Id { get; set; }
    public string Name { get; set; }

    public KingdomViewModel? Kingdom { get; set; }
  }
}
