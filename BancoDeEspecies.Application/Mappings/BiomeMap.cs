using AutoMapper;
using BancoDeEspecies.Application.ViewModels.Biome;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class BiomeMap : Profile
    {
        public BiomeMap()
        {
            CreateMap<Biome, BiomeViewModel>();
            CreateMap<CreateBiomeViewModel, Biome>();
        }
    }
}
