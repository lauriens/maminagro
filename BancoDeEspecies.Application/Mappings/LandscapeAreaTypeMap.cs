using AutoMapper;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class LandscapeAreaTypeMap : Profile
    {
        public LandscapeAreaTypeMap()
        {
            CreateMap<LandscapeAreaType, LandscapeAreaTypeViewModel>().ReverseMap();
        }
    }
}
