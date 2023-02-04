using AutoMapper;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class AreaTypeMap : Profile
    {
        public AreaTypeMap()
        {
            CreateMap<AreaType, AreaTypeViewModel>().ReverseMap();
        }
    }
}
