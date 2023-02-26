using BancoDeEspecies.Domain.Enums;

namespace BancoDeEspecies.Application.ViewModels.Landscape
{
    public class EditLandscapeViewModel
    {
        public int Id { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public decimal? Radius { get; set; }
        public string? Description { get; set; }
        public bool? IsProtectedArea { get; set; }
        public Agroecosystem Agroecosystem { get; set; }
        public int? AnthromeId { get; set; }
        public int? MunicipalityId { get; set; }
        public int? SampleAreaTypeId { get; set; }
        public int? ReferenceId { get; set; }
    }
}
