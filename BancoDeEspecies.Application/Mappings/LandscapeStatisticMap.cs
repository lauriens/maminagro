using AutoMapper;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class LandscapeStatisticMap : Profile
    {
        public LandscapeStatisticMap()
        {
            CreateMap<LandscapeStatistic, LandscapeStatisticViewModel>().ReverseMap();
        }
    }
}
