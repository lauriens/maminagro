namespace BancoDeEspecies.Application.ViewModels
{
    public class AbundanceViewModel
    {
        public int? Id { get; set; }
        public string AbundanceValue { get; set; }
        public int? LandscapeId { get; set; }
        public int? OccurrenceId { get; set; }
        public LandscapeViewModel Landscape { get; set; }
        public OccurrenceViewModel Occurrence { get; set; }
    }
}
