namespace BancoDeEspecies.Application.ViewModels.Locality
{
    public class CreateLocalityViewModel
    {
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public int? MunicipalityId { get; set; }
        public int? SampleAreaTypeId { get; set; }
    }
}
