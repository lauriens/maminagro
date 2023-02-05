using AutoMapper;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class MunicipalityMap : Profile
    {
        public MunicipalityMap()
        {
            CreateMap<Municipality, MunicipalityViewModel>().ReverseMap();
        }
    }
}
