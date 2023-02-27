namespace BancoDeEspecies.Domain.Models
{
  public class User
  {
    public int Id { get; set; }
    public string? FullName { get; set; }
    public int? CountryId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now.ToUniversalTime();
    public Country Country { get; set; }
  }
}
