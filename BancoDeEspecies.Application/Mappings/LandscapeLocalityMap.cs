using AutoMapper;
using BancoDeEspecies.Application.ViewModels.LandscapeLocality;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class LandscapeLocalityMap : Profile
    {
        public LandscapeLocalityMap()
        {
            CreateMap<CreateLandscapeLocalityViewModel, LandscapeLocality>();
        }
    }
}
