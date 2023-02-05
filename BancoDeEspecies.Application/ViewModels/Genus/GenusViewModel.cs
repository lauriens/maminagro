using BancoDeEspecies.Application.ViewModels.Family;

namespace BancoDeEspecies.Application.ViewModels.Genus
{
  public class GenusViewModel
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public FamilyViewModel? Family { get; set; }

  }
}
