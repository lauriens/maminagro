using BancoDeEspecies.Domain.Enums;

namespace BancoDeEspecies.Application.ViewModels.Landscape
{
    public class CreateLandscapeViewModel
    {
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public decimal? Radius { get; set; }
        public string? Description { get; set; }
        public bool? IsProtectedArea { get; set; }
        public int? AgroecosystemId { get; set; }
        public int? AnthromeId { get; set; }
        public int? SampleAreaTypeId { get; set; }
        public int? ReferenceId { get; set; }
    }
}
