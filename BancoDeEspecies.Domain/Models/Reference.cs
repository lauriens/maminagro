﻿namespace BancoDeEspecies.Domain.Models
{
  public class Reference
  {
    public int Id { get; set; }
    public string? AuthorName { get; set; }
    public string? Title { get; set; }
    public int? Year { get; set; }
    public string? BibtexKey { get; set; }
    public int ReferenceTypeId { get; set; }

    public ReferenceType? ReferenceType { get; set; }
    public ICollection<Landscape> Landscapes { get; set; }
    public ICollection<Occurrence> Occurrences { get; set; }
    public ICollection<StudyCollectMethod> StudyCollectMethods { get; set; }
  }
}
