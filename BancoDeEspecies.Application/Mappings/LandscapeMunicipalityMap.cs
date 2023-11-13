using AutoMapper;
using BancoDeEspecies.Application.ViewModels.LandscapeMunicipality;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class LandscapeMunicipalityMap : Profile
    {
        public LandscapeMunicipalityMap()
        {
            CreateMap<CreateLandscapeMunicipalityViewModel, LandscapeMunicipality>().ReverseMap();
        }
    }
}
