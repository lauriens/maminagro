using BancoDeEspecies.Application.ViewModels.Country;

namespace BancoDeEspecies.Application.ViewModels.User
{
  public class UserViewModel
  {
    public int Id { get; set; }
    public string FullName { get; set; }
    public DateTime? CreatedAt { get; }
    public CountryViewModel Country { get; set; }
  }
}
