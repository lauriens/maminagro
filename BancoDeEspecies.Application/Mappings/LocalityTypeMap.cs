using AutoMapper;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class LocalityTypeMap : Profile
    {
        public LocalityTypeMap()
        {
            CreateMap<LocalityType, LocationTypeViewModel>().ReverseMap();
        }
    }
}
