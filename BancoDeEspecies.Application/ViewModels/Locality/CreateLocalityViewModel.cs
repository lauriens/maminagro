namespace BancoDeEspecies.Application.ViewModels.Locality
{
    public class CreateLocalityViewModel
    {
        public string Name { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public int? SampleAreaTypeId { get; set; }
    }
}
