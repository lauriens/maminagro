using AutoMapper;
using BancoDeEspecies.Application.ViewModels.Country;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class CountryMap : Profile
    {
        public CountryMap()
        {
            CreateMap<Country, CountryViewModel>();
            CreateMap<CreateCountryViewModel, Country>();
        }
    }
}
