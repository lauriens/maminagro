using AutoMapper;
using BancoDeEspecies.Application.ViewModels.Municipality;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class MunicipalityMap : Profile
    {
        public MunicipalityMap()
        {
            CreateMap<Municipality, MunicipalityViewModel>();
            CreateMap<CreateMunicipalityViewModel, Municipality>();
            CreateMap<EditMunicipalityViewModel, Municipality>();
        }
    }
}
