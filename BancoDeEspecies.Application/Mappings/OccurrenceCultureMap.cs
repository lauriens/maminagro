using AutoMapper;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class OccurrenceCultureMap : Profile
    {
        public OccurrenceCultureMap()
        {
            CreateMap<OccurrenceCulture, OccurrenceCultureViewModel>().ReverseMap();
        }
    }
}
