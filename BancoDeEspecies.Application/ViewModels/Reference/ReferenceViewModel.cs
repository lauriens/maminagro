using BancoDeEspecies.Application.ViewModels.ReferenceType;
using BancoDeEspecies.Application.ViewModels.StudyCollectMethod;

namespace BancoDeEspecies.Application.ViewModels.Reference
{
  public class ReferenceViewModel
  {
    public int Id { get; set; }
    public string? AuthorName { get; set; }
    public string? Title { get; set; }
    public int? Year { get; set; }
    public string? BibtexKey { get; set; }

    public ReferenceTypeViewModel? ReferenceType { get; set; }
    public ICollection<StudyCollectMethodViewModel> StudyCollectMethods { get; set; }
  }
}
