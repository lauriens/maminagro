namespace BancoDeEspecies.Domain.Models
{
  public class MaterialDestination
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? GbifId { get; set; }

    public ICollection<StudyCollectMethod> StudyCollectMethods { get; set; }
  }
}
