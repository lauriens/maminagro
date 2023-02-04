namespace BancoDeEspecies.Domain.Models
{
  public class Reference
  {
    public int Id { get; set; }
    public string? AuthorName { get; set; }
    public int? Year { get; set; }
    public int? ReferenceTypeId { get; set; }
    public string? ReferenceId { get; set; }
    public string? BibtexKey { get; set; }

    public ReferenceType? ReferenceType { get; set; }
    public ICollection<Landscape> Landscapes { get; set; }
    public ICollection<Occurrence> Occurences { get; set; }
    public ICollection<StudyCollectMethod> StudyCollectMethods { get; set; }
  }
}
