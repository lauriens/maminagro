namespace BancoDeEspecies.Application.ViewModels.Abundance
{
    public class AbundanceViewModel
    {
        public int Id { get; set; }
        public string AbundanceValue { get; set; }
        public LandscapeViewModel Landscape { get; set; }
        public OccurrenceViewModel Occurrence { get; set; }
    }
}
