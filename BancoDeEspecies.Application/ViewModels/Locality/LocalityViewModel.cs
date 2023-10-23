using BancoDeEspecies.Application.ViewModels.SampleAreaType;

namespace BancoDeEspecies.Application.ViewModels.Locality
{
    public class LocalityViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public SampleAreaTypeViewModel SampleAreaType { get; set; }
    }
}