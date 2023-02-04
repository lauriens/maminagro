using AutoMapper;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class LandscapeMap : Profile
    {
        public LandscapeMap()
        {
            CreateMap<Landscape, LandscapeViewModel>().ReverseMap();
        }
    }
}
