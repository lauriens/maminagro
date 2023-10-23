namespace BancoDeEspecies.Domain.Models
{
  public class OccurrenceCulture
  {
    public int CultureId { get; set; }
    public int OccurenceId { get; set; }
    public string? Stage { get; set; }
    public string? Phenology { get; set; }
    public int? Percentage { get; set; }
    public bool? IsMajority { get; set; }
    public decimal? Area { get; set; }
    public decimal? Productivity { get; set; }

    public Culture Culture { get; set; }
    public Occurrence Occurrence { get; set; }
  }
}
