namespace BancoDeEspecies.Application.ViewModels.Reference
{
    public class EditReferenceViewModel
    {
        public int Id { get; set; }
        public string? Author { get; set; }
        public string? Title { get; set; }
        public int? Year { get; set; }
        public int? ReferenceTypeId { get; set; }
        public string? BibtexKey { get; set; }
    }
}
