namespace BancoDeEspecies.Domain.Models
{
  public class User
  {
    public int Id { get; set; }
    public string? FullName { get; set; }
    public int? CountryId { get; set; }
    public Country Country { get; set; }
    public ICollection<Review> Reviews { get; set; }
  }
}
