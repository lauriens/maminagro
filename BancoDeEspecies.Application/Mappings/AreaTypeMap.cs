using AutoMapper;
using BancoDeEspecies.Application.ViewModels.AreaType;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class AreaTypeMap : Profile
    {
        public AreaTypeMap()
        {
            CreateMap<AreaType, AreaTypeViewModel>();
            CreateMap<CreateAreaTypeViewModel, AreaType>();
        }
    }
}
