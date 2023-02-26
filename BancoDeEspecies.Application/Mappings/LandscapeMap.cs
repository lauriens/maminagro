using AutoMapper;
using BancoDeEspecies.Application.ViewModels.Landscape;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class LandscapeMap : Profile
    {
        public LandscapeMap()
        {
            CreateMap<Landscape, LandscapeViewModel>();
            CreateMap<CreateLandscapeViewModel, Landscape>();
            CreateMap<EditLandscapeViewModel, Landscape>();
        }
    }
}
