using AutoMapper;
using BancoDeEspecies.Application.ViewModels.LandscapeStatistic;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class LandscapeStatisticMap : Profile
    {
        public LandscapeStatisticMap()
        {
            CreateMap<LandscapeStatistic, LandscapeStatisticViewModel>();
            CreateMap<CreateLandscapeStatisticViewModel, LandscapeStatistic>();
            CreateMap<EditLandscapeStatisticViewModel, LandscapeStatistic>();
        }
    }
}
