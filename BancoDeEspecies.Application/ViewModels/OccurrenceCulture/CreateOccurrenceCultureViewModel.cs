namespace BancoDeEspecies.Application.ViewModels.OccurrenceCulture
{
    public class CreateOccurrenceCultureViewModel
    {
        public int CultureId { get; set; }
        public int OccurrenceId { get; set; }
        public string? Stage { get; set; }
        public string? Phenology { get; set; }
        public int? Percentage { get; set; }
        public bool? IsMajority { get; set; }
        public decimal? Area { get; set; }
        public decimal? Productivity { get; set; }
    }
}
