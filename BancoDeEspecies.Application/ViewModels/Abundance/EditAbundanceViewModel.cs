namespace BancoDeEspecies.Application.ViewModels.Abundance
{
    public class EditAbundanceViewModel
    {
        public int Id { get; set; }
        public string AbundanceValue { get; set; }
        public int? LandscapeId { get; set; }
        public int? OccurrenceId { get; set; }
    }
}
