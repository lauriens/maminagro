using AutoMapper;
using BancoDeEspecies.Application.ViewModels.BiomeLandscape;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class BiomeLandscapeMap : Profile
    {
        public BiomeLandscapeMap()
        {
            CreateMap<CreateBiomeLandscapeViewModel, BiomeLandscape>().ReverseMap();
        }
    }
}
