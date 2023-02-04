using AutoMapper;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class CountryMap : Profile
    {
        public CountryMap()
        {
            CreateMap<Country, CountryViewModel>().ReverseMap();
        }
    }
}
