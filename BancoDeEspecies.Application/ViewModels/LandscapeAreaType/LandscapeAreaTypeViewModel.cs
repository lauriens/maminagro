using BancoDeEspecies.Application.ViewModels.AreaType;
using BancoDeEspecies.Application.ViewModels.Landscape;

namespace BancoDeEspecies.Application.ViewModels.LandscapeAreaType
{
    public class LandscapeAreaTypeViewModel
    {
        public int Id { get; set; }
        public LandscapeViewModel Landscape { get; set; }
        public AreaTypeViewModel AreaType { get; set; }
        public decimal? Percentage { get; set; }
    }
}
