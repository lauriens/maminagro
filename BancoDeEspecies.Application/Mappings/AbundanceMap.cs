using AutoMapper;
using BancoDeEspecies.Application.ViewModels.Abundance;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class AbundanceMap : Profile
    {
        public AbundanceMap()
        {
            CreateMap<Abundance, AbundanceViewModel>();
            CreateMap<CreateAbundanceViewModel, Abundance>();
            CreateMap<EditAbundanceViewModel, Abundance>();
        }
    }
}
