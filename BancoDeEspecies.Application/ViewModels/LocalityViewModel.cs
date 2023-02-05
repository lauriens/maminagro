namespace BancoDeEspecies.Application.ViewModels
{
    public class LocalityViewModel
    {
        public int? Id { get; set; }
        public MunicipalityViewModel? City { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
    }
}