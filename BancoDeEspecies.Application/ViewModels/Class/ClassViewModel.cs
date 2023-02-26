using BancoDeEspecies.Application.ViewModels.Phylum;

namespace BancoDeEspecies.Application.ViewModels.Class
{
  public class ClassViewModel
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public PhylumViewModel? Phylum { get; set; }
  }
}
