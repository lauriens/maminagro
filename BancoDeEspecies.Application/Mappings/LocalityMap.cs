using AutoMapper;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class LocalityMap : Profile
    {
        public LocalityMap()
        {
            CreateMap<Locality, LocalityViewModel>().ReverseMap();
        }
    }
}
