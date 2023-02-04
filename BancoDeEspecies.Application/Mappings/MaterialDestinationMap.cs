using AutoMapper;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class MaterialDestinationMap : Profile
    {
        public MaterialDestinationMap()
        {
            CreateMap<MaterialDestination, MaterialDestinationViewModel>().ReverseMap();
        }
    }
}
