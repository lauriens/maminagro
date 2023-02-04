namespace BancoDeEspecies.Application.ViewModels
{
  public class ReferenceViewModel
  {
    public int? Id { get; set; }
    public string? AuthorName { get; set; }
    public int? Year { get; set; }

    public ReferenceTypeViewModel? ReferenceType { get; set; }
    public ICollection<StudyCollectMethodViewModel> StudyCollectMethods { get; set; }
  }
}
