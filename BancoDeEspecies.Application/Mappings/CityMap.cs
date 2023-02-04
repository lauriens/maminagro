using AutoMapper;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class CityMap : Profile
    {
        public CityMap()
        {
            CreateMap<City, CityViewModel>().ReverseMap();
        }
    }
}
