namespace BancoDeEspecies.Application.ViewModels.Locality
{
    public class EditLocalityViewModel
    {
        public int Id { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public int? MunicipalityId { get; set; }
        public int? SampleAreaTypeId { get; set; }
    }
}
